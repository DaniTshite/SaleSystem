
namespace GUIApp
{
    partial class ModifyGridQuantity
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
            this.ModifyQuantityBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewQuantityTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModifyQuantityBtn
            // 
            this.ModifyQuantityBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ModifyQuantityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyQuantityBtn.Location = new System.Drawing.Point(148, 98);
            this.ModifyQuantityBtn.Name = "ModifyQuantityBtn";
            this.ModifyQuantityBtn.Size = new System.Drawing.Size(124, 41);
            this.ModifyQuantityBtn.TabIndex = 0;
            this.ModifyQuantityBtn.Text = "Modify";
            this.ModifyQuantityBtn.UseVisualStyleBackColor = true;
            this.ModifyQuantityBtn.Click += new System.EventHandler(this.ModifyQuantityBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // NewQuantityTxt
            // 
            this.NewQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuantityTxt.Location = new System.Drawing.Point(241, 46);
            this.NewQuantityTxt.Name = "NewQuantityTxt";
            this.NewQuantityTxt.Size = new System.Drawing.Size(166, 30);
            this.NewQuantityTxt.TabIndex = 2;
            // 
            // ModifyGridQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 184);
            this.Controls.Add(this.NewQuantityTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifyQuantityBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 231);
            this.Name = "ModifyGridQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Quantity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyGridQuantity_FormClosing);
            this.Load += new System.EventHandler(this.ModifyGridQuantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyQuantityBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewQuantityTxt;
    }
}