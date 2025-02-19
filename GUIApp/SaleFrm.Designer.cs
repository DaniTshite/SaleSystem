﻿
namespace GUIApp
{
    partial class SaleFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ChangeLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaidTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerAccountsCmb = new System.Windows.Forms.ComboBox();
            this.QuotationsCmb = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalOrdersLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.SubTotalLbl = new System.Windows.Forms.Label();
            this.TaxLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvoiceNumberLbl = new System.Windows.Forms.Label();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaleQuantityTxt = new System.Windows.Forms.TextBox();
            this.StockQuantityLbl = new System.Windows.Forms.Label();
            this.RetailPriceLbl = new System.Windows.Forms.Label();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.RefundBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DeliveryCmb = new System.Windows.Forms.ComboBox();
            this.DeliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CashBtn = new System.Windows.Forms.Button();
            this.EFTBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ItemsGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 814);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ChangeLbl);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.PaidTxt);
            this.panel4.Location = new System.Drawing.Point(826, 657);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 151);
            this.panel4.TabIndex = 51;
            // 
            // ChangeLbl
            // 
            this.ChangeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLbl.AutoSize = true;
            this.ChangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLbl.ForeColor = System.Drawing.Color.White;
            this.ChangeLbl.Location = new System.Drawing.Point(149, 87);
            this.ChangeLbl.Name = "ChangeLbl";
            this.ChangeLbl.Size = new System.Drawing.Size(66, 29);
            this.ChangeLbl.TabIndex = 36;
            this.ChangeLbl.Text = "0.00";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "PAID";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "CHANGE ";
            // 
            // PaidTxt
            // 
            this.PaidTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaidTxt.Enabled = false;
            this.PaidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PaidTxt.Location = new System.Drawing.Point(154, 13);
            this.PaidTxt.Name = "PaidTxt";
            this.PaidTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaidTxt.Size = new System.Drawing.Size(149, 38);
            this.PaidTxt.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.CustomerAccountsCmb);
            this.panel3.Controls.Add(this.QuotationsCmb);
            this.panel3.Location = new System.Drawing.Point(448, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 152);
            this.panel3.TabIndex = 50;
            // 
            // CustomerAccountsCmb
            // 
            this.CustomerAccountsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerAccountsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.CustomerAccountsCmb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CustomerAccountsCmb.FormattingEnabled = true;
            this.CustomerAccountsCmb.Location = new System.Drawing.Point(17, 92);
            this.CustomerAccountsCmb.Name = "CustomerAccountsCmb";
            this.CustomerAccountsCmb.Size = new System.Drawing.Size(338, 24);
            this.CustomerAccountsCmb.TabIndex = 47;
            // 
            // QuotationsCmb
            // 
            this.QuotationsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuotationsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.QuotationsCmb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.QuotationsCmb.FormattingEnabled = true;
            this.QuotationsCmb.Location = new System.Drawing.Point(17, 27);
            this.QuotationsCmb.Name = "QuotationsCmb";
            this.QuotationsCmb.Size = new System.Drawing.Size(338, 24);
            this.QuotationsCmb.TabIndex = 48;
            this.QuotationsCmb.SelectedValueChanged += new System.EventHandler(this.QuotationsCmb_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TotalOrdersLbl);
            this.panel2.Controls.Add(this.TotalLbl);
            this.panel2.Controls.Add(this.SubTotalLbl);
            this.panel2.Controls.Add(this.TaxLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 656);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 152);
            this.panel2.TabIndex = 46;
            // 
            // TotalOrdersLbl
            // 
            this.TotalOrdersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalOrdersLbl.AutoSize = true;
            this.TotalOrdersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrdersLbl.ForeColor = System.Drawing.Color.White;
            this.TotalOrdersLbl.Location = new System.Drawing.Point(8, 11);
            this.TotalOrdersLbl.Name = "TotalOrdersLbl";
            this.TotalOrdersLbl.Size = new System.Drawing.Size(217, 29);
            this.TotalOrdersLbl.TabIndex = 35;
            this.TotalOrdersLbl.Text = " SUB TOTAL      ";
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.White;
            this.TotalLbl.Location = new System.Drawing.Point(262, 108);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(66, 29);
            this.TotalLbl.TabIndex = 43;
            this.TotalLbl.Text = "0.00";
            // 
            // SubTotalLbl
            // 
            this.SubTotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotalLbl.AutoSize = true;
            this.SubTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLbl.ForeColor = System.Drawing.Color.White;
            this.SubTotalLbl.Location = new System.Drawing.Point(262, 15);
            this.SubTotalLbl.Name = "SubTotalLbl";
            this.SubTotalLbl.Size = new System.Drawing.Size(66, 29);
            this.SubTotalLbl.TabIndex = 42;
            this.SubTotalLbl.Text = "0.00";
            // 
            // TaxLbl
            // 
            this.TaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TaxLbl.AutoSize = true;
            this.TaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLbl.ForeColor = System.Drawing.Color.White;
            this.TaxLbl.Location = new System.Drawing.Point(262, 61);
            this.TaxLbl.Name = "TaxLbl";
            this.TaxLbl.Size = new System.Drawing.Size(66, 29);
            this.TaxLbl.TabIndex = 44;
            this.TaxLbl.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "GRAND TOTAL ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "TAX  (VAT)                  ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.InvoiceNumberLbl);
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 50);
            this.panel1.TabIndex = 23;
            // 
            // InvoiceNumberLbl
            // 
            this.InvoiceNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InvoiceNumberLbl.AutoSize = true;
            this.InvoiceNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumberLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.InvoiceNumberLbl.Location = new System.Drawing.Point(3, 7);
            this.InvoiceNumberLbl.Name = "InvoiceNumberLbl";
            this.InvoiceNumberLbl.Size = new System.Drawing.Size(175, 26);
            this.InvoiceNumberLbl.TabIndex = 35;
            this.InvoiceNumberLbl.Text = "INVOICE No :  ";
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.AllowUserToOrderColumns = true;
            this.ItemsGridView.AllowUserToResizeColumns = false;
            this.ItemsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.ItemsGridView.GridColor = System.Drawing.Color.White;
            this.ItemsGridView.Location = new System.Drawing.Point(6, 63);
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ItemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(1141, 587);
            this.ItemsGridView.TabIndex = 22;
            this.ItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "DELIVERY DATE";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SaleQuantityTxt);
            this.groupBox2.Controls.Add(this.StockQuantityLbl);
            this.groupBox2.Controls.Add(this.RetailPriceLbl);
            this.groupBox2.Controls.Add(this.AddToCartBtn);
            this.groupBox2.Controls.Add(this.ItemsListBox);
            this.groupBox2.Location = new System.Drawing.Point(1172, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 486);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "STOCK";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "UNIT PRICE";
            // 
            // SaleQuantityTxt
            // 
            this.SaleQuantityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleQuantityTxt.Enabled = false;
            this.SaleQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleQuantityTxt.ForeColor = System.Drawing.Color.Navy;
            this.SaleQuantityTxt.Location = new System.Drawing.Point(245, 367);
            this.SaleQuantityTxt.Name = "SaleQuantityTxt";
            this.SaleQuantityTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaleQuantityTxt.Size = new System.Drawing.Size(84, 38);
            this.SaleQuantityTxt.TabIndex = 12;
            // 
            // StockQuantityLbl
            // 
            this.StockQuantityLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StockQuantityLbl.AutoSize = true;
            this.StockQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.StockQuantityLbl.Location = new System.Drawing.Point(262, 334);
            this.StockQuantityLbl.Name = "StockQuantityLbl";
            this.StockQuantityLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StockQuantityLbl.Size = new System.Drawing.Size(62, 29);
            this.StockQuantityLbl.TabIndex = 11;
            this.StockQuantityLbl.Text = "0.00";
            // 
            // RetailPriceLbl
            // 
            this.RetailPriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetailPriceLbl.AutoSize = true;
            this.RetailPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetailPriceLbl.ForeColor = System.Drawing.Color.White;
            this.RetailPriceLbl.Location = new System.Drawing.Point(203, 304);
            this.RetailPriceLbl.Name = "RetailPriceLbl";
            this.RetailPriceLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RetailPriceLbl.Size = new System.Drawing.Size(62, 29);
            this.RetailPriceLbl.TabIndex = 10;
            this.RetailPriceLbl.Text = "0.00";
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToCartBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddToCartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddToCartBtn.Enabled = false;
            this.AddToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartBtn.ForeColor = System.Drawing.Color.White;
            this.AddToCartBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddToCartBtn.Image")));
            this.AddToCartBtn.Location = new System.Drawing.Point(6, 411);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(332, 69);
            this.AddToCartBtn.TabIndex = 9;
            this.AddToCartBtn.Text = "ADD TO CART";
            this.AddToCartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ItemsListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 25;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 14);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(332, 279);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedValueChanged += new System.EventHandler(this.ItemsListBox_SelectedValueChanged);
            // 
            // RefundBtn
            // 
            this.RefundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefundBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.RefundBtn.Enabled = false;
            this.RefundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundBtn.ForeColor = System.Drawing.Color.White;
            this.RefundBtn.Location = new System.Drawing.Point(6, 93);
            this.RefundBtn.Name = "RefundBtn";
            this.RefundBtn.Size = new System.Drawing.Size(162, 73);
            this.RefundBtn.TabIndex = 3;
            this.RefundBtn.Text = "REFUND";
            this.RefundBtn.UseVisualStyleBackColor = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ResetBtn.Enabled = false;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResetBtn.Image")));
            this.ResetBtn.Location = new System.Drawing.Point(174, 93);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(164, 73);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.CashBtn);
            this.groupBox3.Controls.Add(this.EFTBtn);
            this.groupBox3.Controls.Add(this.RefundBtn);
            this.groupBox3.Controls.Add(this.ResetBtn);
            this.groupBox3.Location = new System.Drawing.Point(1172, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 328);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.DeliveryCmb);
            this.panel5.Controls.Add(this.DeliveryDateTimePicker);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(6, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 151);
            this.panel5.TabIndex = 42;
            // 
            // DeliveryCmb
            // 
            this.DeliveryCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliveryCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryCmb.FormattingEnabled = true;
            this.DeliveryCmb.Items.AddRange(new object[] {
            "COMPANY TRUCK",
            "CASH AND CARRY"});
            this.DeliveryCmb.Location = new System.Drawing.Point(16, 109);
            this.DeliveryCmb.Name = "DeliveryCmb";
            this.DeliveryCmb.Size = new System.Drawing.Size(304, 26);
            this.DeliveryCmb.TabIndex = 49;
            this.DeliveryCmb.DropDown += new System.EventHandler(this.UsersCmb_DropDown);
            this.DeliveryCmb.DropDownClosed += new System.EventHandler(this.UsersCmb_DropDownClosed);
            this.DeliveryCmb.SelectedValueChanged += new System.EventHandler(this.DeliveryCmb_SelectedValueChanged);
            this.DeliveryCmb.TextChanged += new System.EventHandler(this.UsersCmb_TextChanged);
            // 
            // DeliveryDateTimePicker
            // 
            this.DeliveryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDateTimePicker.Location = new System.Drawing.Point(16, 42);
            this.DeliveryDateTimePicker.Name = "DeliveryDateTimePicker";
            this.DeliveryDateTimePicker.Size = new System.Drawing.Size(304, 24);
            this.DeliveryDateTimePicker.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "DELIVERY TYPE";
            // 
            // CashBtn
            // 
            this.CashBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CashBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CashBtn.Enabled = false;
            this.CashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashBtn.ForeColor = System.Drawing.Color.White;
            this.CashBtn.Image = ((System.Drawing.Image)(resources.GetObject("CashBtn.Image")));
            this.CashBtn.Location = new System.Drawing.Point(6, 16);
            this.CashBtn.Name = "CashBtn";
            this.CashBtn.Size = new System.Drawing.Size(162, 71);
            this.CashBtn.TabIndex = 7;
            this.CashBtn.Text = "CASH";
            this.CashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CashBtn.UseVisualStyleBackColor = false;
            this.CashBtn.Click += new System.EventHandler(this.CashBtn_Click);
            // 
            // EFTBtn
            // 
            this.EFTBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EFTBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.EFTBtn.Enabled = false;
            this.EFTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EFTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EFTBtn.ForeColor = System.Drawing.Color.White;
            this.EFTBtn.Image = ((System.Drawing.Image)(resources.GetObject("EFTBtn.Image")));
            this.EFTBtn.Location = new System.Drawing.Point(174, 16);
            this.EFTBtn.Name = "EFTBtn";
            this.EFTBtn.Size = new System.Drawing.Size(164, 71);
            this.EFTBtn.TabIndex = 8;
            this.EFTBtn.Text = "EFT";
            this.EFTBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EFTBtn.UseVisualStyleBackColor = false;
            this.EFTBtn.Click += new System.EventHandler(this.EFTBtn_Click);
            // 
            // SaleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1528, 832);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button RefundBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Label TotalOrdersLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CashBtn;
        private System.Windows.Forms.Button EFTBtn;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SaleQuantityTxt;
        private System.Windows.Forms.Label StockQuantityLbl;
        private System.Windows.Forms.Label RetailPriceLbl;
        private System.Windows.Forms.Label TaxLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label SubTotalLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InvoiceNumberLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CustomerAccountsCmb;
        private System.Windows.Forms.ComboBox QuotationsCmb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PaidTxt;
        private System.Windows.Forms.Label ChangeLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DeliveryDateTimePicker;
        private System.Windows.Forms.ComboBox DeliveryCmb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
    }
}