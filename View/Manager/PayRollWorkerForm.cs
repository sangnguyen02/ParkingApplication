using FinalWindow.Database;
using FinalWindow.View.Director;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.Manager
{
    public partial class PayRollWorkerForm : Form
    {
        public PayRollWorkerForm()
        {
            InitializeComponent();
        }

        private void PayRollWorkerForm_Load(object sender, EventArgs e)
        {
            comboBox_typeWorker.SelectedIndex = 0;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            if ((DataGridViewImageColumn)dataGridView_listWorker.Columns[3] != null)
            {
                picCol = (DataGridViewImageColumn)dataGridView_listWorker.Columns[3];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

        }


        void loadKeepDataGridView()
        {
            try
            {
                DatabaseContext context1 = new DatabaseContext();
                var manager = context1.Users.OfType<Model.Manager>().Where(t => t.ID == ManagerMainForm.ManID).FirstOrDefault();
                using (var context = new DatabaseContext())
                {
                    var keeperData = context.Users.OfType<Model.KeepWorker>().Where(t => t.facilityID == manager.facilityID)
                        .Select(u => new
                        {
                            CardID = u.cardID,
                            FirstName = u.firstName,
                            LastName = u.lastName,
                            Picture = u.picture,
                            TotalSalary = u.totalSalary,
                            SalaryID = u.salaryID

                        })
                        .ToList();



                    dataGridView_listWorker.DataSource = keeperData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void loadFixDataGridView()
        {
            try
            {
                DatabaseContext context1 = new DatabaseContext();
                var manager = context1.Users.OfType<Model.Manager>().Where(t => t.ID == ManagerMainForm.ManID).FirstOrDefault();
                using (var context = new DatabaseContext())
                {
                    var fixerData = context.Users.OfType<Model.FixWorker>().Where(t => t.facilityID == manager.facilityID)
                        // .Where(u => u.cardID)
                        .Select(u => new
                        {
                            CardID = u.cardID,
                            FirstName = u.firstName,
                            LastName = u.lastName,
                            Picture = u.picture,
                            TotalSalary = u.totalSalary,
                            SalaryID = u.salaryID

                        })
                        .ToList();



                    dataGridView_listWorker.DataSource = fixerData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboBox_typeWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_typeWorker.SelectedIndex == 0)
            {
                loadFixDataGridView();
            }
            else if (comboBox_typeWorker.SelectedIndex == 1)
            {
                loadKeepDataGridView();
            }
        }

        private void dataGridView_listWorker_Click(object sender, EventArgs e)
        {
            CalculateWorkerSalaryForm calculateSalaryForm = new CalculateWorkerSalaryForm();


            if (dataGridView_listWorker.CurrentRow.Cells["SalaryID"].Value != null)
            {
                int value = (int)dataGridView_listWorker.CurrentRow.Cells["SalaryID"].Value;
                string firstName = dataGridView_listWorker.CurrentRow.Cells["FirstName"].Value.ToString();
                string cardID = dataGridView_listWorker.CurrentRow.Cells["CardID"].Value.ToString();
                using (DatabaseContext context = new DatabaseContext())
                {
                    var salary = context.Salaries.Where(t => t.salaryID == value).FirstOrDefault();
                    if (comboBox_typeWorker.SelectedIndex == 0)
                    {
                        var fixer = context.Users.OfType<Model.FixWorker>().Where(t => t.salaryID == value).FirstOrDefault();

                        if (salary != null && fixer != null)
                        {
                            float? totalSalary = salary.BasicSalary * fixer.coefficients;
                            fixer.totalSalary = totalSalary;

                            context.SaveChanges();


                            calculateSalaryForm.label_totalSalary.Text = totalSalary.ToString();
                            calculateSalaryForm.label_workerCardID.Text = cardID;
                            calculateSalaryForm.label_FirstName.Text = firstName;

                        }
                    }
                    else if (comboBox_typeWorker.SelectedIndex == 1)
                    {
                        var keeper = context.Users.OfType<Model.KeepWorker>().Where(t => t.salaryID == value).FirstOrDefault();

                        if (salary != null && keeper != null)
                        {
                            float? totalSalary = salary.BasicSalary * keeper.coefficients;
                            keeper.totalSalary = totalSalary;

                            context.SaveChanges();


                            calculateSalaryForm.label_totalSalary.Text = totalSalary.ToString();
                            calculateSalaryForm.label_workerCardID.Text = cardID;
                            calculateSalaryForm.label_FirstName.Text = firstName;

                        }
                    }

                }
                calculateSalaryForm.Show();
            }
        }
    }
}
