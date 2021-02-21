
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsersCmb = new System.Windows.Forms.ComboBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaleQuantityTxt = new System.Windows.Forms.TextBox();
            this.StockQuantityLbl = new System.Windows.Forms.Label();
            this.RetailPriceLbl = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CashBtn = new System.Windows.Forms.Button();
            this.CreditBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ItemsGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 807);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.UsersCmb);
            this.panel3.Controls.Add(this.CustomerAccountsCmb);
            this.panel3.Controls.Add(this.QuotationsCmb);
            this.panel3.Location = new System.Drawing.Point(523, 649);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 152);
            this.panel3.TabIndex = 50;
            // 
            // UsersCmb
            // 
            this.UsersCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsersCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsersCmb.FormattingEnabled = true;
            this.UsersCmb.Location = new System.Drawing.Point(17, 17);
            this.UsersCmb.Name = "UsersCmb";
            this.UsersCmb.Size = new System.Drawing.Size(338, 28);
            this.UsersCmb.TabIndex = 49;
            this.UsersCmb.TextChanged += new System.EventHandler(this.UsersCmb_TextChanged);
            // 
            // CustomerAccountsCmb
            // 
            this.CustomerAccountsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerAccountsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CustomerAccountsCmb.FormattingEnabled = true;
            this.CustomerAccountsCmb.Location = new System.Drawing.Point(17, 112);
            this.CustomerAccountsCmb.Name = "CustomerAccountsCmb";
            this.CustomerAccountsCmb.Size = new System.Drawing.Size(338, 28);
            this.CustomerAccountsCmb.TabIndex = 47;
            // 
            // QuotationsCmb
            // 
            this.QuotationsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuotationsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuotationsCmb.FormattingEnabled = true;
            this.QuotationsCmb.Location = new System.Drawing.Point(17, 62);
            this.QuotationsCmb.Name = "QuotationsCmb";
            this.QuotationsCmb.Size = new System.Drawing.Size(338, 28);
            this.QuotationsCmb.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.TotalOrdersLbl);
            this.panel2.Controls.Add(this.TotalLbl);
            this.panel2.Controls.Add(this.SubTotalLbl);
            this.panel2.Controls.Add(this.TaxLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 152);
            this.panel2.TabIndex = 46;
            // 
            // TotalOrdersLbl
            // 
            this.TotalOrdersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalOrdersLbl.AutoSize = true;
            this.TotalOrdersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalOrdersLbl.ForeColor = System.Drawing.Color.Blue;
            this.TotalOrdersLbl.Location = new System.Drawing.Point(14, 16);
            this.TotalOrdersLbl.Name = "TotalOrdersLbl";
            this.TotalOrdersLbl.Size = new System.Drawing.Size(201, 29);
            this.TotalOrdersLbl.TabIndex = 35;
            this.TotalOrdersLbl.Text = " SUB TOTAL      ";
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalLbl.ForeColor = System.Drawing.Color.Blue;
            this.TotalLbl.Location = new System.Drawing.Point(241, 114);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(27, 29);
            this.TotalLbl.TabIndex = 43;
            this.TotalLbl.Text = "0";
            // 
            // SubTotalLbl
            // 
            this.SubTotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotalLbl.AutoSize = true;
            this.SubTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubTotalLbl.ForeColor = System.Drawing.Color.Blue;
            this.SubTotalLbl.Location = new System.Drawing.Point(239, 17);
            this.SubTotalLbl.Name = "SubTotalLbl";
            this.SubTotalLbl.Size = new System.Drawing.Size(27, 29);
            this.SubTotalLbl.TabIndex = 42;
            this.SubTotalLbl.Text = "0";
            // 
            // TaxLbl
            // 
            this.TaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TaxLbl.AutoSize = true;
            this.TaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TaxLbl.ForeColor = System.Drawing.Color.Blue;
            this.TaxLbl.Location = new System.Drawing.Point(241, 62);
            this.TaxLbl.Name = "TaxLbl";
            this.TaxLbl.Size = new System.Drawing.Size(27, 29);
            this.TaxLbl.TabIndex = 44;
            this.TaxLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "GRAND TOTAL ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "TAX                    ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.InvoiceNumberLbl);
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 42);
            this.panel1.TabIndex = 23;
            // 
            // InvoiceNumberLbl
            // 
            this.InvoiceNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InvoiceNumberLbl.AutoSize = true;
            this.InvoiceNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.InvoiceNumberLbl.ForeColor = System.Drawing.Color.Blue;
            this.InvoiceNumberLbl.Location = new System.Drawing.Point(9, 6);
            this.InvoiceNumberLbl.Name = "InvoiceNumberLbl";
            this.InvoiceNumberLbl.Size = new System.Drawing.Size(161, 26);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ItemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsGridView.GridColor = System.Drawing.Color.White;
            this.ItemsGridView.Location = new System.Drawing.Point(18, 69);
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ItemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(1113, 574);
            this.ItemsGridView.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SaleQuantityTxt);
            this.groupBox2.Controls.Add(this.StockQuantityLbl);
            this.groupBox2.Controls.Add(this.RetailPriceLbl);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.ItemsListBox);
            this.groupBox2.Location = new System.Drawing.Point(1156, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 479);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(22, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(22, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stock";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(22, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unit Price";
            // 
            // SaleQuantityTxt
            // 
            this.SaleQuantityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleQuantityTxt.Location = new System.Drawing.Point(140, 369);
            this.SaleQuantityTxt.Name = "SaleQuantityTxt";
            this.SaleQuantityTxt.Size = new System.Drawing.Size(189, 22);
            this.SaleQuantityTxt.TabIndex = 12;
            // 
            // StockQuantityLbl
            // 
            this.StockQuantityLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StockQuantityLbl.AutoSize = true;
            this.StockQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StockQuantityLbl.ForeColor = System.Drawing.Color.Blue;
            this.StockQuantityLbl.Location = new System.Drawing.Point(262, 336);
            this.StockQuantityLbl.Name = "StockQuantityLbl";
            this.StockQuantityLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StockQuantityLbl.Size = new System.Drawing.Size(53, 20);
            this.StockQuantityLbl.TabIndex = 11;
            this.StockQuantityLbl.Text = "label4";
            // 
            // RetailPriceLbl
            // 
            this.RetailPriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetailPriceLbl.AutoSize = true;
            this.RetailPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RetailPriceLbl.ForeColor = System.Drawing.Color.Blue;
            this.RetailPriceLbl.Location = new System.Drawing.Point(247, 306);
            this.RetailPriceLbl.Name = "RetailPriceLbl";
            this.RetailPriceLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RetailPriceLbl.Size = new System.Drawing.Size(53, 20);
            this.RetailPriceLbl.TabIndex = 10;
            this.RetailPriceLbl.Text = "label3";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(6, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(332, 48);
            this.button7.TabIndex = 9;
            this.button7.Text = "Add To Chart";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 29;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 21);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(332, 265);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedValueChanged += new System.EventHandler(this.ItemsListBox_SelectedValueChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.White;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(25, 122);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(122, 85);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(189, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 85);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(25, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 85);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.BackColor = System.Drawing.Color.White;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Location = new System.Drawing.Point(189, 122);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(122, 85);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.CashBtn);
            this.groupBox3.Controls.Add(this.CreditBtn);
            this.groupBox3.Controls.Add(this.CancelBtn);
            this.groupBox3.Controls.Add(this.ResetBtn);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(1156, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 326);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // CashBtn
            // 
            this.CashBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CashBtn.BackColor = System.Drawing.Color.White;
            this.CashBtn.Enabled = false;
            this.CashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashBtn.Location = new System.Drawing.Point(25, 19);
            this.CashBtn.Name = "CashBtn";
            this.CashBtn.Size = new System.Drawing.Size(122, 85);
            this.CashBtn.TabIndex = 7;
            this.CashBtn.Text = "Cash";
            this.CashBtn.UseVisualStyleBackColor = false;
            this.CashBtn.Click += new System.EventHandler(this.CashBtn_Click);
            // 
            // CreditBtn
            // 
            this.CreditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditBtn.BackColor = System.Drawing.Color.White;
            this.CreditBtn.Enabled = false;
            this.CreditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditBtn.Location = new System.Drawing.Point(189, 19);
            this.CreditBtn.Name = "CreditBtn";
            this.CreditBtn.Size = new System.Drawing.Size(122, 85);
            this.CreditBtn.TabIndex = 8;
            this.CreditBtn.Text = "Credit";
            this.CreditBtn.UseVisualStyleBackColor = false;
            // 
            // SaleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 832);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Label TotalOrdersLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CashBtn;
        private System.Windows.Forms.Button CreditBtn;
        private System.Windows.Forms.Button button7;
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
        private System.Windows.Forms.ComboBox UsersCmb;
        private System.Windows.Forms.ComboBox CustomerAccountsCmb;
        private System.Windows.Forms.ComboBox QuotationsCmb;
    }
}