
namespace GUIApp
{
    partial class ItemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.FilterGhroupBox = new System.Windows.Forms.GroupBox();
            this.PrintPreviewBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FilterBycategoryTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterByStockCodeTxt = new System.Windows.Forms.TextBox();
            this.SaveItemBtn = new System.Windows.Forms.Button();
            this.ReorderLevelTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TaxTxt = new System.Windows.Forms.TextBox();
            this.IsActiveChkBtn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListCategoryCmb = new System.Windows.Forms.ComboBox();
            this.DescriptTxt = new System.Windows.Forms.TextBox();
            this.StockCodeTxt = new System.Windows.Forms.TextBox();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveCategoryBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UpdateIsActiveBtn = new System.Windows.Forms.Button();
            this.UpdateItemStatusChk = new System.Windows.Forms.CheckBox();
            this.UpdateItemCmb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.FilterGhroupBox.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ItemsGridView);
            this.groupBox1.Controls.Add(this.FilterGhroupBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 805);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.AllowUserToResizeColumns = false;
            this.ItemsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsGridView.GridColor = System.Drawing.Color.White;
            this.ItemsGridView.Location = new System.Drawing.Point(6, 15);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.ItemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(1117, 782);
            this.ItemsGridView.TabIndex = 11;
            // 
            // FilterGhroupBox
            // 
            this.FilterGhroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterGhroupBox.Controls.Add(this.PrintPreviewBtn);
            this.FilterGhroupBox.Controls.Add(this.label8);
            this.FilterGhroupBox.Controls.Add(this.FilterBycategoryTxt);
            this.FilterGhroupBox.Controls.Add(this.label5);
            this.FilterGhroupBox.Controls.Add(this.FilterByStockCodeTxt);
            this.FilterGhroupBox.Location = new System.Drawing.Point(720, 809);
            this.FilterGhroupBox.Name = "FilterGhroupBox";
            this.FilterGhroupBox.Size = new System.Drawing.Size(385, 245);
            this.FilterGhroupBox.TabIndex = 11;
            this.FilterGhroupBox.TabStop = false;
            this.FilterGhroupBox.Text = "Filter";
            // 
            // PrintPreviewBtn
            // 
            this.PrintPreviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPreviewBtn.BackColor = System.Drawing.Color.Navy;
            this.PrintPreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintPreviewBtn.Location = new System.Drawing.Point(27, 160);
            this.PrintPreviewBtn.Name = "PrintPreviewBtn";
            this.PrintPreviewBtn.Size = new System.Drawing.Size(336, 46);
            this.PrintPreviewBtn.TabIndex = 15;
            this.PrintPreviewBtn.Text = "PRINT PREVIEW";
            this.PrintPreviewBtn.UseVisualStyleBackColor = false;
            this.PrintPreviewBtn.Click += new System.EventHandler(this.PrintPreviewBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "CATEGORY";
            // 
            // FilterBycategoryTxt
            // 
            this.FilterBycategoryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBycategoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBycategoryTxt.Location = new System.Drawing.Point(27, 113);
            this.FilterBycategoryTxt.Name = "FilterBycategoryTxt";
            this.FilterBycategoryTxt.Size = new System.Drawing.Size(336, 27);
            this.FilterBycategoryTxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "STOCK CODE";
            // 
            // FilterByStockCodeTxt
            // 
            this.FilterByStockCodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterByStockCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterByStockCodeTxt.Location = new System.Drawing.Point(27, 40);
            this.FilterByStockCodeTxt.Name = "FilterByStockCodeTxt";
            this.FilterByStockCodeTxt.Size = new System.Drawing.Size(336, 27);
            this.FilterByStockCodeTxt.TabIndex = 13;
            this.FilterByStockCodeTxt.TextChanged += new System.EventHandler(this.FilterByStockCodeTxt_TextChanged);
            // 
            // SaveItemBtn
            // 
            this.SaveItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveItemBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveItemBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveItemBtn.Image")));
            this.SaveItemBtn.Location = new System.Drawing.Point(212, 369);
            this.SaveItemBtn.Name = "SaveItemBtn";
            this.SaveItemBtn.Size = new System.Drawing.Size(130, 90);
            this.SaveItemBtn.TabIndex = 6;
            this.SaveItemBtn.UseVisualStyleBackColor = false;
            this.SaveItemBtn.Click += new System.EventHandler(this.SaveItemBtn_Click);
            // 
            // ReorderLevelTxt
            // 
            this.ReorderLevelTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReorderLevelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderLevelTxt.Location = new System.Drawing.Point(15, 276);
            this.ReorderLevelTxt.Name = "ReorderLevelTxt";
            this.ReorderLevelTxt.Size = new System.Drawing.Size(327, 27);
            this.ReorderLevelTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "REORDER LEVEL";
            // 
            // TaxTxt
            // 
            this.TaxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxt.Location = new System.Drawing.Point(10, 212);
            this.TaxTxt.Name = "TaxTxt";
            this.TaxTxt.Size = new System.Drawing.Size(332, 27);
            this.TaxTxt.TabIndex = 9;
            // 
            // IsActiveChkBtn
            // 
            this.IsActiveChkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IsActiveChkBtn.AutoSize = true;
            this.IsActiveChkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveChkBtn.ForeColor = System.Drawing.Color.White;
            this.IsActiveChkBtn.Location = new System.Drawing.Point(255, 91);
            this.IsActiveChkBtn.Name = "IsActiveChkBtn";
            this.IsActiveChkBtn.Size = new System.Drawing.Size(87, 22);
            this.IsActiveChkBtn.TabIndex = 3;
            this.IsActiveChkBtn.Text = "ACTIVE";
            this.IsActiveChkBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "CATEGORY";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "TAX";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCRIPTION";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "STOCK CODE";
            // 
            // ListCategoryCmb
            // 
            this.ListCategoryCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCategoryCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCategoryCmb.FormattingEnabled = true;
            this.ListCategoryCmb.Location = new System.Drawing.Point(15, 335);
            this.ListCategoryCmb.Name = "ListCategoryCmb";
            this.ListCategoryCmb.Size = new System.Drawing.Size(327, 28);
            this.ListCategoryCmb.TabIndex = 5;
            // 
            // DescriptTxt
            // 
            this.DescriptTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptTxt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.DescriptTxt.Location = new System.Drawing.Point(15, 91);
            this.DescriptTxt.Multiline = true;
            this.DescriptTxt.Name = "DescriptTxt";
            this.DescriptTxt.Size = new System.Drawing.Size(213, 84);
            this.DescriptTxt.TabIndex = 2;
            // 
            // StockCodeTxt
            // 
            this.StockCodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StockCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockCodeTxt.Location = new System.Drawing.Point(15, 27);
            this.StockCodeTxt.Name = "StockCodeTxt";
            this.StockCodeTxt.Size = new System.Drawing.Size(327, 27);
            this.StockCodeTxt.TabIndex = 1;
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryGroupBox.Controls.Add(this.SaveCategoryBtn);
            this.CategoryGroupBox.Controls.Add(this.label7);
            this.CategoryGroupBox.Controls.Add(this.CategoryNameTxt);
            this.CategoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryGroupBox.ForeColor = System.Drawing.Color.White;
            this.CategoryGroupBox.Location = new System.Drawing.Point(1147, 484);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(366, 160);
            this.CategoryGroupBox.TabIndex = 12;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "CATEGORY";
            // 
            // SaveCategoryBtn
            // 
            this.SaveCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCategoryBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCategoryBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveCategoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveCategoryBtn.Image")));
            this.SaveCategoryBtn.Location = new System.Drawing.Point(214, 79);
            this.SaveCategoryBtn.Name = "SaveCategoryBtn";
            this.SaveCategoryBtn.Size = new System.Drawing.Size(130, 75);
            this.SaveCategoryBtn.TabIndex = 9;
            this.SaveCategoryBtn.UseVisualStyleBackColor = false;
            this.SaveCategoryBtn.Click += new System.EventHandler(this.SaveCategoryBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "CATEGORY NAME";
            // 
            // CategoryNameTxt
            // 
            this.CategoryNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTxt.Location = new System.Drawing.Point(12, 46);
            this.CategoryNameTxt.Name = "CategoryNameTxt";
            this.CategoryNameTxt.Size = new System.Drawing.Size(332, 27);
            this.CategoryNameTxt.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.UpdateIsActiveBtn);
            this.groupBox3.Controls.Add(this.UpdateItemStatusChk);
            this.groupBox3.Controls.Add(this.UpdateItemCmb);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1147, 650);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 161);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACTIVE/DEACTIVATE ITEM";
            // 
            // UpdateIsActiveBtn
            // 
            this.UpdateIsActiveBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.UpdateIsActiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateIsActiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateIsActiveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateIsActiveBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateIsActiveBtn.Image")));
            this.UpdateIsActiveBtn.Location = new System.Drawing.Point(214, 55);
            this.UpdateIsActiveBtn.Name = "UpdateIsActiveBtn";
            this.UpdateIsActiveBtn.Size = new System.Drawing.Size(130, 98);
            this.UpdateIsActiveBtn.TabIndex = 3;
            this.UpdateIsActiveBtn.UseVisualStyleBackColor = false;
            this.UpdateIsActiveBtn.Click += new System.EventHandler(this.UpdateIsActiveBtn_Click);
            // 
            // UpdateItemStatusChk
            // 
            this.UpdateItemStatusChk.AutoSize = true;
            this.UpdateItemStatusChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemStatusChk.Location = new System.Drawing.Point(12, 55);
            this.UpdateItemStatusChk.Name = "UpdateItemStatusChk";
            this.UpdateItemStatusChk.Size = new System.Drawing.Size(87, 22);
            this.UpdateItemStatusChk.TabIndex = 2;
            this.UpdateItemStatusChk.Text = "ACTIVE";
            this.UpdateItemStatusChk.UseVisualStyleBackColor = true;
            // 
            // UpdateItemCmb
            // 
            this.UpdateItemCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateItemCmb.FormattingEnabled = true;
            this.UpdateItemCmb.Location = new System.Drawing.Point(12, 21);
            this.UpdateItemCmb.Name = "UpdateItemCmb";
            this.UpdateItemCmb.Size = new System.Drawing.Size(332, 28);
            this.UpdateItemCmb.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SaveItemBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ListCategoryCmb);
            this.panel1.Controls.Add(this.ReorderLevelTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.StockCodeTxt);
            this.panel1.Controls.Add(this.TaxTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IsActiveChkBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DescriptTxt);
            this.panel1.Location = new System.Drawing.Point(1147, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 466);
            this.panel1.TabIndex = 16;
            // 
            // ItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1525, 823);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CategoryGroupBox);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1249, 741);
            this.Name = "ItemFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEMS";
            this.Load += new System.EventHandler(this.ItemFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.FilterGhroupBox.ResumeLayout(false);
            this.FilterGhroupBox.PerformLayout();
            this.CategoryGroupBox.ResumeLayout(false);
            this.CategoryGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveItemBtn;
        private System.Windows.Forms.ComboBox ListCategoryCmb;
        private System.Windows.Forms.TextBox DescriptTxt;
        private System.Windows.Forms.TextBox StockCodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IsActiveChkBtn;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.GroupBox FilterGhroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FilterByStockCodeTxt;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.Button SaveCategoryBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CategoryNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FilterBycategoryTxt;
        private System.Windows.Forms.Button PrintPreviewBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button UpdateIsActiveBtn;
        private System.Windows.Forms.CheckBox UpdateItemStatusChk;
        private System.Windows.Forms.ComboBox UpdateItemCmb;
        private System.Windows.Forms.TextBox TaxTxt;
        private System.Windows.Forms.TextBox ReorderLevelTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}