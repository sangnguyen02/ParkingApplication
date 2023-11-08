using FinalWindow.Database;
using FinalWindow.Model;
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
    public partial class PayRollManagerForm : Form
    {
        public PayRollManagerForm()
        {
            InitializeComponent();
        }

        private void PayRollManagerForm_Load(object sender, EventArgs e)
        {
            loadFacility();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            if ((DataGridViewImageColumn)dataGridView_listManager.Columns[3] != null)
            {
                picCol = (DataGridViewImageColumn)dataGridView_listManager.Columns[3];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            

        }

        void loadFacility()
        {
            DatabaseContext context = new DatabaseContext();
            comboBox_facilityAddress.DataSource = context.Facilities.ToList();
            comboBox_facilityAddress.DisplayMember = "address";
            comboBox_facilityAddress.ValueMember = "ID";
            //comboBox_facilityAddress.SelectedIndex = null;
        }

        

        private void comboBox_facilityAddress_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_facilityAddress.SelectedValue != null && int.TryParse(comboBox_facilityAddress.SelectedValue.ToString(), out int facilityId))
            {
                try
                {
                    using (var context = new DatabaseContext())
                    {
                        var managerData = context.Users.OfType<Model.Manager>().Where(t => t.facilityID == facilityId)
                            .Select(m => new
                            {
                                CardID = m.cardID,
                                FirstName = m.firstName,
                                LastName = m.lastName,
                                Picture = m.picture,
                                TotalSalary = m.totalSalary,
                                SalaryID = m.salaryID,
                            })
                            .ToList();

                        dataGridView_listManager.DataSource = managerData;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dataGridView_listManager_Click(object sender, EventArgs e)
        {
            CalculateManagerSalaryForm calculateSalaryForm = new CalculateManagerSalaryForm();
            
            
            if(dataGridView_listManager.CurrentRow.Cells["SalaryID"].Value != null)
            {
                int value = (int)dataGridView_listManager.CurrentRow.Cells["SalaryID"].Value;
                string firstName = dataGridView_listManager.CurrentRow.Cells["FirstName"].Value.ToString();
                string cardID = dataGridView_listManager.CurrentRow.Cells["CardID"].Value.ToString();
                using (DatabaseContext context = new DatabaseContext())
                {
                    var salary = context.Salaries.Where(t => t.salaryID == value).FirstOrDefault();
                    var manager = context.Users.OfType<Model.Manager>().Where(t => t.salaryID == value).FirstOrDefault();

                    if (salary != null && manager != null)
                    {
                        float? totalSalary = salary.BasicSalary * manager.coefficients;
                        manager.totalSalary = totalSalary;
                        
                        context.SaveChanges();

                        
                        calculateSalaryForm.label_totalSalary.Text = totalSalary.ToString();
                        calculateSalaryForm.label_manCardID.Text = cardID;
                        calculateSalaryForm.label_FirstName.Text = firstName;

                    }
                }
                calculateSalaryForm.Show();
            }
            
            
            
            
        }

        private void button_resetPayroll_Click(object sender, EventArgs e)
        {
            if (comboBox_facilityAddress.SelectedValue != null && int.TryParse(comboBox_facilityAddress.SelectedValue.ToString(), out int facilityId))
            {
                try
                {
                    using (var context = new DatabaseContext())
                    {
                        var managerData = context.Users.OfType<Model.Manager>().Where(t => t.facilityID == facilityId)
                            .Select(m => new
                            {
                                CardID = m.cardID,
                                FirstName = m.firstName,
                                LastName = m.lastName,
                                Picture = m.picture,
                                TotalSalary = m.totalSalary,
                                SalaryID = m.salaryID,
                            })
                            .ToList();

                        dataGridView_listManager.DataSource = managerData;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
