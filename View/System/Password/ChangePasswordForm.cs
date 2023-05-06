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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.PlaceholderText = "Type your new Password";
                textBox_Password.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if (textBox_confirmPassword.Text == "")
            {
                textBox_confirmPassword.PlaceholderText = "Confirm Password";
                textBox_confirmPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
