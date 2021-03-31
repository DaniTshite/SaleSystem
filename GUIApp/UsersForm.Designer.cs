
namespace GUIApp
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateUsersBtn = new System.Windows.Forms.Button();
            this.UpdateUsersCmb = new System.Windows.Forms.ComboBox();
            this.IsActiveChkBtn = new System.Windows.Forms.CheckBox();
            this.SaveUsersBtn = new System.Windows.Forms.Button();
            this.TypeUserCmb = new System.Windows.Forms.ComboBox();
            this.SelectPictureBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DoBTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AccessCodeTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.UsersPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.UpdateUsersBtn);
            this.groupBox2.Controls.Add(this.UpdateUsersCmb);
            this.groupBox2.Controls.Add(this.SaveUsersBtn);
            this.groupBox2.Location = new System.Drawing.Point(458, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upddate";
            // 
            // UpdateUsersBtn
            // 
            this.UpdateUsersBtn.BackColor = System.Drawing.Color.Navy;
            this.UpdateUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUsersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateUsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateUsersBtn.Image")));
            this.UpdateUsersBtn.Location = new System.Drawing.Point(21, 68);
            this.UpdateUsersBtn.Name = "UpdateUsersBtn";
            this.UpdateUsersBtn.Size = new System.Drawing.Size(177, 100);
            this.UpdateUsersBtn.TabIndex = 3;
            this.UpdateUsersBtn.UseVisualStyleBackColor = false;
            this.UpdateUsersBtn.Click += new System.EventHandler(this.UpdateUsersBtn_Click);
            // 
            // UpdateUsersCmb
            // 
            this.UpdateUsersCmb.FormattingEnabled = true;
            this.UpdateUsersCmb.Location = new System.Drawing.Point(21, 29);
            this.UpdateUsersCmb.Name = "UpdateUsersCmb";
            this.UpdateUsersCmb.Size = new System.Drawing.Size(340, 33);
            this.UpdateUsersCmb.TabIndex = 0;
            this.UpdateUsersCmb.SelectedValueChanged += new System.EventHandler(this.UpdateUsersCmb_SelectedValueChanged);
            // 
            // IsActiveChkBtn
            // 
            this.IsActiveChkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IsActiveChkBtn.AutoSize = true;
            this.IsActiveChkBtn.Location = new System.Drawing.Point(492, 61);
            this.IsActiveChkBtn.Name = "IsActiveChkBtn";
            this.IsActiveChkBtn.Size = new System.Drawing.Size(108, 29);
            this.IsActiveChkBtn.TabIndex = 13;
            this.IsActiveChkBtn.Text = "ACTIVE";
            this.IsActiveChkBtn.UseVisualStyleBackColor = true;
            // 
            // SaveUsersBtn
            // 
            this.SaveUsersBtn.BackColor = System.Drawing.Color.Navy;
            this.SaveUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUsersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveUsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveUsersBtn.Image")));
            this.SaveUsersBtn.Location = new System.Drawing.Point(204, 68);
            this.SaveUsersBtn.Name = "SaveUsersBtn";
            this.SaveUsersBtn.Size = new System.Drawing.Size(163, 100);
            this.SaveUsersBtn.TabIndex = 1;
            this.SaveUsersBtn.UseVisualStyleBackColor = false;
            this.SaveUsersBtn.Click += new System.EventHandler(this.SaveUsersBtn_Click);
            // 
            // TypeUserCmb
            // 
            this.TypeUserCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeUserCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TypeUserCmb.FormattingEnabled = true;
            this.TypeUserCmb.Items.AddRange(new object[] {
            "Admin",
            "Manger",
            "Cashier"});
            this.TypeUserCmb.Location = new System.Drawing.Point(187, 57);
            this.TypeUserCmb.Name = "TypeUserCmb";
            this.TypeUserCmb.Size = new System.Drawing.Size(284, 33);
            this.TypeUserCmb.TabIndex = 4;
            // 
            // SelectPictureBtn
            // 
            this.SelectPictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPictureBtn.BackColor = System.Drawing.Color.Navy;
            this.SelectPictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPictureBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectPictureBtn.Location = new System.Drawing.Point(615, 232);
            this.SelectPictureBtn.Name = "SelectPictureBtn";
            this.SelectPictureBtn.Size = new System.Drawing.Size(204, 45);
            this.SelectPictureBtn.TabIndex = 2;
            this.SelectPictureBtn.Text = "SELECT PICTURE";
            this.SelectPictureBtn.UseVisualStyleBackColor = false;
            this.SelectPictureBtn.Click += new System.EventHandler(this.SelectPictureBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATE OF BIRTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "LASTNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "ACCESS CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "TYPE USER";
            // 
            // DoBTimePicker
            // 
            this.DoBTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DoBTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBTimePicker.Location = new System.Drawing.Point(187, 241);
            this.DoBTimePicker.Name = "DoBTimePicker";
            this.DoBTimePicker.Size = new System.Drawing.Size(413, 30);
            this.DoBTimePicker.TabIndex = 6;
            // 
            // AccessCodeTxt
            // 
            this.AccessCodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccessCodeTxt.Location = new System.Drawing.Point(187, 101);
            this.AccessCodeTxt.Name = "AccessCodeTxt";
            this.AccessCodeTxt.ReadOnly = true;
            this.AccessCodeTxt.Size = new System.Drawing.Size(413, 30);
            this.AccessCodeTxt.TabIndex = 4;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastNameTxt.Location = new System.Drawing.Point(187, 194);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(413, 30);
            this.LastNameTxt.TabIndex = 3;
            // 
            // NameTxt
            // 
            this.NameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTxt.Location = new System.Drawing.Point(187, 147);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(413, 30);
            this.NameTxt.TabIndex = 2;
            // 
            // UsersPictureBox
            // 
            this.UsersPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UsersPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersPictureBox.Location = new System.Drawing.Point(615, 57);
            this.UsersPictureBox.Name = "UsersPictureBox";
            this.UsersPictureBox.Size = new System.Drawing.Size(204, 169);
            this.UsersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsersPictureBox.TabIndex = 0;
            this.UsersPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IsActiveChkBtn);
            this.panel1.Controls.Add(this.UsersPictureBox);
            this.panel1.Controls.Add(this.TypeUserCmb);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.SelectPictureBtn);
            this.panel1.Controls.Add(this.LastNameTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AccessCodeTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DoBTimePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(337, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 592);
            this.panel1.TabIndex = 1;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1512, 773);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(818, 545);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USERS";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SelectPictureBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DoBTimePicker;
        private System.Windows.Forms.TextBox AccessCodeTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.PictureBox UsersPictureBox;
        private System.Windows.Forms.Button SaveUsersBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UpdateUsersBtn;
        private System.Windows.Forms.ComboBox UpdateUsersCmb;
        private System.Windows.Forms.ComboBox TypeUserCmb;
        private System.Windows.Forms.CheckBox IsActiveChkBtn;
        private System.Windows.Forms.Panel panel1;
    }
}