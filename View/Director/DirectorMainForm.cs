using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.Tool;
using FinalWindow.View.Customer;
using FinalWindow.View.Director;
using FinalWindow.View.Director.FacilityCRUD;
using FinalWindow.View.Manager.ShiftCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinalWindow
{
    public partial class DirectorMainForm : Form
    {
        private static int dirID;

        public static int DirID { get => dirID; set => dirID = value; }

        public DirectorMainForm()
        {
            InitializeComponent();
        }

        

       

        private void button_resetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var managerData = context.Users.OfType<Manager>().Where(t=>t.active == true)
                       // .Where(u => u.cardID)
                        .Select(u => new
                        {
                            CardID = u.cardID,
                            FisrtName = u.firstName,
                            LastName = u.lastName,
                            Gender = u.gender,
                            Phone = u.phone,
                            Birthday = u.birthday

                            

                        })
                        .ToList();



                    dataGridView_listManager.DataSource = managerData;
                }
            } catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

       

        void loadProfile()
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                var director = context.Users.OfType<Director>().Where(t => t.ID == dirID).FirstOrDefault();
                if (director.picture != null)
                {
                    byte[] imageData = (byte[])director.picture;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox_directorImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                label_username.Text = director.username;
                label_firstName.Text = director.firstName;
                label_lastName.Text = director.lastName;
                if (director.gender == null)
                {
                    return;
                }
                else
                {
                    label_gender.Text = director.gender;
                }

                if (director.birthday == null)
                {
                    return;
                }
                else
                {
                    label_birthDate.Text = director.birthday.Value.Date.ToString("dd/MM/yyyy");
                }
                label_email.Text = director.email;
                label_phone.Text = director.phone;
                label_address.Text = director.address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DirectorMainForm_Load(object sender, EventArgs e)
        {
            
            loadProfile();
            loadSalary();
            
            /*// Get a reference to the initially selected tab page
            //TabPage selectedTabPage = tabPage_managerManagement;

            //// Check if the initially selected tab page contains a DataGridView
            //foreach (System.Windows.Forms.Control control in selectedTabPage.Controls)
            //{
            //    if (control is DataGridView dataGridView)
            //    {
            //        // Load the data source for the DataGridView

            //        using (var context = new DatabaseContext())
            //        {
            //            var managerData = context.Users
            //                .Where(u => u is Manager)
            //                .Select(u => new
            //                {
            //                    FisrtName = u.firstName,
            //                    LastName = u.lastName,
            //                    Gender = u.gender,
            //                    Phone = u.phone,
            //                    Birthday = u.birthday

            //                })
            //                .ToList();



            //            dataGridView_listManager.DataSource = managerData;
            //            break;
            //        }
            //    }
            //}


            //if(selectedTabPage == tabPage_facilityManagement)
            //{
            //    foreach (System.Windows.Forms.Control control in selectedTabPage.Controls)
            //    {
            //        if (control is DataGridView dataGridView)
            //        {
            //            // Load the data source for the DataGridView

            //            using (var context = new DatabaseContext())
            //            {
            //                var facilityData = context.Facilities
            //                    .Select(f => new
            //                    {
            //                        Address = f.address,
            //                        QuantityFix = f.quatityFix,
            //                        QuantityKeep = f.quantityKeep

            //                    })
            //                    .ToList();



            //                dataGridView_listFacility.DataSource = facilityData;
            //            }
            //        }
            //    }
            //}*/
        }

        private void button_resetFacility_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var facilityData = context.Facilities
                        .Select(f => new
                        {
                            Address = f.address,
                            QuantityFix = f.quatityFix,
                            QuantityKeep = f.quantityKeep

                        })
                        .ToList();



                    dataGridView_listFacility.DataSource = facilityData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_addFacility_Click(object sender, EventArgs e)
        {
            AddFacilityForm addFacilityForm = new AddFacilityForm();
            addFacilityForm.Show();
        }

        private void button_addManager_Click(object sender, EventArgs e)
        {
            AddManagerForm addManagerForm = new AddManagerForm();
            addManagerForm.Show();
        }

        private void button_editManager_Click(object sender, EventArgs e)
        {
            UpdateManagerForm updateManagerForm = new UpdateManagerForm();
            updateManagerForm.Show();
        }

        private void button_updateFacility_Click(object sender, EventArgs e)
        {
            UpdateFacilityForm updateFacilityForm = new UpdateFacilityForm();
            updateFacilityForm.Show();
        }

        

        private void button_resetListShift_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var shiftData = context.Shifts
                        // .Where(u => u.cardID)
                        .Select(u => new
                        {
                            StartTime = u.startTime,
                            EndTime = u.endTime,
                            QuantityFix = u.quantityFix,
                            QuantityKeep = u.quantityKeep


                        })
                        .ToList();



                    dataGridView_listShift.DataSource = shiftData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_addShift_Click(object sender, EventArgs e)
        {
            AddShiftForm addShiftForm = new AddShiftForm();
            addShiftForm.Show();
        }

        
        private void dataGridView_listShift_Click(object sender, EventArgs e)
        {
            UpdateShiftForm updateShiftForm = new UpdateShiftForm();
            object cellValue = dataGridView_listShift.CurrentRow.Cells[0].Value;
            if (cellValue is TimeSpan)
            {
                TimeSpan timeSpanValue = (TimeSpan)cellValue;
                DateTime currentDate = DateTime.Now.Date;
                updateShiftForm.dateTimePicker_From.Value = currentDate.Add(timeSpanValue);
            }
            else if (cellValue is DateTime)
            {
                updateShiftForm.dateTimePicker_From.Value = (DateTime)cellValue;
            }

            cellValue = dataGridView_listShift.CurrentRow.Cells[1].Value;
            if (cellValue is TimeSpan)
            {
                TimeSpan timeSpanValue = (TimeSpan)cellValue;
                DateTime currentDate = DateTime.Now.Date;
                updateShiftForm.dateTimePicker_To.Value = currentDate.Add(timeSpanValue);
            }
            else if (cellValue is DateTime)
            {
                updateShiftForm.dateTimePicker_To.Value = (DateTime)cellValue;
            }
            updateShiftForm.Show();
        }

        private void button_editInformation_Click(object sender, EventArgs e)
        {
            DirectorEditInformationForm editInformationForm = new DirectorEditInformationForm();
            editInformationForm.Show();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            loadProfile();
        }

        private void button_addBaseSalary_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext db = new DatabaseContext();
                if (string.IsNullOrEmpty(textBox_baseSalary.Text) || comboBox_role.SelectedItem == null)
                {
                    MessageBox.Show("Please enter all information");
                    return;
                }


                var salary = new Model.Salary
                {
                    BasicSalary = float.Parse(textBox_baseSalary.Text),
                    role = comboBox_role.SelectedItem.ToString()

                };
                var checkSalary = db.Salaries.Where(t => t.role == comboBox_role.SelectedItem.ToString()).Count();
                if(checkSalary >0)
                {
                    MessageBox.Show("You have already set basic salary for this role.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    db.Salaries.Add(salary);
                    db.SaveChanges();
                    loadSalary();
                    MessageBox.Show("Add successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_resetSalary_Click(object sender, EventArgs e)
        {
            loadSalary();
        }

        void loadSalary()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var baseSalaryData = context.Salaries
                        // .Where(u => u.cardID)
                        .Select(u => new
                        {
                            BasicSalaries = u.BasicSalary.ToString(),
                            Role = u.role
                        })
                        .ToList();

                    dataGridView_baseSalary.DataSource = baseSalaryData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext context = new DatabaseContext();

                try
                {
                    string role = comboBox_role.SelectedItem.ToString();
                    Model.Salary salary = context.Salaries.Where(u => u.role == role).FirstOrDefault();
                    var checkcardIDman = context.Salaries.Where(t => t.role == comboBox_role.SelectedItem.ToString()).Count();
                    if (role == null)
                    {
                        MessageBox.Show("Don't exist this role");
                    }
                    //else if (checkcardIDman > 0)
                    //{
                    //    MessageBox.Show("You have already set basic salary for this role.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}
                    else if(checkcardIDman == 0)
                    {
                        MessageBox.Show("You have not set basic salary for this role.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            salary.BasicSalary = float.Parse(textBox_baseSalary.Text);
                            //salary.role = comboBox_role.SelectedItem.ToString();

                            context.SaveChanges();
                            loadSalary();
                            MessageBox.Show("Update successfully !!!");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot update !!");
                }
            }
            catch
            {
                MessageBox.Show("Update fail");
            }
        }

        private void dataGridView_baseSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView_baseSalary.CurrentRow != null)
                {
                    textBox_baseSalary.Text = dataGridView_baseSalary.CurrentRow.Cells["BasicSalaries"].Value.ToString();
                    comboBox_role.SelectedItem = dataGridView_baseSalary.CurrentRow.Cells["Role"].Value;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_payRoll_Click(object sender, EventArgs e)
        {
            PayRollManagerForm form = new PayRollManagerForm();
            form.Show();
        }
    }
}
