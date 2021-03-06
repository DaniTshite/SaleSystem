using DataLibrary.Data;
using DataLibrary.Models;
using LogicLibrary.HelperProcesses;
using LogicLibrary.Processes;
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
    public partial class CustomerAccountFrm : Form
    {
        CustomerAccountProcessor _customerAccountProcessor;
        List<CustomerAccount> customerAccounts;
        public CustomerAccountFrm()
        {
            InitializeComponent();
            Initialize();
        }
        //This method initialises controls,instantiate lists,etc
        private void Initialize()
        {
            _customerAccountProcessor = new CustomerAccountProcessor();
            CustomerAccountsGridView.DataSource = null;
            customerAccounts = _customerAccountProcessor.GetCustomerAccounts();
            CustomerAccountsGridView.DataSource = customerAccounts;
            CustomerAccountsGridView.Columns[0].Visible = false;
            //CustomerAccountsGridView.Columns[7].Visible = false;
            CustomerAccountsGridView.Columns[8].Visible = false;
        }
        //This method saves the data if it is valid
        private void SaveCustomerAccountBtn_Click(object sender, EventArgs e)
        {
            if(IsValid()){
                CustomerAccount p = new CustomerAccount
                {
                    FirstName=FirstNameTxt.Text,
                    LastName=LastNameTxt.Text,
                    IdNumber=IdNumberTxt.Text,
                    CellPhone=CellphoneTxt.Text,
                    EmailAddress=EmailAddressTxt.Text,
                    PhysicalAddress=PhysicalAddressTxt.Text,
                    Gender=GenderCmb.Text
                };
                MessageBox.Show(_customerAccountProcessor.SaveCustomerAccount(p), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Initialize();
                Reset();
            }
        }
        //This method clears all textboxes and combobox
        private void Reset()
        {
            FirstNameTxt.Clear();
            FirstNameTxt.Focus();
            LastNameTxt.Clear();
            IdNumberTxt.Clear();
            CellphoneTxt.Clear();
            EmailAddressTxt.Clear();
            PhysicalAddressTxt.Clear();
            GenderCmb.Text = "";
        }
        //This method validate input data
        private bool IsValid()
        {
            if (FirstNameTxt.Text == string.Empty)
            {
                MessageBox.Show("The FirstName is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTxt.Focus();
                return false;
            }
            if (LastNameTxt.Text == string.Empty)
            {
                MessageBox.Show("The LastName is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTxt.Focus();
                return false;
            }
            if (IdNumberTxt.Text == string.Empty)
            {
                MessageBox.Show("The ID Number is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdNumberTxt.Focus();
                return false;
            }
            if (CellphoneTxt.Text == string.Empty)
            {
                MessageBox.Show("The Phone number is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CellphoneTxt.Focus();
                return false;
            }
            if (EmailAddressTxt.Text == string.Empty)
            {
                MessageBox.Show("The Email Address is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailAddressTxt.Focus();
                return false;
            }
            else
            {
                if (!(HelperProcessor.IsEmailValid(EmailAddressTxt.Text)))
                {
                    MessageBox.Show("Invalid Email Address !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailAddressTxt.Focus();
                    return false;
                }

            }
            if (PhysicalAddressTxt.Text == string.Empty)
            {
                MessageBox.Show("The Physical Address is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhysicalAddressTxt.Focus();
                return false;
            }
            if (GenderCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the gender !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenderCmb.Focus();
                return false;
            }
            return true;
        }
    }
}
