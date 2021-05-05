using DataLibrary.Models;
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
    
    public partial class MainFrm : Form
    {
        private Form activeForm;
        private Button currentButton;
        private readonly Random random;
        //private int tempIndex;
        public Users _loggedInUser;
        public MainFrm()
        {
            InitializeComponent();
            random = new Random();
            CloseChildFormBtn.Visible = false;
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.WindowState = FormWindowState.Maximized;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
           if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    CloseChildFormBtn.Visible = true;
                }
            }
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemFrm(), sender);

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsersForm(), sender);
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderFrm(), sender);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SaleFrm(this), sender);
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerAccountFrm(), sender);
        }

        private void Reset()
        {
            LblTitle.Text = "HOME";
            currentButton = null;
            CloseChildFormBtn.Visible = false;
        }

        private void CloseChildFormBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierFrm(), sender);
        }

        private void QuotationsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuotationFrm(), sender);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportFrm(), sender);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoggedInUserLbl.Text = LoggedInUserLbl.Text + " " + _loggedInUser.Name;
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeliveryFrm(), sender);
        }
    }
}
