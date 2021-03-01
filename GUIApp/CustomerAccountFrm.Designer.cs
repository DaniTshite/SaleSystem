
namespace GUIApp
{
    partial class CustomerAccountFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerAccountsGridView = new System.Windows.Forms.DataGridView();
            this.SaveCustomerAccountBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.EmailAddressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhysicalAddressTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.IdNumberTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CellphoneTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerAccountsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridGroupBox
            // 
            this.GridGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGroupBox.Controls.Add(this.CustomerAccountsGridView);
            this.GridGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GridGroupBox.Name = "GridGroupBox";
            this.GridGroupBox.Size = new System.Drawing.Size(1387, 482);
            this.GridGroupBox.TabIndex = 9;
            this.GridGroupBox.TabStop = false;
            // 
            // CustomerAccountsGridView
            // 
            this.CustomerAccountsGridView.AllowUserToAddRows = false;
            this.CustomerAccountsGridView.AllowUserToDeleteRows = false;
            this.CustomerAccountsGridView.AllowUserToResizeColumns = false;
            this.CustomerAccountsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerAccountsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerAccountsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAccountsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerAccountsGridView.BackgroundColor = System.Drawing.Color.White;
            this.CustomerAccountsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerAccountsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerAccountsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerAccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerAccountsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerAccountsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerAccountsGridView.GridColor = System.Drawing.Color.White;
            this.CustomerAccountsGridView.Location = new System.Drawing.Point(17, 21);
            this.CustomerAccountsGridView.MultiSelect = false;
            this.CustomerAccountsGridView.Name = "CustomerAccountsGridView";
            this.CustomerAccountsGridView.ReadOnly = true;
            this.CustomerAccountsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerAccountsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerAccountsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.CustomerAccountsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomerAccountsGridView.RowTemplate.Height = 24;
            this.CustomerAccountsGridView.Size = new System.Drawing.Size(1352, 442);
            this.CustomerAccountsGridView.TabIndex = 22;
            // 
            // SaveCustomerAccountBtn
            // 
            this.SaveCustomerAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCustomerAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCustomerAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCustomerAccountBtn.Location = new System.Drawing.Point(1046, 157);
            this.SaveCustomerAccountBtn.Name = "SaveCustomerAccountBtn";
            this.SaveCustomerAccountBtn.Size = new System.Drawing.Size(324, 35);
            this.SaveCustomerAccountBtn.TabIndex = 8;
            this.SaveCustomerAccountBtn.Text = "Save";
            this.SaveCustomerAccountBtn.UseVisualStyleBackColor = true;
            this.SaveCustomerAccountBtn.Click += new System.EventHandler(this.SaveCustomerAccountBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GenderCmb);
            this.groupBox1.Controls.Add(this.IdNumberTxt);
            this.groupBox1.Controls.Add(this.SaveCustomerAccountBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CellphoneTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LastNameTxt);
            this.groupBox1.Controls.Add(this.LastNameLbl);
            this.groupBox1.Controls.Add(this.EmailAddressTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PhysicalAddressTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FirstNameTxt);
            this.groupBox1.Controls.Add(this.FirstNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1388, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxt.Location = new System.Drawing.Point(233, 75);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(350, 27);
            this.LastNameTxt.TabIndex = 2;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(22, 82);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(86, 20);
            this.LastNameLbl.TabIndex = 6;
            this.LastNameLbl.Text = "LastName";
            // 
            // EmailAddressTxt
            // 
            this.EmailAddressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressTxt.Location = new System.Drawing.Point(1046, 26);
            this.EmailAddressTxt.Name = "EmailAddressTxt";
            this.EmailAddressTxt.Size = new System.Drawing.Size(324, 27);
            this.EmailAddressTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Number";
            // 
            // PhysicalAddressTxt
            // 
            this.PhysicalAddressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhysicalAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalAddressTxt.Location = new System.Drawing.Point(1046, 75);
            this.PhysicalAddressTxt.Name = "PhysicalAddressTxt";
            this.PhysicalAddressTxt.Size = new System.Drawing.Size(324, 27);
            this.PhysicalAddressTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxt.Location = new System.Drawing.Point(233, 26);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(350, 27);
            this.FirstNameTxt.TabIndex = 1;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(22, 33);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(87, 20);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "FirstName";
            // 
            // IdNumberTxt
            // 
            this.IdNumberTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumberTxt.Location = new System.Drawing.Point(233, 117);
            this.IdNumberTxt.Name = "IdNumberTxt";
            this.IdNumberTxt.Size = new System.Drawing.Size(350, 27);
            this.IdNumberTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(693, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genre";
            // 
            // CellphoneTxt
            // 
            this.CellphoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellphoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellphoneTxt.Location = new System.Drawing.Point(233, 161);
            this.CellphoneTxt.Name = "CellphoneTxt";
            this.CellphoneTxt.Size = new System.Drawing.Size(350, 27);
            this.CellphoneTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Physical Address";
            // 
            // GenderCmb
            // 
            this.GenderCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GenderCmb.FormattingEnabled = true;
            this.GenderCmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "other"});
            this.GenderCmb.Location = new System.Drawing.Point(1046, 121);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(324, 28);
            this.GenderCmb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cellphone";
            // 
            // CustomerAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 722);
            this.Controls.Add(this.GridGroupBox);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1429, 769);
            this.MinimumSize = new System.Drawing.Size(1429, 769);
            this.Name = "CustomerAccountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Accounts";
            this.GridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerAccountsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GridGroupBox;
        private System.Windows.Forms.DataGridView CustomerAccountsGridView;
        private System.Windows.Forms.Button SaveCustomerAccountBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox EmailAddressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhysicalAddressTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GenderCmb;
        private System.Windows.Forms.TextBox IdNumberTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CellphoneTxt;
        private System.Windows.Forms.Label label5;
    }
}