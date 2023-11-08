using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Director.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Manager = FinalWindow.Model.Manager;
namespace FinalWindow.View.Director
{
    public partial class UpdateManagerForm : Form
    {
        string temp = null;
        public UpdateManagerForm()
        {
            InitializeComponent();
        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        private void button_selectManager_Click(object sender, EventArgs e)
        {
            ListManagerForm listManagerForm = new ListManagerForm();
            listManagerForm.Show();
            this.Hide();
        }

        private void UpdateManagerForm_Load(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            comboBox_facilityID.DataSource = context.Facilities.ToList();
            comboBox_facilityID.DisplayMember = "address";
            comboBox_facilityID.ValueMember = "ID";
            comboBox_facilityID.SelectedItem = 1;



            comboBox_salaryrRole.DataSource = context.Salaries.ToList();
            comboBox_salaryrRole.DisplayMember = "role";
            comboBox_salaryrRole.ValueMember = "salaryID";
            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
               
                try
                {

                    Model.Manager manager = context.Users.OfType<Model.Manager>().Where(u => u.cardID == textBox_cardID.Text).FirstOrDefault();

                    var checkcardIDman = context.Users.OfType<Model.Manager>().Where(t => t.cardID == textBox_cardID.Text).Count();
                    var checkcardIDfix = context.Users.OfType<Model.FixWorker>().Where(t => t.cardID == textBox_cardID.Text).Count();
                    var checkcardIDkeep = context.Users.OfType<Model.KeepWorker>().Where(t => t.cardID == textBox_cardID.Text).Count();
                    var checkusername = context.Users.Where(t => t.username == textBox_username.Text).Count();
                    var checkphone = context.Users.Where(t => t.phone == textBox_phone.Text).Count();
                    var checkemail = context.Users.Where(t => t.email == textBox_email.Text).Count();

                    if (checkusername > 0)
                    {
                        MessageBox.Show("Username has already existed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (checkphone > 0)
                    {
                        MessageBox.Show("Phone has already existed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (checkemail > 0)
                    {
                        MessageBox.Show("Email has already existed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (checkcardIDman > 0)
                    {
                        MessageBox.Show("Card ID has already existed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (checkcardIDfix > 0)
                    {
                        MessageBox.Show("Card ID has already existed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (checkcardIDkeep > 0)
                    {
                        MessageBox.Show("Card ID has already existed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (manager == null)
                    {
                        textBox_cardID.Text = temp;


                        MessageBox.Show("Don't exist this manager");

                    }
                    else
                    {
                        manager.cardID = textBox_cardID.Text;
                        manager.username = textBox_username.Text;
                        manager.password = textBox_password.Text;
                        manager.picture = UpdateManagerForm.converterDemo(pictureBox_image.Image);
                        manager.facilityID = (int?)comboBox_facilityID.SelectedValue;
                        manager.firstName = textBox_firstName.Text;
                        manager.lastName = textBox_lastName.Text;
                        manager.gender = comboBox_gender.SelectedItem.ToString();
                        manager.birthday = birthday_picker.Value;
                        manager.phone = textBox_phone.Text;
                        manager.email = textBox_email.Text;
                        manager.address = textBox_address.Text;
                        manager.coefficients = float.Parse(textBox_CoE.Text);
                        manager.salaryID = (int?)comboBox_salaryrRole.SelectedValue;
                        if(checkBox_status.Checked)
                        {
                            manager.active = true;
                        }
                        else
                        {
                            manager.active = false;
                        }
                       
                        

                        context.SaveChanges();
                        MessageBox.Show("Update successfully !!!");
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

       
    }
}
