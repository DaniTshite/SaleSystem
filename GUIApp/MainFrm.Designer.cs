﻿
namespace GUIApp
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LoggedInUserLbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.SuppliersBtn = new System.Windows.Forms.Button();
            this.QuotationsBtn = new System.Windows.Forms.Button();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.DeliveryBtn = new System.Windows.Forms.Button();
            this.CustomersBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.CloseChildFormBtn = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.LoggedInUserLbl);
            this.panelMenu.Controls.Add(this.SettingsBtn);
            this.panelMenu.Controls.Add(this.SuppliersBtn);
            this.panelMenu.Controls.Add(this.QuotationsBtn);
            this.panelMenu.Controls.Add(this.ReportsBtn);
            this.panelMenu.Controls.Add(this.DeliveryBtn);
            this.panelMenu.Controls.Add(this.CustomersBtn);
            this.panelMenu.Controls.Add(this.SalesBtn);
            this.panelMenu.Controls.Add(this.OrdersBtn);
            this.panelMenu.Controls.Add(this.UsersBtn);
            this.panelMenu.Controls.Add(this.ItemsBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(291, 789);
            this.panelMenu.TabIndex = 0;
            // 
            // LoggedInUserLbl
            // 
            this.LoggedInUserLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoggedInUserLbl.AutoSize = true;
            this.LoggedInUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LoggedInUserLbl.ForeColor = System.Drawing.Color.White;
            this.LoggedInUserLbl.Location = new System.Drawing.Point(3, 752);
            this.LoggedInUserLbl.Name = "LoggedInUserLbl";
            this.LoggedInUserLbl.Size = new System.Drawing.Size(121, 25);
            this.LoggedInUserLbl.TabIndex = 1;
            this.LoggedInUserLbl.Text = "Logged In :";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.Location = new System.Drawing.Point(-1, 676);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(291, 65);
            this.SettingsBtn.TabIndex = 0;
            this.SettingsBtn.Text = "SETTINGS";
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // SuppliersBtn
            // 
            this.SuppliersBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.SuppliersBtn.FlatAppearance.BorderSize = 0;
            this.SuppliersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppliersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SuppliersBtn.ForeColor = System.Drawing.Color.White;
            this.SuppliersBtn.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersBtn.Image")));
            this.SuppliersBtn.Location = new System.Drawing.Point(-1, 601);
            this.SuppliersBtn.Name = "SuppliersBtn";
            this.SuppliersBtn.Size = new System.Drawing.Size(291, 75);
            this.SuppliersBtn.TabIndex = 0;
            this.SuppliersBtn.Text = "SUPPLIERS";
            this.SuppliersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SuppliersBtn.UseVisualStyleBackColor = false;
            this.SuppliersBtn.Click += new System.EventHandler(this.SuppliersBtn_Click);
            // 
            // QuotationsBtn
            // 
            this.QuotationsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.QuotationsBtn.FlatAppearance.BorderSize = 0;
            this.QuotationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.QuotationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuotationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.QuotationsBtn.ForeColor = System.Drawing.Color.White;
            this.QuotationsBtn.Image = ((System.Drawing.Image)(resources.GetObject("QuotationsBtn.Image")));
            this.QuotationsBtn.Location = new System.Drawing.Point(-1, 526);
            this.QuotationsBtn.Name = "QuotationsBtn";
            this.QuotationsBtn.Size = new System.Drawing.Size(291, 75);
            this.QuotationsBtn.TabIndex = 0;
            this.QuotationsBtn.Text = "QUOTATIONS";
            this.QuotationsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuotationsBtn.UseVisualStyleBackColor = false;
            this.QuotationsBtn.Click += new System.EventHandler(this.QuotationsBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ReportsBtn.FlatAppearance.BorderSize = 0;
            this.ReportsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ReportsBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportsBtn.Image")));
            this.ReportsBtn.Location = new System.Drawing.Point(-1, 451);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(291, 75);
            this.ReportsBtn.TabIndex = 0;
            this.ReportsBtn.Text = "REPORTS";
            this.ReportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportsBtn.UseVisualStyleBackColor = false;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // DeliveryBtn
            // 
            this.DeliveryBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.DeliveryBtn.FlatAppearance.BorderSize = 0;
            this.DeliveryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DeliveryBtn.ForeColor = System.Drawing.Color.White;
            this.DeliveryBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeliveryBtn.Image")));
            this.DeliveryBtn.Location = new System.Drawing.Point(-1, 376);
            this.DeliveryBtn.Name = "DeliveryBtn";
            this.DeliveryBtn.Size = new System.Drawing.Size(291, 75);
            this.DeliveryBtn.TabIndex = 0;
            this.DeliveryBtn.Text = "DELIVERIES";
            this.DeliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeliveryBtn.UseVisualStyleBackColor = false;
            this.DeliveryBtn.Click += new System.EventHandler(this.DeliveryBtn_Click);
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CustomersBtn.FlatAppearance.BorderSize = 0;
            this.CustomersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CustomersBtn.ForeColor = System.Drawing.Color.White;
            this.CustomersBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomersBtn.Image")));
            this.CustomersBtn.Location = new System.Drawing.Point(-1, 301);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(291, 75);
            this.CustomersBtn.TabIndex = 0;
            this.CustomersBtn.Text = "CUSTOMERS";
            this.CustomersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomersBtn.UseVisualStyleBackColor = false;
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalesBtn.FlatAppearance.BorderSize = 0;
            this.SalesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SalesBtn.ForeColor = System.Drawing.Color.White;
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.Location = new System.Drawing.Point(-1, 226);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(291, 75);
            this.SalesBtn.TabIndex = 0;
            this.SalesBtn.Text = "SALE ORDERS";
            this.SalesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesBtn.UseVisualStyleBackColor = false;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.OrdersBtn.FlatAppearance.BorderSize = 0;
            this.OrdersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OrdersBtn.ForeColor = System.Drawing.Color.White;
            this.OrdersBtn.Image = ((System.Drawing.Image)(resources.GetObject("OrdersBtn.Image")));
            this.OrdersBtn.Location = new System.Drawing.Point(-1, 151);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(291, 75);
            this.OrdersBtn.TabIndex = 0;
            this.OrdersBtn.Text = "SUPPLY ORDERS";
            this.OrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdersBtn.UseVisualStyleBackColor = false;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.UsersBtn.FlatAppearance.BorderSize = 0;
            this.UsersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.UsersBtn.ForeColor = System.Drawing.Color.White;
            this.UsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("UsersBtn.Image")));
            this.UsersBtn.Location = new System.Drawing.Point(-1, 76);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(291, 75);
            this.UsersBtn.TabIndex = 0;
            this.UsersBtn.Text = "USERS";
            this.UsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsersBtn.UseVisualStyleBackColor = false;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ItemsBtn.FlatAppearance.BorderSize = 0;
            this.ItemsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ItemsBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItemsBtn.Image")));
            this.ItemsBtn.Location = new System.Drawing.Point(-1, 1);
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Size = new System.Drawing.Size(291, 75);
            this.ItemsBtn.TabIndex = 0;
            this.ItemsBtn.Text = "ITEMS AND CATEGORIES";
            this.ItemsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ItemsBtn.UseVisualStyleBackColor = false;
            this.ItemsBtn.Click += new System.EventHandler(this.ItemsBtn_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitle.Controls.Add(this.CloseChildFormBtn);
            this.panelTitle.Controls.Add(this.LblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(291, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1183, 42);
            this.panelTitle.TabIndex = 1;
            // 
            // CloseChildFormBtn
            // 
            this.CloseChildFormBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseChildFormBtn.FlatAppearance.BorderSize = 0;
            this.CloseChildFormBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseChildFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseChildFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseChildFormBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseChildFormBtn.Location = new System.Drawing.Point(1117, 0);
            this.CloseChildFormBtn.Name = "CloseChildFormBtn";
            this.CloseChildFormBtn.Size = new System.Drawing.Size(66, 42);
            this.CloseChildFormBtn.TabIndex = 1;
            this.CloseChildFormBtn.Text = "X";
            this.CloseChildFormBtn.UseVisualStyleBackColor = true;
            this.CloseChildFormBtn.Click += new System.EventHandler(this.CloseChildFormBtn_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial Nova", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(510, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(85, 29);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(291, 42);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1183, 747);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1165, 151);
            this.label1.TabIndex = 0;
            this.label1.Text = "POINT OF SALE";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 789);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1492, 836);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button QuotationsBtn;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Button DeliveryBtn;
        private System.Windows.Forms.Button CustomersBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button ItemsBtn;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button SuppliersBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button CloseChildFormBtn;
        private System.Windows.Forms.Label LoggedInUserLbl;
        private System.Windows.Forms.Label label1;
    }
}