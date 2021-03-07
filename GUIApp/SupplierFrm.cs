
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.Models;
using LogicLibrary;
using LogicLibrary.HelperProcesses;
using LogicLibrary.Processes;

namespace GUIApp
{
    public partial class SupplierFrm : Form
    {
        ISupplierProcessor _supplierProcessor;
        List<Supplier> Suppliers;
        public SupplierFrm()
        {
            InitializeComponent();
            Initialize();
        }
        //This method initialises comboboxes,instantiate objects ,etc
        private void Initialize()
        {
            _supplierProcessor = ContainerConfig.CreateSupplierProcessor();
            Suppliers = new List<Supplier>();
            Suppliers= _supplierProcessor.GetSuppliers();
            SuppliersGridView.DataSource = null;
            SuppliersGridView.DataSource = Suppliers;
            DeleteSupplierCmb.DataSource = Suppliers;
            DeleteSupplierCmb.DisplayMember = "SupplierName";
            DeleteSupplierCmb.ValueMember = "SupplierId";
            SuppliersGridView.Columns[0].Visible = false;
        }
        //This method saves a supplier data if it is valid
        private void SaveSupplierBtn_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                ISupplier supplier = ContainerConfig.CreateSupplier();
                supplier.SupplierName = SupplierNameTxt.Text;
                supplier.SupplierTelephone = SupplierTelephoneTxt.Text;
                supplier.SupplierEmailAddress = SupplierEmailAddressTxt.Text;
                supplier.SupplierPhysicalAddress = SupplierPhysicalAddressTxt.Text;
                
                //SupplierProcessor.SaveSupplier(supplier);
                MessageBox.Show(" 1 Record Has been added successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SupplierNameTxt.Clear();
                SupplierNameTxt.Focus();
                SupplierTelephoneTxt.Clear();
                SupplierEmailAddressTxt.Clear();
                SupplierPhysicalAddressTxt.Clear();
                Initialize();
            }

        }
        //This method validates input data
        private bool IsValid()
        {
            if(SupplierNameTxt.Text==string.Empty)
            {
                MessageBox.Show("The Name is Required","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                SupplierNameTxt.Focus();
                return false;
            }
            if (SupplierTelephoneTxt.Text == string.Empty)
            {
                MessageBox.Show("The Phone number is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SupplierTelephoneTxt.Focus();
                return false;
            }
            if (SupplierEmailAddressTxt.Text == string.Empty)
            {
                MessageBox.Show("The Email Address is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SupplierEmailAddressTxt.Focus();
                return false;
            }
            else
            {
                if(!( HelperProcessor.IsEmailValid(SupplierEmailAddressTxt.Text)))
                {
                    MessageBox.Show("Invalid Email Address !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SupplierEmailAddressTxt.Focus();
                    return false;
                }
                
            }
            if (SupplierPhysicalAddressTxt.Text == string.Empty)
            {
                MessageBox.Show("The Physical Address is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SupplierPhysicalAddressTxt.Focus();
                return false;
            }
            return true;
        }
        //This method places the focus on SupplierName textbox when the form is loading
        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            SupplierNameTxt.Focus();
        }
        //This method deletes the selected supplier
        private void DeleteSupplierBtn_Click(object sender, EventArgs e)
        {
            int supplierId = (Int32)DeleteSupplierCmb.SelectedValue;
            MessageBox.Show(_supplierProcessor.DeleteSupplier(supplierId), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Initialize();
        }
    }
}
