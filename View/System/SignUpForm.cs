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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                textBox_Username.PlaceholderText = "Type your Username";
                textBox_Username.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if (textBox_Password.Text == "")
            {
                textBox_Password.PlaceholderText = "Type your Password";
                textBox_Password.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if(textBox_firstName.Text == "")
            {
                textBox_firstName.PlaceholderText = "Type your First Name";
                textBox_firstName.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if (textBox_lastName.Text == "")
            {
                textBox_lastName.PlaceholderText = "Type your Last Name";
                textBox_lastName.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if (textBox_email.Text == "")
            {
                textBox_email.PlaceholderText = "Type your Email";
                textBox_email.PlaceholderForeColor = System.Drawing.Color.Black;
            }

        }
    }
}
