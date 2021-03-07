using DataLibrary.Data;
using DataLibrary.Models;
using LogicLibrary;
using LogicLibrary.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class UsersForm : Form
    {
        IUsersProcessor _usersProcessor;
        List<Users> users;
        string imgLoc;
        IUsers SelectedUser ;
        public UsersForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            UpdateUsersCmb.SelectedValueChanged +=UpdateUsersCmb_SelectedValueChanged;
            _usersProcessor = ContainerConfig.CreateUsersProcessor();
            users = new List<Users>();
            SelectedUser = ContainerConfig.CreateUser();
            users = _usersProcessor.GetUsers();
            UpdateUsersCmb.DataSource = users;
            UpdateUsersCmb.ValueMember = "UserId";
            UpdateUsersCmb.DisplayMember = "FullName";
            UpdateUsersCmb.SelectedValueChanged -= UpdateUsersCmb_SelectedValueChanged;
        }

        private void SelectPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                fd.Title = "Select Employee picture";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = fd.FileName.ToString();
                    UsersPictureBox.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Something went wrong !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUsersBtn_Click(object sender, EventArgs e)
        {
            
            if (Isvalidated())
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                IUsers user = ContainerConfig.CreateUser();
                user.TypeUser = TypeUserCmb.Text;
                user.AccessCode = _usersProcessor.GenerateAccessCode();
                user.Name = NameTxt.Text;
                user.LastName = LastNameTxt.Text;
                user.DoB = DoBTimePicker.Value;
                user.IsActive = 1;
                user.Photo = img;
                
                MessageBox.Show(_usersProcessor.SaveUser(user), "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool Isvalidated()
        {
            bool isNullOrEmpty;
            if (TypeUserCmb.Text == "")

            if (TypeUserCmb.SelectedIndex == -1)

            {
                MessageBox.Show("The Select a User Type Please !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TypeUserCmb.Focus();
                return false;
            }
            if (NameTxt.Text == string.Empty)
            {
                MessageBox.Show("The Name is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTxt.Focus();
                return false;
            }
            if (LastNameTxt.Text == string.Empty)
            {
                MessageBox.Show("The LastName is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTxt.Focus();
                return false;
            }
            if (DoBTimePicker.Text == "")

            if (DoBTimePicker.Text=="")

            {
                MessageBox.Show("The Date of Birth Please !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DoBTimePicker.Focus();
                return false;
            }

            if (isNullOrEmpty = UsersPictureBox == null || UsersPictureBox.Image == null)
            {
                MessageBox.Show("The photo is Required !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectPictureBtn.Focus();
                return false;
            }

            return true;
        }

        private void UpdateUsersCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedUser = (Users)UpdateUsersCmb.SelectedItem;
            TypeUserCmb.Text = SelectedUser.TypeUser;
            AccessCodeTxt.Text = SelectedUser.AccessCode;
            NameTxt.Text = SelectedUser.Name;
            LastNameTxt.Text = SelectedUser.LastName;
            DoBTimePicker.Text = SelectedUser.DoB.ToShortDateString();
            byte[] img = (byte[])(SelectedUser.Photo);
            if (img == null) UsersPictureBox.Image = null;
            else
            {
                MemoryStream ms = new MemoryStream(img);
                UsersPictureBox.Image = Image.FromStream(ms);
            }
            if (SelectedUser.IsActive == 1)
            {
                IsActiveChkBtn.Checked = true;
            }
            else
            {
                IsActiveChkBtn.Checked = false;
            }
        }

        private void UpdateUsersBtn_Click(object sender, EventArgs e)
        {
            if (Isvalidated())
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                IUsers user = ContainerConfig.CreateUser();
                user.UserId = SelectedUser.UserId;
                user.TypeUser = TypeUserCmb.Text;
                user.AccessCode = AccessCodeTxt.Text;
                user.Name = NameTxt.Text;
                user.LastName = LastNameTxt.Text;
                user.DoB = DoBTimePicker.Value;
                user.IsActive = IsActiveChkBtn.Checked == true ? 1 : 0;
                user.Photo = img;
                
                MessageBox.Show(_usersProcessor.UpdateUser(user), "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ResetControls()
        {
            TypeUserCmb.Text = "";
            TypeUserCmb.Focus();
            IsActiveChkBtn.Checked = false;
            AccessCodeTxt.Clear();
            NameTxt.Clear();
            LastNameTxt.Clear();
            UpdateUsersCmb.Text = "";
            UsersPictureBox.Image = null;
        }
    }
}
