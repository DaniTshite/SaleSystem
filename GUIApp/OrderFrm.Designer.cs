
namespace GUIApp
{
    partial class OrderFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFrm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StockQuantityTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PurchasedQuantityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchasePriceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListItemsCmb = new System.Windows.Forms.ComboBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ListSuppliersCmb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderNumberTxt = new System.Windows.Forms.TextBox();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TaxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GdTotalTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.STotalTxt = new System.Windows.Forms.TextBox();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.ModifyQuantityMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialogOrder = new System.Windows.Forms.PrintPreviewDialog();
            this.printOrderDocument = new System.Drawing.Printing.PrintDocument();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintPreviewReportOrder = new System.Windows.Forms.Button();
            this.SearchOrderNumber = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchOrderNumberTxt = new System.Windows.Forms.TextBox();
            this.ReOrderListBtn = new System.Windows.Forms.Button();
            this.TotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.InactiveItemsListBtn = new System.Windows.Forms.Button();
            this.printItemsToReorderDocument = new System.Drawing.Printing.PrintDocument();
            this.printInactiveItemsDocument = new System.Drawing.Printing.PrintDocument();
            this.ItemsToReorderGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintPreviewItemsToReorder = new System.Windows.Forms.Button();
            this.InactiveItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FilterOrdersByDateGroupBox = new System.Windows.Forms.GroupBox();
            this.SuperiorDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InferiorDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalOrdersLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.ModifyQuantityMenu.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.TotalsGroupBox.SuspendLayout();
            this.ItemsToReorderGroupBox.SuspendLayout();
            this.InactiveItemsGroupBox.SuspendLayout();
            this.FilterOrdersByDateGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.StockQuantityTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PurchasedQuantityTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.purchasePriceTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ListItemsCmb);
            this.groupBox2.Controls.Add(this.AddItemBtn);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(1187, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "STOCK";
            // 
            // StockQuantityTxt
            // 
            this.StockQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantityTxt.Location = new System.Drawing.Point(181, 188);
            this.StockQuantityTxt.Name = "StockQuantityTxt";
            this.StockQuantityTxt.ReadOnly = true;
            this.StockQuantityTxt.Size = new System.Drawing.Size(146, 27);
            this.StockQuantityTxt.TabIndex = 13;
            this.StockQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "QUANTITY";
            // 
            // PurchasedQuantityTxt
            // 
            this.PurchasedQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasedQuantityTxt.Location = new System.Drawing.Point(181, 139);
            this.PurchasedQuantityTxt.Name = "PurchasedQuantityTxt";
            this.PurchasedQuantityTxt.Size = new System.Drawing.Size(146, 27);
            this.PurchasedQuantityTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UNIT PRICE";
            // 
            // purchasePriceTxt
            // 
            this.purchasePriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasePriceTxt.Location = new System.Drawing.Point(181, 93);
            this.purchasePriceTxt.Name = "purchasePriceTxt";
            this.purchasePriceTxt.Size = new System.Drawing.Size(146, 27);
            this.purchasePriceTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECT ITEM";
            // 
            // ListItemsCmb
            // 
            this.ListItemsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemsCmb.FormattingEnabled = true;
            this.ListItemsCmb.Location = new System.Drawing.Point(14, 43);
            this.ListItemsCmb.Name = "ListItemsCmb";
            this.ListItemsCmb.Size = new System.Drawing.Size(313, 28);
            this.ListItemsCmb.TabIndex = 1;
            this.ListItemsCmb.SelectedValueChanged += new System.EventHandler(this.ListItemsCmb_SelectedValueChanged);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemBtn.Location = new System.Drawing.Point(16, 221);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(316, 50);
            this.AddItemBtn.TabIndex = 4;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveOrderBtn.Enabled = false;
            this.SaveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrderBtn.Location = new System.Drawing.Point(231, 6);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(102, 116);
            this.SaveOrderBtn.TabIndex = 5;
            this.SaveOrderBtn.Text = "SAVE";
            this.SaveOrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveOrderBtn.UseVisualStyleBackColor = true;
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Enabled = false;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(4, 7);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(109, 116);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-155, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Supplier";
            // 
            // ListSuppliersCmb
            // 
            this.ListSuppliersCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSuppliersCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSuppliersCmb.FormattingEnabled = true;
            this.ListSuppliersCmb.Location = new System.Drawing.Point(14, 16);
            this.ListSuppliersCmb.Name = "ListSuppliersCmb";
            this.ListSuppliersCmb.Size = new System.Drawing.Size(315, 28);
            this.ListSuppliersCmb.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.OrderNumberTxt);
            this.groupBox3.Controls.Add(this.OrderDatePicker);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ListSuppliersCmb);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(1187, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 123);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-144, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Order Number";
            // 
            // OrderNumberTxt
            // 
            this.OrderNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberTxt.Location = new System.Drawing.Point(14, 83);
            this.OrderNumberTxt.Name = "OrderNumberTxt";
            this.OrderNumberTxt.Size = new System.Drawing.Size(313, 27);
            this.OrderNumberTxt.TabIndex = 10;
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDatePicker.Location = new System.Drawing.Point(14, 50);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(313, 27);
            this.OrderDatePicker.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-144, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ItemsGridView);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 585);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.AllowUserToOrderColumns = true;
            this.ItemsGridView.AllowUserToResizeColumns = false;
            this.ItemsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.ItemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.ItemsGridView.GridColor = System.Drawing.Color.White;
            this.ItemsGridView.Location = new System.Drawing.Point(6, 28);
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.ItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ItemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(1155, 551);
            this.ItemsGridView.TabIndex = 21;
            this.ItemsGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemsGridView_CellMouseDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "TAX";
            // 
            // TaxTxt
            // 
            this.TaxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TaxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxt.ForeColor = System.Drawing.Color.Blue;
            this.TaxTxt.Location = new System.Drawing.Point(191, 79);
            this.TaxTxt.Name = "TaxTxt";
            this.TaxTxt.ReadOnly = true;
            this.TaxTxt.Size = new System.Drawing.Size(221, 38);
            this.TaxTxt.TabIndex = 14;
            this.TaxTxt.Text = "0";
            this.TaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "TOTAL";
            // 
            // GdTotalTxt
            // 
            this.GdTotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GdTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GdTotalTxt.ForeColor = System.Drawing.Color.Blue;
            this.GdTotalTxt.Location = new System.Drawing.Point(191, 134);
            this.GdTotalTxt.Name = "GdTotalTxt";
            this.GdTotalTxt.ReadOnly = true;
            this.GdTotalTxt.Size = new System.Drawing.Size(221, 38);
            this.GdTotalTxt.TabIndex = 12;
            this.GdTotalTxt.Text = "0";
            this.GdTotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "SUB TOTAL";
            // 
            // STotalTxt
            // 
            this.STotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.STotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STotalTxt.ForeColor = System.Drawing.Color.Blue;
            this.STotalTxt.Location = new System.Drawing.Point(195, 21);
            this.STotalTxt.Name = "STotalTxt";
            this.STotalTxt.ReadOnly = true;
            this.STotalTxt.Size = new System.Drawing.Size(217, 38);
            this.STotalTxt.TabIndex = 10;
            this.STotalTxt.Text = "0";
            this.STotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderBtn.Location = new System.Drawing.Point(119, 7);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(106, 115);
            this.NewOrderBtn.TabIndex = 18;
            this.NewOrderBtn.Text = "NEW";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // ModifyQuantityMenu
            // 
            this.ModifyQuantityMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ModifyQuantityMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ModifyQuantityMenu.Name = "ModifyQuantityMenu";
            this.ModifyQuantityMenu.Size = new System.Drawing.Size(126, 52);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printPreviewDialogOrder
            // 
            this.printPreviewDialogOrder.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOrder.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOrder.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogOrder.Enabled = true;
            this.printPreviewDialogOrder.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogOrder.Icon")));
            this.printPreviewDialogOrder.Name = "printPreviewDialogOrder";
            this.printPreviewDialogOrder.Visible = false;
            // 
            // printOrderDocument
            // 
            this.printOrderDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printOrderDocument_PrintPage);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroupBox.Controls.Add(this.PrintPreviewReportOrder);
            this.SearchGroupBox.Controls.Add(this.SearchOrderNumber);
            this.SearchGroupBox.Controls.Add(this.label6);
            this.SearchGroupBox.Controls.Add(this.SearchOrderNumberTxt);
            this.SearchGroupBox.Enabled = false;
            this.SearchGroupBox.Location = new System.Drawing.Point(1193, 430);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(337, 190);
            this.SearchGroupBox.TabIndex = 19;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // PrintPreviewReportOrder
            // 
            this.PrintPreviewReportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintPreviewReportOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewReportOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewReportOrder.Location = new System.Drawing.Point(8, 133);
            this.PrintPreviewReportOrder.Name = "PrintPreviewReportOrder";
            this.PrintPreviewReportOrder.Size = new System.Drawing.Size(313, 41);
            this.PrintPreviewReportOrder.TabIndex = 27;
            this.PrintPreviewReportOrder.Text = "Print Preview";
            this.PrintPreviewReportOrder.UseVisualStyleBackColor = true;
            this.PrintPreviewReportOrder.Click += new System.EventHandler(this.PrintPreviewReportOrder_Click);
            // 
            // SearchOrderNumber
            // 
            this.SearchOrderNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrderNumber.Location = new System.Drawing.Point(8, 80);
            this.SearchOrderNumber.Name = "SearchOrderNumber";
            this.SearchOrderNumber.Size = new System.Drawing.Size(313, 39);
            this.SearchOrderNumber.TabIndex = 20;
            this.SearchOrderNumber.Text = "Search";
            this.SearchOrderNumber.UseVisualStyleBackColor = true;
            this.SearchOrderNumber.Click += new System.EventHandler(this.SearchOrderNumber_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "ORDER NUMBER";
            // 
            // SearchOrderNumberTxt
            // 
            this.SearchOrderNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrderNumberTxt.Location = new System.Drawing.Point(8, 47);
            this.SearchOrderNumberTxt.Name = "SearchOrderNumberTxt";
            this.SearchOrderNumberTxt.Size = new System.Drawing.Size(313, 27);
            this.SearchOrderNumberTxt.TabIndex = 25;
            // 
            // ReOrderListBtn
            // 
            this.ReOrderListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReOrderListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReOrderListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReOrderListBtn.Location = new System.Drawing.Point(6, 25);
            this.ReOrderListBtn.Name = "ReOrderListBtn";
            this.ReOrderListBtn.Size = new System.Drawing.Size(168, 65);
            this.ReOrderListBtn.TabIndex = 28;
            this.ReOrderListBtn.Text = "REORDER LIST";
            this.ReOrderListBtn.UseVisualStyleBackColor = true;
            this.ReOrderListBtn.Click += new System.EventHandler(this.ReOrderListBtn_Click);
            // 
            // TotalsGroupBox
            // 
            this.TotalsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalsGroupBox.Controls.Add(this.TaxTxt);
            this.TotalsGroupBox.Controls.Add(this.label8);
            this.TotalsGroupBox.Controls.Add(this.label9);
            this.TotalsGroupBox.Controls.Add(this.STotalTxt);
            this.TotalsGroupBox.Controls.Add(this.GdTotalTxt);
            this.TotalsGroupBox.Controls.Add(this.label10);
            this.TotalsGroupBox.Enabled = false;
            this.TotalsGroupBox.Location = new System.Drawing.Point(12, 593);
            this.TotalsGroupBox.Name = "TotalsGroupBox";
            this.TotalsGroupBox.Size = new System.Drawing.Size(433, 191);
            this.TotalsGroupBox.TabIndex = 20;
            this.TotalsGroupBox.TabStop = false;
            // 
            // InactiveItemsListBtn
            // 
            this.InactiveItemsListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InactiveItemsListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InactiveItemsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveItemsListBtn.Location = new System.Drawing.Point(6, 24);
            this.InactiveItemsListBtn.Name = "InactiveItemsListBtn";
            this.InactiveItemsListBtn.Size = new System.Drawing.Size(191, 66);
            this.InactiveItemsListBtn.TabIndex = 29;
            this.InactiveItemsListBtn.Text = "INACTIVE ITEMS";
            this.InactiveItemsListBtn.UseVisualStyleBackColor = true;
            this.InactiveItemsListBtn.Click += new System.EventHandler(this.InactiveItemsListBtn_Click);
            // 
            // printItemsToReorderDocument
            // 
            this.printItemsToReorderDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printItemsToReorderDocument_PrintPage);
            // 
            // printInactiveItemsDocument
            // 
            this.printInactiveItemsDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInactiveItemsDocument_PrintPage);
            // 
            // ItemsToReorderGroupBox
            // 
            this.ItemsToReorderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsToReorderGroupBox.Controls.Add(this.PrintPreviewItemsToReorder);
            this.ItemsToReorderGroupBox.Controls.Add(this.ReOrderListBtn);
            this.ItemsToReorderGroupBox.Enabled = false;
            this.ItemsToReorderGroupBox.Location = new System.Drawing.Point(660, 593);
            this.ItemsToReorderGroupBox.Name = "ItemsToReorderGroupBox";
            this.ItemsToReorderGroupBox.Size = new System.Drawing.Size(180, 191);
            this.ItemsToReorderGroupBox.TabIndex = 30;
            this.ItemsToReorderGroupBox.TabStop = false;
            this.ItemsToReorderGroupBox.Text = "items To Reorder";
            // 
            // PrintPreviewItemsToReorder
            // 
            this.PrintPreviewItemsToReorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintPreviewItemsToReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewItemsToReorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewItemsToReorder.Location = new System.Drawing.Point(6, 96);
            this.PrintPreviewItemsToReorder.Name = "PrintPreviewItemsToReorder";
            this.PrintPreviewItemsToReorder.Size = new System.Drawing.Size(168, 81);
            this.PrintPreviewItemsToReorder.TabIndex = 28;
            this.PrintPreviewItemsToReorder.Text = "PRINT PREVIEW";
            this.PrintPreviewItemsToReorder.UseVisualStyleBackColor = true;
            this.PrintPreviewItemsToReorder.Click += new System.EventHandler(this.PrintPreviewItemsToReorder_Click);
            // 
            // InactiveItemsGroupBox
            // 
            this.InactiveItemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InactiveItemsGroupBox.Controls.Add(this.button2);
            this.InactiveItemsGroupBox.Controls.Add(this.InactiveItemsListBtn);
            this.InactiveItemsGroupBox.Enabled = false;
            this.InactiveItemsGroupBox.Location = new System.Drawing.Point(451, 593);
            this.InactiveItemsGroupBox.Name = "InactiveItemsGroupBox";
            this.InactiveItemsGroupBox.Size = new System.Drawing.Size(203, 191);
            this.InactiveItemsGroupBox.TabIndex = 31;
            this.InactiveItemsGroupBox.TabStop = false;
            this.InactiveItemsGroupBox.Text = "Inactive items";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 81);
            this.button2.TabIndex = 29;
            this.button2.Text = "PRINT PREVIEW";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FilterOrdersByDateGroupBox
            // 
            this.FilterOrdersByDateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterOrdersByDateGroupBox.Controls.Add(this.SuperiorDateTimePicker);
            this.FilterOrdersByDateGroupBox.Controls.Add(this.InferiorDateTimePicker);
            this.FilterOrdersByDateGroupBox.Controls.Add(this.label14);
            this.FilterOrdersByDateGroupBox.Controls.Add(this.label13);
            this.FilterOrdersByDateGroupBox.Enabled = false;
            this.FilterOrdersByDateGroupBox.Location = new System.Drawing.Point(1187, 625);
            this.FilterOrdersByDateGroupBox.Name = "FilterOrdersByDateGroupBox";
            this.FilterOrdersByDateGroupBox.Size = new System.Drawing.Size(343, 159);
            this.FilterOrdersByDateGroupBox.TabIndex = 32;
            this.FilterOrdersByDateGroupBox.TabStop = false;
            this.FilterOrdersByDateGroupBox.Text = "Filter Orders By Date";
            // 
            // SuperiorDateTimePicker
            // 
            this.SuperiorDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SuperiorDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperiorDateTimePicker.Location = new System.Drawing.Point(16, 118);
            this.SuperiorDateTimePicker.Name = "SuperiorDateTimePicker";
            this.SuperiorDateTimePicker.Size = new System.Drawing.Size(313, 27);
            this.SuperiorDateTimePicker.TabIndex = 31;
            this.SuperiorDateTimePicker.ValueChanged += new System.EventHandler(this.SuperiorDateTimePicker_ValueChanged);
            // 
            // InferiorDateTimePicker
            // 
            this.InferiorDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InferiorDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InferiorDateTimePicker.Location = new System.Drawing.Point(16, 47);
            this.InferiorDateTimePicker.Name = "InferiorDateTimePicker";
            this.InferiorDateTimePicker.Size = new System.Drawing.Size(313, 27);
            this.InferiorDateTimePicker.TabIndex = 25;
            this.InferiorDateTimePicker.ValueChanged += new System.EventHandler(this.InferiorDateTimePicker_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "END DATE";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "START DATE";
            // 
            // TotalOrdersLbl
            // 
            this.TotalOrdersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalOrdersLbl.AutoSize = true;
            this.TotalOrdersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalOrdersLbl.ForeColor = System.Drawing.Color.Blue;
            this.TotalOrdersLbl.Location = new System.Drawing.Point(857, 590);
            this.TotalOrdersLbl.Name = "TotalOrdersLbl";
            this.TotalOrdersLbl.Size = new System.Drawing.Size(31, 29);
            this.TotalOrdersLbl.TabIndex = 34;
            this.TotalOrdersLbl.Text = "R";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NewOrderBtn);
            this.panel1.Controls.Add(this.SaveOrderBtn);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Location = new System.Drawing.Point(846, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 138);
            this.panel1.TabIndex = 22;
            // 
            // OrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1632, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.TotalOrdersLbl);
            this.Controls.Add(this.FilterOrdersByDateGroupBox);
            this.Controls.Add(this.InactiveItemsGroupBox);
            this.Controls.Add(this.ItemsToReorderGroupBox);
            this.Controls.Add(this.TotalsGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1650, 859);
            this.Name = "OrderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.ModifyQuantityMenu.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.TotalsGroupBox.ResumeLayout(false);
            this.TotalsGroupBox.PerformLayout();
            this.ItemsToReorderGroupBox.ResumeLayout(false);
            this.InactiveItemsGroupBox.ResumeLayout(false);
            this.FilterOrdersByDateGroupBox.ResumeLayout(false);
            this.FilterOrdersByDateGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListItemsCmb;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PurchasedQuantityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox purchasePriceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ListSuppliersCmb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TaxTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GdTotalTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox STotalTxt;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderNumberTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StockQuantityTxt;
        private System.Windows.Forms.ContextMenuStrip ModifyQuantityMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOrder;
        private System.Drawing.Printing.PrintDocument printOrderDocument;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button SearchOrderNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchOrderNumberTxt;
        private System.Windows.Forms.GroupBox TotalsGroupBox;
        private System.Windows.Forms.Button PrintPreviewReportOrder;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Button ReOrderListBtn;
        private System.Windows.Forms.Button InactiveItemsListBtn;
        private System.Drawing.Printing.PrintDocument printItemsToReorderDocument;
        private System.Drawing.Printing.PrintDocument printInactiveItemsDocument;
        private System.Windows.Forms.GroupBox ItemsToReorderGroupBox;
        private System.Windows.Forms.Button PrintPreviewItemsToReorder;
        private System.Windows.Forms.GroupBox InactiveItemsGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox FilterOrdersByDateGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker InferiorDateTimePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker SuperiorDateTimePicker;
        private System.Windows.Forms.Label TotalOrdersLbl;
        private System.Windows.Forms.Panel panel1;
    }
}