using DataLibrary.Models;
using LogicLibrary;
using LogicLibrary.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class LoginFrm : Form
    {
        IUsersProcessor _usersProcessor;
        public LoginFrm()
        {
            InitializeComponent();
            _usersProcessor = ContainerConfig.CreateUsersProcessor();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wMsg,int wParam,int lParam);
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (_usersProcessor.DoesUserExist(UsernameTxt.Text.Trim(), AccessCodeTxt.Text.Trim()))
                {
                    MessageBox.Show("Welcome " + UsernameTxt.Text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainFrm mf = new MainFrm();
                    mf._loggedInUser = UsernameTxt.Text;
                    mf.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The Username or Accesscode are incorrect !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UsernameTxt.Clear();
                    UsernameTxt.Focus();
                    AccessCodeTxt.Clear();
                }
            }
        }

        private bool IsValid()
        {
            if (UsernameTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username Rquired", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameTxt.Focus();
                return false;
            }

            if (AccessCodeTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password Rquired", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AccessCodeTxt.Focus();
                return false;
            }
            return true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}
