using FinalWindow.Database;
using FinalWindow.SalaryDecorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.Director
{
    public partial class CalculateManagerSalaryForm : Form
    {
        private float baseSalary;
        private List<SalaryDecoratorClass> modifiers;
        public CalculateManagerSalaryForm()
        {
            InitializeComponent();
            modifiers = new List<SalaryDecoratorClass>();
        }

        private void ApplyModifiers()
        {
            float updatedSalary = baseSalary;

            
            foreach (var modifier in modifiers)
            {
                updatedSalary = modifier.ModifySalary(updatedSalary);
            }

            
            label_totalSalary.Text = updatedSalary.ToString();
        }

        private void CalculateSalaryForm_Load(object sender, EventArgs e)
        {
            baseSalary = float.Parse(label_totalSalary.Text);
        }

        private void checkBox_Harworking_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Harworking.Checked)
            {
                modifiers.Add(new HardworkingBonus());
            }
            else
            {
                modifiers.RemoveAll(m => m is HardworkingBonus);
            }

            ApplyModifiers();
        }
        private void checkBox_late_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_late.Checked)
            {
                modifiers.Add(new FineLate());
            }
            else
            {
                modifiers.RemoveAll(m => m is FineLate);
            }

            ApplyModifiers();
        }

        private void checkBox_longevityBonus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_longevityBonus.Checked)
            {
                modifiers.Add(new LongevityBonus());
            }
            else
            {
                modifiers.RemoveAll(m => m is LongevityBonus);
            }

            ApplyModifiers();
        }

        private void checkBox_laziness_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_laziness.Checked)
            {
                modifiers.Add(new FineLaziness());
            }
            else
            {
                modifiers.RemoveAll(m => m is FineLaziness);
            }

            ApplyModifiers();
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {
            float TotalSalary = float.Parse(label_totalSalary.Text);
            string cardid = label_manCardID.Text;
            DatabaseContext context = new DatabaseContext();
            var manager = context.Users.OfType<Model.Manager>().Where(t => t.cardID == cardid).FirstOrDefault();

            manager.totalSalary = TotalSalary;
            context.SaveChanges();
            MessageBox.Show("Update salary successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}
