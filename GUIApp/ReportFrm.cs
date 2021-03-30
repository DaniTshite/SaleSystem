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
    public partial class ReportFrm : Form
    {
        readonly IOrdersProcessor _ordersProcessor = ContainerConfig.CreateOrdersProcessor();
        List<Item> items;
        List<OrderLine> orderDetails;
        IItemProcessor _itemProcessor;
        public ReportFrm()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            ItemsGridView.DataSource = null;
            _itemProcessor = ContainerConfig.CreateItemProcessor();
            items = new List<Item>();
            items = _itemProcessor.GetItems();
            orderDetails = new List<OrderLine>();
        }
        private void InferiorDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int counter = 1;
            DateTime date1 = InferiorDateTimePicker.Value;
            DateTime date2 = SuperiorDateTimePicker.Value;
            if (date1 > date2)
            {
                MessageBox.Show("Start date cannot be ulterior to End date !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ItemsGridView.DataSource = null;
            }
            else
            {
                double totalOrders = 0;
                List<Orders> listOrders = OrdersProcessor.GetFilteredOrdersByDate(date1, date2);
                List<OrdersByMonth> ordersToDisplay = new List<OrdersByMonth>();
                if (listOrders.Count == 0)
                {
                    MessageBox.Show("No Order throughout this period !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ItemsGridView.DataSource = null;
                }
                else
                {
                    foreach (var item in listOrders)
                    {
                        OrdersByMonth p = new OrdersByMonth
                        {
                            Counter = counter,
                            OrderNumber = item.OrderNumber,
                            OrderDate = item.OrderDate.Date,
                            Total = Convert.ToDouble(item.Total),
                            SupplierName = item.SelectedSupplier.SupplierName,
                            SupplierTelephone = item.SelectedSupplier.SupplierTelephone
                        };
                        counter += 1;
                        ordersToDisplay.Add(p);
                    }
                    totalOrders = ordersToDisplay.Sum(x => x.Total);
                    //TotalOrdersLbl.Text = "R " + totalOrders.ToString();
                    TotalOrdersLbl.Text = string.Format("{0:c2}", totalOrders);
                    ItemsGridView.DataSource = null;
                    ItemsGridView.DataSource = ordersToDisplay;
                }
            }
        }

        private void SuperiorDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int counter = 1;
            DateTime date1 = InferiorDateTimePicker.Value;
            DateTime date2 = SuperiorDateTimePicker.Value;
            if (date1 > date2)
            {
                MessageBox.Show("Start date cannot be ulterior to End date !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ItemsGridView.DataSource = null;
            }
            else
            {
                double totalOrders = 0;
                List<Orders> listOrders = OrdersProcessor.GetFilteredOrdersByDate(date1, date2);
                List<OrdersByMonth> ordersToDisplay = new List<OrdersByMonth>();
                if (listOrders.Count == 0)
                {
                    MessageBox.Show("No Order throughout this period !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ItemsGridView.DataSource = null;
                }
                else
                {
                    foreach (var item in listOrders)
                    {
                        OrdersByMonth p = new OrdersByMonth
                        {
                            Counter = counter,
                            OrderNumber = item.OrderNumber,
                            OrderDate = item.OrderDate.Date,
                            Total = Convert.ToDouble(item.Total),
                            SupplierName = item.SelectedSupplier.SupplierName,
                            SupplierTelephone = item.SelectedSupplier.SupplierTelephone
                        };
                        counter += 1;
                        ordersToDisplay.Add(p);
                    }
                    totalOrders = ordersToDisplay.Sum(x => x.Total);
                    TotalOrdersLbl.Text = string.Format("{0:c2}", totalOrders);
                    ItemsGridView.DataSource = null;
                    ItemsGridView.DataSource = ordersToDisplay;
                }
            }
        }

        private void ReOrderListBtn_Click(object sender, EventArgs e)
        {
            Initialize();
            ItemsGridView.DataSource = null;
            var p = _ordersProcessor.GetItemsToReorder(items);
            if (p.Count == 0)
            {
                MessageBox.Show("There are no items to Reorder !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int counter = 1;
                List<ItemsReport> itemsReOrder = new List<ItemsReport>();
                foreach (var item in p)
                {
                    ItemsReport ReOrder = new ItemsReport
                    {
                        Id = counter,
                        StockCode = item.SelectedItem.StockCode,
                        Descript = item.SelectedItem.Descript,
                        PurchasedQuantity = item.PurchasedQuantity,
                        ReOrderLevel = item.SelectedItem.ReOrderlevel
                    };
                    counter += 1;
                    itemsReOrder.Add(ReOrder);
                }
                ItemsGridView.DataSource = itemsReOrder;
            }

        }

        private void InactiveItemsListBtn_Click(object sender, EventArgs e)
        {
            Initialize();
            var p = _ordersProcessor.GetInactiveItems(items);
            ItemsGridView.DataSource = null;
            if (p.Count == 0)
            {
                MessageBox.Show("There are no inactive items !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int counter = 1;
                List<ItemsReport> itemsReport = new List<ItemsReport>();
                foreach (var item in p)
                {
                    ItemsReport Report = new ItemsReport
                    {
                        Id = counter,
                        StockCode = item.SelectedItem.StockCode,
                        Descript = item.SelectedItem.Descript,
                        PurchasedQuantity = item.PurchasedQuantity,
                        ReOrderLevel = item.SelectedItem.ReOrderlevel
                    };
                    counter += 1;
                    itemsReport.Add(Report);
                }
                ItemsGridView.DataSource = itemsReport;
            }
        }

        private void SearchOrderNumber_Click(object sender, EventArgs e)
        {
            ItemsGridView.DataSource = null;
            if (SearchOrderNumberTxt.Text == string.Empty)
            {
                MessageBox.Show("The OrderNumber is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SearchOrderNumberTxt.Focus();
            }
            else
            {
                orderDetails = _ordersProcessor.GetOrderDetails(SearchOrderNumberTxt.Text);
                if (orderDetails.Count == 0 || orderDetails == null)
                {
                    MessageBox.Show(" Order Number  " + SearchOrderNumberTxt.Text + "  does not exist in the System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SearchOrderNumberTxt.Clear();
                    SearchOrderNumberTxt.Focus();
                }
                else
                {
                    List<OrderCart> OrderReportToDisplay = new List<OrderCart>();

                    int lineCounter = 1;

                    foreach (var order in orderDetails)
                    {

                        //order.Id = lineCounter;
                        OrderCart shoppingCartLine = new OrderCart
                        {
                            Id = lineCounter,
                            StockCode = order.SelectedItem.StockCode,
                            Descript = order.SelectedItem.Descript,
                            PurchasedQuantity = order.PurchasedQuantity,
                            PurchasePrice = order.PurchasePrice,
                            LineTotal = order.LineTotal
                        };
                        OrderReportToDisplay.Add(shoppingCartLine);
                        lineCounter += 1;
                    }
                    ItemsGridView.DataSource = null;
                    ItemsGridView.DataSource = OrderReportToDisplay;
                    //hide 2 columns(ItemId,OrderNumber) in the grid

                    ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
                    ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";
                    //STotalTxt.Text = orderDetails[0].Order.SubTotal.ToString();
                    //TaxTxt.Text = orderDetails[0].Order.Tax.ToString();
                    TotalOrdersLbl.Text = string.Format("{0:c2}", orderDetails[0].Order.Total);
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            List<OrderLine> itemsToReorder = _ordersProcessor.GetItemsToReorder(items);
            if (itemsToReorder.Count > 0)
            {
                printPreviewDialogOrder.Document = printItemsToReorderDocument;
                printPreviewDialogOrder.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no items to Reorder !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}