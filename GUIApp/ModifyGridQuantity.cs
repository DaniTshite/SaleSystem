using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class ModifyGridQuantity : Form
    {
        public ModifyGridQuantity()
        {
            InitializeComponent();
        }
        public int CurrentQuantity { get; set; }
        public int NewQuantity { get; set; }
        private bool HasValidationFailed = false;
        private void ModifyGridQuantity_Load(object sender, EventArgs e)
        {
            NewQuantityTxt.Focus();
        }

        private void ModifyQuantityBtn_Click(object sender, EventArgs e)
        {

            if(IsQuantityValid())
            {
                NewQuantity = Int16.Parse(NewQuantityTxt.Text);
                HasValidationFailed = false;
            }
            

        }

        private bool IsQuantityValid()
        {
            if(NewQuantityTxt.Text==string.Empty)
            {
                MessageBox.Show("The Quantity is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewQuantityTxt.Focus();
                HasValidationFailed = true;
                return false;
                
            }
            else
            {
                int TempQty;
                bool number = int.TryParse(NewQuantityTxt.Text, out TempQty);
                if (!number)
                {
                    MessageBox.Show("Quantity must be a number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewQuantityTxt.Clear();
                    NewQuantityTxt.Focus();
                    HasValidationFailed = true;
                    return false;

                }
                if(TempQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewQuantityTxt.Clear();
                    NewQuantityTxt.Focus();
                    HasValidationFailed = true;
                    return false;
                }
            }
            return true;
        }

        private void ModifyGridQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = HasValidationFailed;
        }
    }
}
