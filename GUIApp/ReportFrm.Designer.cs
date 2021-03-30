
namespace GUIApp
{
    partial class ReportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.FilterOrdersByDateGroupBox = new System.Windows.Forms.GroupBox();
            this.SuperiorDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InferiorDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalOrdersLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsToReorderGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintPreviewItemsToReorder = new System.Windows.Forms.Button();
            this.ReOrderListBtn = new System.Windows.Forms.Button();
            this.InactiveItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.InactiveItemsListBtn = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintPreviewReportOrder = new System.Windows.Forms.Button();
            this.SearchOrderNumber = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchOrderNumberTxt = new System.Windows.Forms.TextBox();
            this.printPreviewDialogOrder = new System.Windows.Forms.PrintPreviewDialog();
            this.printOrderDocument = new System.Drawing.Printing.PrintDocument();
            this.printItemsToReorderDocument = new System.Drawing.Printing.PrintDocument();
            this.printInactiveItemsDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.FilterOrdersByDateGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ItemsToReorderGroupBox.SuspendLayout();
            this.InactiveItemsGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SearchGroupBox);
            this.panel1.Controls.Add(this.InactiveItemsGroupBox);
            this.panel1.Controls.Add(this.ItemsToReorderGroupBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.FilterOrdersByDateGroupBox);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.ItemsGridView);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 770);
            this.panel1.TabIndex = 0;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(1083, 676);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrintBtn.Size = new System.Drawing.Size(304, 85);
            this.PrintBtn.TabIndex = 44;
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.AllowUserToOrderColumns = true;
            this.ItemsGridView.AllowUserToResizeColumns = false;
            this.ItemsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.ItemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ItemsGridView.GridColor = System.Drawing.Color.White;
            this.ItemsGridView.Location = new System.Drawing.Point(3, 3);
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ItemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(1073, 708);
            this.ItemsGridView.TabIndex = 23;
            // 
            // FilterOrdersByDateGroupBox
            // 
            this.FilterOrdersByDateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterOrdersByDateGroupBox.Controls.Add(this.SuperiorDateTimePicker);
            this.FilterOrdersByDateGroupBox.Controls.Add(this.InferiorDateTimePicker);
            this.FilterOrdersByDateGroupBox.Controls.Add(this.label14);
            this.FilterOrdersByDateGroupBox.Controls.Add(this.label13);
            this.FilterOrdersByDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterOrdersByDateGroupBox.ForeColor = System.Drawing.Color.White;
            this.FilterOrdersByDateGroupBox.Location = new System.Drawing.Point(1083, 3);
            this.FilterOrdersByDateGroupBox.Name = "FilterOrdersByDateGroupBox";
            this.FilterOrdersByDateGroupBox.Size = new System.Drawing.Size(303, 136);
            this.FilterOrdersByDateGroupBox.TabIndex = 46;
            this.FilterOrdersByDateGroupBox.TabStop = false;
            this.FilterOrdersByDateGroupBox.Text = "Filter Supply Orders By Date";
            // 
            // SuperiorDateTimePicker
            // 
            this.SuperiorDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SuperiorDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperiorDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SuperiorDateTimePicker.Location = new System.Drawing.Point(11, 98);
            this.SuperiorDateTimePicker.Name = "SuperiorDateTimePicker";
            this.SuperiorDateTimePicker.Size = new System.Drawing.Size(285, 27);
            this.SuperiorDateTimePicker.TabIndex = 31;
            this.SuperiorDateTimePicker.ValueChanged += new System.EventHandler(this.SuperiorDateTimePicker_ValueChanged);
            // 
            // InferiorDateTimePicker
            // 
            this.InferiorDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InferiorDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InferiorDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InferiorDateTimePicker.Location = new System.Drawing.Point(11, 45);
            this.InferiorDateTimePicker.Name = "InferiorDateTimePicker";
            this.InferiorDateTimePicker.Size = new System.Drawing.Size(285, 27);
            this.InferiorDateTimePicker.TabIndex = 25;
            this.InferiorDateTimePicker.ValueChanged += new System.EventHandler(this.InferiorDateTimePicker_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 75);
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
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "START DATE";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TotalOrdersLbl);
            this.panel2.Location = new System.Drawing.Point(3, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 51);
            this.panel2.TabIndex = 47;
            // 
            // TotalOrdersLbl
            // 
            this.TotalOrdersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalOrdersLbl.AutoSize = true;
            this.TotalOrdersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TotalOrdersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TotalOrdersLbl.Location = new System.Drawing.Point(108, 10);
            this.TotalOrdersLbl.Name = "TotalOrdersLbl";
            this.TotalOrdersLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalOrdersLbl.Size = new System.Drawing.Size(54, 25);
            this.TotalOrdersLbl.TabIndex = 48;
            this.TotalOrdersLbl.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "TOTAL  : ";
            // 
            // ItemsToReorderGroupBox
            // 
            this.ItemsToReorderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsToReorderGroupBox.Controls.Add(this.PrintPreviewItemsToReorder);
            this.ItemsToReorderGroupBox.Controls.Add(this.ReOrderListBtn);
            this.ItemsToReorderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsToReorderGroupBox.ForeColor = System.Drawing.Color.White;
            this.ItemsToReorderGroupBox.Location = new System.Drawing.Point(1083, 145);
            this.ItemsToReorderGroupBox.Name = "ItemsToReorderGroupBox";
            this.ItemsToReorderGroupBox.Size = new System.Drawing.Size(303, 105);
            this.ItemsToReorderGroupBox.TabIndex = 48;
            this.ItemsToReorderGroupBox.TabStop = false;
            this.ItemsToReorderGroupBox.Text = "items To Reorder";
            // 
            // PrintPreviewItemsToReorder
            // 
            this.PrintPreviewItemsToReorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintPreviewItemsToReorder.BackColor = System.Drawing.Color.Navy;
            this.PrintPreviewItemsToReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewItemsToReorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewItemsToReorder.ForeColor = System.Drawing.Color.White;
            this.PrintPreviewItemsToReorder.Image = ((System.Drawing.Image)(resources.GetObject("PrintPreviewItemsToReorder.Image")));
            this.PrintPreviewItemsToReorder.Location = new System.Drawing.Point(155, 24);
            this.PrintPreviewItemsToReorder.Name = "PrintPreviewItemsToReorder";
            this.PrintPreviewItemsToReorder.Size = new System.Drawing.Size(142, 75);
            this.PrintPreviewItemsToReorder.TabIndex = 28;
            this.PrintPreviewItemsToReorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintPreviewItemsToReorder.UseVisualStyleBackColor = false;
            // 
            // ReOrderListBtn
            // 
            this.ReOrderListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReOrderListBtn.BackColor = System.Drawing.Color.Navy;
            this.ReOrderListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReOrderListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReOrderListBtn.ForeColor = System.Drawing.Color.White;
            this.ReOrderListBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReOrderListBtn.Image")));
            this.ReOrderListBtn.Location = new System.Drawing.Point(6, 24);
            this.ReOrderListBtn.Name = "ReOrderListBtn";
            this.ReOrderListBtn.Size = new System.Drawing.Size(143, 75);
            this.ReOrderListBtn.TabIndex = 28;
            this.ReOrderListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReOrderListBtn.UseVisualStyleBackColor = false;
            this.ReOrderListBtn.Click += new System.EventHandler(this.ReOrderListBtn_Click);
            // 
            // InactiveItemsGroupBox
            // 
            this.InactiveItemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InactiveItemsGroupBox.Controls.Add(this.button7);
            this.InactiveItemsGroupBox.Controls.Add(this.InactiveItemsListBtn);
            this.InactiveItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveItemsGroupBox.ForeColor = System.Drawing.Color.White;
            this.InactiveItemsGroupBox.Location = new System.Drawing.Point(1083, 256);
            this.InactiveItemsGroupBox.Name = "InactiveItemsGroupBox";
            this.InactiveItemsGroupBox.Size = new System.Drawing.Size(303, 104);
            this.InactiveItemsGroupBox.TabIndex = 49;
            this.InactiveItemsGroupBox.TabStop = false;
            this.InactiveItemsGroupBox.Text = "Inactive items";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(154, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 74);
            this.button7.TabIndex = 29;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // InactiveItemsListBtn
            // 
            this.InactiveItemsListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InactiveItemsListBtn.BackColor = System.Drawing.Color.Navy;
            this.InactiveItemsListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InactiveItemsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveItemsListBtn.ForeColor = System.Drawing.Color.White;
            this.InactiveItemsListBtn.Image = ((System.Drawing.Image)(resources.GetObject("InactiveItemsListBtn.Image")));
            this.InactiveItemsListBtn.Location = new System.Drawing.Point(6, 24);
            this.InactiveItemsListBtn.Name = "InactiveItemsListBtn";
            this.InactiveItemsListBtn.Size = new System.Drawing.Size(142, 74);
            this.InactiveItemsListBtn.TabIndex = 29;
            this.InactiveItemsListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InactiveItemsListBtn.UseVisualStyleBackColor = false;
            this.InactiveItemsListBtn.Click += new System.EventHandler(this.InactiveItemsListBtn_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroupBox.Controls.Add(this.PrintPreviewReportOrder);
            this.SearchGroupBox.Controls.Add(this.SearchOrderNumber);
            this.SearchGroupBox.Controls.Add(this.label6);
            this.SearchGroupBox.Controls.Add(this.SearchOrderNumberTxt);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.SearchGroupBox.Location = new System.Drawing.Point(1083, 366);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(304, 145);
            this.SearchGroupBox.TabIndex = 50;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // PrintPreviewReportOrder
            // 
            this.PrintPreviewReportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintPreviewReportOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewReportOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewReportOrder.Image = ((System.Drawing.Image)(resources.GetObject("PrintPreviewReportOrder.Image")));
            this.PrintPreviewReportOrder.Location = new System.Drawing.Point(162, 73);
            this.PrintPreviewReportOrder.Name = "PrintPreviewReportOrder";
            this.PrintPreviewReportOrder.Size = new System.Drawing.Size(137, 66);
            this.PrintPreviewReportOrder.TabIndex = 27;
            this.PrintPreviewReportOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintPreviewReportOrder.UseVisualStyleBackColor = true;
            // 
            // SearchOrderNumber
            // 
            this.SearchOrderNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrderNumber.Image = ((System.Drawing.Image)(resources.GetObject("SearchOrderNumber.Image")));
            this.SearchOrderNumber.Location = new System.Drawing.Point(8, 74);
            this.SearchOrderNumber.Name = "SearchOrderNumber";
            this.SearchOrderNumber.Size = new System.Drawing.Size(150, 66);
            this.SearchOrderNumber.TabIndex = 20;
            this.SearchOrderNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchOrderNumber.UseVisualStyleBackColor = true;
            this.SearchOrderNumber.Click += new System.EventHandler(this.SearchOrderNumber_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "ORDER NUMBER";
            // 
            // SearchOrderNumberTxt
            // 
            this.SearchOrderNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrderNumberTxt.Location = new System.Drawing.Point(9, 41);
            this.SearchOrderNumberTxt.Name = "SearchOrderNumberTxt";
            this.SearchOrderNumberTxt.Size = new System.Drawing.Size(288, 27);
            this.SearchOrderNumberTxt.TabIndex = 25;
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
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 795);
            this.Controls.Add(this.panel1);
            this.Name = "ReportFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.FilterOrdersByDateGroupBox.ResumeLayout(false);
            this.FilterOrdersByDateGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ItemsToReorderGroupBox.ResumeLayout(false);
            this.InactiveItemsGroupBox.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.GroupBox FilterOrdersByDateGroupBox;
        private System.Windows.Forms.DateTimePicker SuperiorDateTimePicker;
        private System.Windows.Forms.DateTimePicker InferiorDateTimePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalOrdersLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ItemsToReorderGroupBox;
        private System.Windows.Forms.Button PrintPreviewItemsToReorder;
        private System.Windows.Forms.Button ReOrderListBtn;
        private System.Windows.Forms.GroupBox InactiveItemsGroupBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button InactiveItemsListBtn;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button PrintPreviewReportOrder;
        private System.Windows.Forms.Button SearchOrderNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchOrderNumberTxt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOrder;
        private System.Drawing.Printing.PrintDocument printOrderDocument;
        private System.Drawing.Printing.PrintDocument printItemsToReorderDocument;
        private System.Drawing.Printing.PrintDocument printInactiveItemsDocument;
    }
}