
namespace GUIApp
{
    partial class WaitProcessForm
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
            this.ProcessingProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProcessingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcessingProgressBar
            // 
            this.ProcessingProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessingProgressBar.Location = new System.Drawing.Point(108, 61);
            this.ProcessingProgressBar.Name = "ProcessingProgressBar";
            this.ProcessingProgressBar.Size = new System.Drawing.Size(241, 23);
            this.ProcessingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProcessingProgressBar.TabIndex = 0;
            // 
            // ProcessingLbl
            // 
            this.ProcessingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessingLbl.AutoSize = true;
            this.ProcessingLbl.Location = new System.Drawing.Point(105, 41);
            this.ProcessingLbl.Name = "ProcessingLbl";
            this.ProcessingLbl.Size = new System.Drawing.Size(90, 17);
            this.ProcessingLbl.TabIndex = 1;
            this.ProcessingLbl.Text = "Processing...";
            // 
            // WaitProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 144);
            this.Controls.Add(this.ProcessingLbl);
            this.Controls.Add(this.ProcessingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProcessingProgressBar;
        private System.Windows.Forms.Label ProcessingLbl;
    }
}