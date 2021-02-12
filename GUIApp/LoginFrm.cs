using DataLibrary.Models;
using LogicLibrary.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                var userLogin = LoginProcessor.LoadUsers(UsernameTxt.Text, PasswordTxt.Text);

                if (userLogin.Count > 0)
                {
                    Users u = userLogin[0];
                    MessageBox.Show("Welcome " + u.Name, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Username does not exist in the Database", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UsernameTxt.Clear();
                    UsernameTxt.Focus();
                    PasswordTxt.Clear();
                }
            }
        }

        private bool IsValid()
        {
            if (UsernameTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username Rquired", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (PasswordTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password Rquired", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
