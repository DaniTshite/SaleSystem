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
            nonDeliveredSales = _salesProcessor.GetNonDeliveredOrders();
            InvoicesListBox.DataSource = nonDeliveredSales;
            InvoicesListBox.DisplayMember = "InvoiceNumber";
            InvoicesListBox.ValueMember = "InvoiceNumber";
            InvoicesListBox.SelectedValueChanged += InvoicesListBox_SelectedValueChanged;
        }

        private void InvoicesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<SaleLine> saleDetails = _salesProcessor.GetSaleDetails(((Sales)InvoicesListBox.SelectedItem).InvoiceNumber.ToString());
            List<OrderCart> itemsToDisplay = new List<OrderCart>();
            DeliveryNumberLbl.Text = ((Sales)InvoicesListBox.SelectedItem).InvoiceNumber.ToString();
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
    }
}
