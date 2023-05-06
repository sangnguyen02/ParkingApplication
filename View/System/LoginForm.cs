using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(textBox_Username.Text == "")
            {
                textBox_Username.PlaceholderText = "Type your Username";
                textBox_Username.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if(textBox_Password.Text == "")
            {
                textBox_Password.PlaceholderText = "Type your Password";
                textBox_Password.PlaceholderForeColor = System.Drawing.Color.Black;
            }
        }

        private void label_createAccount_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            FindAccountForm findAccountForm = new FindAccountForm();
            findAccountForm.Show();
        }
    }
}
