
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsActiveChkBtn = new System.Windows.Forms.CheckBox();
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
            this.SaveUsersBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateUsersBtn = new System.Windows.Forms.Button();
            this.UpdateUsersCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.IsActiveChkBtn);
            this.groupBox1.Controls.Add(this.SaveUsersBtn);
            this.groupBox1.Controls.Add(this.TypeUserCmb);
            this.groupBox1.Controls.Add(this.SelectPictureBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DoBTimePicker);
            this.groupBox1.Controls.Add(this.AccessCodeTxt);
            this.groupBox1.Controls.Add(this.LastNameTxt);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.UsersPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(365, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // IsActiveChkBtn
            // 
            this.IsActiveChkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IsActiveChkBtn.AutoSize = true;
            this.IsActiveChkBtn.Location = new System.Drawing.Point(418, 46);
            this.IsActiveChkBtn.Name = "IsActiveChkBtn";
            this.IsActiveChkBtn.Size = new System.Drawing.Size(78, 21);
            this.IsActiveChkBtn.TabIndex = 13;
            this.IsActiveChkBtn.Text = "ACTIVE";
            this.IsActiveChkBtn.UseVisualStyleBackColor = true;
            // 
            // TypeUserCmb
            // 
            this.TypeUserCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeUserCmb.FormattingEnabled = true;
            this.TypeUserCmb.Items.AddRange(new object[] {
            "Admin",
            "Manger",
            "Cashier"});
            this.TypeUserCmb.Location = new System.Drawing.Point(211, 46);
            this.TypeUserCmb.Name = "TypeUserCmb";
            this.TypeUserCmb.Size = new System.Drawing.Size(188, 24);
            this.TypeUserCmb.TabIndex = 4;
            // 
            // SelectPictureBtn
            // 
            this.SelectPictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPictureBtn.BackColor = System.Drawing.Color.Navy;
            this.SelectPictureBtn.FlatAppearance.BorderSize = 0;
            this.SelectPictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPictureBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectPictureBtn.Location = new System.Drawing.Point(582, 229);
            this.SelectPictureBtn.Name = "SelectPictureBtn";
            this.SelectPictureBtn.Size = new System.Drawing.Size(182, 37);
            this.SelectPictureBtn.TabIndex = 2;
            this.SelectPictureBtn.Text = "SELECT PICTURE";
            this.SelectPictureBtn.UseVisualStyleBackColor = false;
            this.SelectPictureBtn.Click += new System.EventHandler(this.SelectPictureBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATE OF BIRTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "LASTNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ACCESS CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "TYPE USER";
            // 
            // DoBTimePicker
            // 
            this.DoBTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBTimePicker.Location = new System.Drawing.Point(211, 230);
            this.DoBTimePicker.Name = "DoBTimePicker";
            this.DoBTimePicker.Size = new System.Drawing.Size(285, 22);
            this.DoBTimePicker.TabIndex = 6;
            // 
            // AccessCodeTxt
            // 
            this.AccessCodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessCodeTxt.Location = new System.Drawing.Point(211, 90);
            this.AccessCodeTxt.Name = "AccessCodeTxt";
            this.AccessCodeTxt.ReadOnly = true;
            this.AccessCodeTxt.Size = new System.Drawing.Size(285, 22);
            this.AccessCodeTxt.TabIndex = 4;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTxt.Location = new System.Drawing.Point(211, 183);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(285, 22);
            this.LastNameTxt.TabIndex = 3;
            // 
            // NameTxt
            // 
            this.NameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxt.Location = new System.Drawing.Point(211, 136);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(285, 22);
            this.NameTxt.TabIndex = 2;
            // 
            // UsersPictureBox
            // 
            this.UsersPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UsersPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersPictureBox.Location = new System.Drawing.Point(582, 45);
            this.UsersPictureBox.Name = "UsersPictureBox";
            this.UsersPictureBox.Size = new System.Drawing.Size(182, 169);
            this.UsersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsersPictureBox.TabIndex = 0;
            this.UsersPictureBox.TabStop = false;
            // 
            // SaveUsersBtn
            // 
            this.SaveUsersBtn.BackColor = System.Drawing.Color.Navy;
            this.SaveUsersBtn.FlatAppearance.BorderSize = 0;
            this.SaveUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUsersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveUsersBtn.Location = new System.Drawing.Point(22, 508);
            this.SaveUsersBtn.Name = "SaveUsersBtn";
            this.SaveUsersBtn.Size = new System.Drawing.Size(209, 46);
            this.SaveUsersBtn.TabIndex = 1;
            this.SaveUsersBtn.Text = "SAVE";
            this.SaveUsersBtn.UseVisualStyleBackColor = false;
            this.SaveUsersBtn.Click += new System.EventHandler(this.SaveUsersBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.UpdateUsersBtn);
            this.groupBox2.Controls.Add(this.UpdateUsersCmb);
            this.groupBox2.Location = new System.Drawing.Point(344, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upddate";
            // 
            // UpdateUsersBtn
            // 
            this.UpdateUsersBtn.BackColor = System.Drawing.Color.Navy;
            this.UpdateUsersBtn.FlatAppearance.BorderSize = 0;
            this.UpdateUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUsersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateUsersBtn.Location = new System.Drawing.Point(21, 84);
            this.UpdateUsersBtn.Name = "UpdateUsersBtn";
            this.UpdateUsersBtn.Size = new System.Drawing.Size(381, 30);
            this.UpdateUsersBtn.TabIndex = 3;
            this.UpdateUsersBtn.Text = "UPDATE";
            this.UpdateUsersBtn.UseVisualStyleBackColor = false;
            this.UpdateUsersBtn.Click += new System.EventHandler(this.UpdateUsersBtn_Click);
            // 
            // UpdateUsersCmb
            // 
            this.UpdateUsersCmb.FormattingEnabled = true;
            this.UpdateUsersCmb.Location = new System.Drawing.Point(21, 38);
            this.UpdateUsersCmb.Name = "UpdateUsersCmb";
            this.UpdateUsersCmb.Size = new System.Drawing.Size(381, 24);
            this.UpdateUsersCmb.TabIndex = 0;
            this.UpdateUsersCmb.SelectedValueChanged += new System.EventHandler(this.UpdateUsersCmb_SelectedValueChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 773);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(818, 545);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USERS";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}