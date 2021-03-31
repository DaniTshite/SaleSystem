
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ListSuppliersCmb = new System.Windows.Forms.ComboBox();
            this.OrderNumberTxt = new System.Windows.Forms.TextBox();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.ModifyQuantityMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "STOCK";
            // 
            // StockQuantityTxt
            // 
            this.StockQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StockQuantityTxt.Location = new System.Drawing.Point(173, 176);
            this.StockQuantityTxt.Name = "StockQuantityTxt";
            this.StockQuantityTxt.ReadOnly = true;
            this.StockQuantityTxt.Size = new System.Drawing.Size(186, 30);
            this.StockQuantityTxt.TabIndex = 13;
            this.StockQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "QUANTITY";
            // 
            // PurchasedQuantityTxt
            // 
            this.PurchasedQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PurchasedQuantityTxt.Location = new System.Drawing.Point(173, 127);
            this.PurchasedQuantityTxt.Name = "PurchasedQuantityTxt";
            this.PurchasedQuantityTxt.Size = new System.Drawing.Size(186, 30);
            this.PurchasedQuantityTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "UNIT PRICE";
            // 
            // purchasePriceTxt
            // 
            this.purchasePriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchasePriceTxt.Location = new System.Drawing.Point(173, 81);
            this.purchasePriceTxt.Name = "purchasePriceTxt";
            this.purchasePriceTxt.Size = new System.Drawing.Size(186, 30);
            this.purchasePriceTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECT ITEM";
            // 
            // ListItemsCmb
            // 
            this.ListItemsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListItemsCmb.FormattingEnabled = true;
            this.ListItemsCmb.Location = new System.Drawing.Point(10, 31);
            this.ListItemsCmb.Name = "ListItemsCmb";
            this.ListItemsCmb.Size = new System.Drawing.Size(349, 33);
            this.ListItemsCmb.TabIndex = 1;
            this.ListItemsCmb.SelectedValueChanged += new System.EventHandler(this.ListItemsCmb_SelectedValueChanged);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddItemBtn.Image")));
            this.AddItemBtn.Location = new System.Drawing.Point(17, 223);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(342, 70);
            this.AddItemBtn.TabIndex = 4;
            this.AddItemBtn.Text = "ADD ITEM";
            this.AddItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.SaveOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveOrderBtn.Image")));
            this.SaveOrderBtn.Location = new System.Drawing.Point(447, 6);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(134, 115);
            this.SaveOrderBtn.TabIndex = 5;
            this.SaveOrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveOrderBtn.UseVisualStyleBackColor = true;
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResetBtn.Image")));
            this.ResetBtn.Location = new System.Drawing.Point(305, 6);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(136, 116);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ListSuppliersCmb
            // 
            this.ListSuppliersCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSuppliersCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListSuppliersCmb.FormattingEnabled = true;
            this.ListSuppliersCmb.Location = new System.Drawing.Point(17, 344);
            this.ListSuppliersCmb.Name = "ListSuppliersCmb";
            this.ListSuppliersCmb.Size = new System.Drawing.Size(342, 33);
            this.ListSuppliersCmb.TabIndex = 21;
            // 
            // OrderNumberTxt
            // 
            this.OrderNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderNumberTxt.Location = new System.Drawing.Point(18, 502);
            this.OrderNumberTxt.Name = "OrderNumberTxt";
            this.OrderNumberTxt.Size = new System.Drawing.Size(342, 30);
            this.OrderNumberTxt.TabIndex = 10;
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderDatePicker.Location = new System.Drawing.Point(17, 426);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(342, 30);
            this.OrderDatePicker.TabIndex = 23;
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
            this.groupBox1.Size = new System.Drawing.Size(1219, 595);
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.ItemsGridView.GridColor = System.Drawing.Color.White;
            this.ItemsGridView.Location = new System.Drawing.Point(6, 19);
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
            this.ItemsGridView.Size = new System.Drawing.Size(1207, 570);
            this.ItemsGridView.TabIndex = 21;
            this.ItemsGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemsGridView_CellMouseDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "TAX";
            // 
            // TaxTxt
            // 
            this.TaxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TaxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TaxTxt.ForeColor = System.Drawing.Color.Blue;
            this.TaxTxt.Location = new System.Drawing.Point(199, 54);
            this.TaxTxt.Name = "TaxTxt";
            this.TaxTxt.ReadOnly = true;
            this.TaxTxt.Size = new System.Drawing.Size(267, 30);
            this.TaxTxt.TabIndex = 14;
            this.TaxTxt.Text = "0";
            this.TaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "TOTAL";
            // 
            // GdTotalTxt
            // 
            this.GdTotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GdTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GdTotalTxt.ForeColor = System.Drawing.Color.Blue;
            this.GdTotalTxt.Location = new System.Drawing.Point(199, 92);
            this.GdTotalTxt.Name = "GdTotalTxt";
            this.GdTotalTxt.ReadOnly = true;
            this.GdTotalTxt.Size = new System.Drawing.Size(267, 30);
            this.GdTotalTxt.TabIndex = 12;
            this.GdTotalTxt.Text = "0";
            this.GdTotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "SUB TOTAL";
            // 
            // STotalTxt
            // 
            this.STotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.STotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.STotalTxt.ForeColor = System.Drawing.Color.Blue;
            this.STotalTxt.Location = new System.Drawing.Point(199, 14);
            this.STotalTxt.Name = "STotalTxt";
            this.STotalTxt.ReadOnly = true;
            this.STotalTxt.Size = new System.Drawing.Size(267, 30);
            this.STotalTxt.TabIndex = 10;
            this.STotalTxt.Text = "0";
            this.STotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewOrderBtn.Image")));
            this.NewOrderBtn.Location = new System.Drawing.Point(587, 6);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(134, 115);
            this.NewOrderBtn.TabIndex = 18;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.OrderNumberTxt);
            this.panel2.Controls.Add(this.OrderDatePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ListSuppliersCmb);
            this.panel2.Controls.Add(this.AddItemBtn);
            this.panel2.Controls.Add(this.StockQuantityTxt);
            this.panel2.Controls.Add(this.ListItemsCmb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PurchasedQuantityTxt);
            this.panel2.Controls.Add(this.purchasePriceTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1239, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 723);
            this.panel2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TaxTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.GdTotalTxt);
            this.panel1.Controls.Add(this.STotalTxt);
            this.panel1.Location = new System.Drawing.Point(12, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 133);
            this.panel1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.NewOrderBtn);
            this.panel3.Controls.Add(this.ResetBtn);
            this.panel3.Controls.Add(this.SaveOrderBtn);
            this.panel3.Location = new System.Drawing.Point(505, 603);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 133);
            this.panel3.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "SUPPLIER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "DATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(13, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "ORDER NUMBER";
            // 
            // OrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1622, 743);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1600, 750);
            this.Name = "OrderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.ModifyQuantityMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListItemsCmb;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PurchasedQuantityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox purchasePriceTxt;
        private System.Windows.Forms.ComboBox ListSuppliersCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TaxTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GdTotalTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox STotalTxt;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.TextBox OrderNumberTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StockQuantityTxt;
        private System.Windows.Forms.ContextMenuStrip ModifyQuantityMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}