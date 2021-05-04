using DataLibrary.Models;
using GUIApp.Models;
using LogicLibrary;
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
    public partial class DeliveryFrm : Form
    {
        
        ISalesProcessor _salesProcessor;
        IDeliveryProcessor _deliveryProcessor;
        List<Sales> nonDeliveredSales;
        List<Delivery> deliveries;
        public DeliveryFrm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            InvoicesListBox.SelectedValueChanged -= InvoicesListBox_SelectedValueChanged;
            _salesProcessor = ContainerConfig.CreateSalesProcessor();
            _deliveryProcessor = ContainerConfig.CreateDeliveryProcessor();
            nonDeliveredSales = new List<Sales>();
            deliveries = new List<Delivery>();
            nonDeliveredSales = _salesProcessor.GetNonDeliveredOrders();
            deliveries = _deliveryProcessor.GetDeliveries();
            InvoicesListBox.DataSource = nonDeliveredSales;
            DeliveryGridView.DataSource = deliveries;
            DeliveryGridView.Columns[0].Visible = false;
            InvoicesListBox.DisplayMember = "InvoiceNumber";
            InvoicesListBox.ValueMember = "InvoiceNumber";
            HighlightSaleOrdersToDeliver();
            InvoicesListBox.SelectedValueChanged += InvoicesListBox_SelectedValueChanged;
        }

        private void HighlightSaleOrdersToDeliver()
        {
           
            if (DeliveryGridView.DataSource != null)
            {
                if (DeliveryGridView.Rows.Count > 0)
                {

                    foreach (DataGridViewRow row in DeliveryGridView.Rows)
                    {
                        if (int.Parse(row.Cells["DeliveryStatus"].Value.ToString()) == 1)
                        {
                            row.DefaultCellStyle.BackColor = Color.Coral;
                        }
                    }
                }
            }

            
        }

        private void InvoicesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<SaleLine> saleDetails = _salesProcessor.GetSaleDetails(((Sales)InvoicesListBox.SelectedItem).InvoiceNumber.ToString());
            List<OrderCart> itemsToDisplay = new List<OrderCart>();
            DeliveryNumberLbl.Text = ((Sales)InvoicesListBox.SelectedItem).InvoiceNumber.ToString();
            DeliveryDateTimePicker.Text = deliveries.Find(x => x.SaleId == ((Sales)InvoicesListBox.SelectedItem).SaleId).DeliveryDate.ToShortDateString();
            SaleDateLbl.Text=((Sales)InvoicesListBox.SelectedItem).SaleDate.ToShortDateString().ToString();
            int maxQuantity=0,lineCounter = 1;

            foreach (var sale in saleDetails)
            {
                OrderCart shoppingCartLine = new OrderCart
                {
                    Id = lineCounter,
                    StockCode = sale.SelectedItem.StockCode,
                    Descript = sale.SelectedItem.Descript,
                    PurchasedQuantity = sale.SaleQuantity,
                };
                itemsToDisplay.Add(shoppingCartLine);
                lineCounter += 1;
                maxQuantity += sale.SaleQuantity;
            }
            TotalItemsLbl.Text = maxQuantity + " ITEMS";
            ItemsGridView.DataSource = null;
            ItemsGridView.DataSource = itemsToDisplay;
            ItemsGridView.Columns[4].Visible = false;
            ItemsGridView.Columns[5].Visible = false;
        }

        private void DeliveryFrm_Load(object sender, EventArgs e)
        {
            HighlightSaleOrdersToDeliver();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _deliveryProcessor.UpdateDelivery(((Sales)InvoicesListBox.SelectedItem).SaleId);
            MessageBox.Show("Invoice "+ ((Sales)InvoicesListBox.SelectedItem).InvoiceNumber + " has been been successfully updated","Notification",MessageBoxButtons.OK);
            Initialize();
        }
    }
}
