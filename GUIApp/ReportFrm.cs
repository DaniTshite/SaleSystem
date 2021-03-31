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
        //print Order Document

        private int NumberOfItemsPage = 0;
        private int itemsPrintedSoFar = 0;

        //Item counter for Order Cart

        int itemCounter = 1;
        private decimal PurchasePrice;
        List<IOrderLine> itemsToSave;
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

        private void printOrderDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ////Image image = SalesProject.Properties.Resources.logo;
            ////e.Graphics.DrawImage(image,0,0,image.Width,image.Height);
            ///
            e.Graphics.DrawString("Page   " + ((itemsPrintedSoFar % 7) == 0 ? (itemsPrintedSoFar / 7) + 1 : (itemsPrintedSoFar / 7) + 2),
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString("Order Report", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date : " + orderDetails[0].Order.OrderDate.Date.ToLongDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString("Order Number :  " + orderDetails[0].Order.OrderNumber, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 410));
            e.Graphics.DrawString("*****************************************************************************************************************************************",
                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, 440));
            e.Graphics.DrawString(" No ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 460));
            e.Graphics.DrawString(" Designation ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(70, 460));
            e.Graphics.DrawString(" Unit Price ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(360, 460));
            e.Graphics.DrawString(" Quantity ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(470, 460));
            e.Graphics.DrawString(" Net Total  ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(630, 460));
            e.Graphics.DrawString("*****************************************************************************************************************************************",
                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, 490));
            int YPos = 490;

            for (int i = itemsPrintedSoFar; i < orderDetails.Count; i++)
            {
                NumberOfItemsPage++;
                if (NumberOfItemsPage <= 7)
                {
                    itemsPrintedSoFar++;

                    if (itemsPrintedSoFar <= orderDetails.Count)
                    {
                        //e.Graphics.DrawString(orderDetails[i].Id.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, YPos + 30));
                        e.Graphics.DrawString(orderDetails[i].SelectedItem.Descript, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(70, YPos + 30));
                        e.Graphics.DrawString(orderDetails[i].PurchasePrice.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(370, YPos + 30));
                        e.Graphics.DrawString(orderDetails[i].PurchasedQuantity.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(480, YPos + 30));
                        e.Graphics.DrawString(orderDetails[i].LineTotal.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(640, YPos + 30));
                        YPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    NumberOfItemsPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("*******************************************************************************************************************",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, YPos + 30));
            e.Graphics.DrawString(" Sub Total  (R) : " + orderDetails[0].Order.SubTotal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 60));
            e.Graphics.DrawString(" VAT    (R) : " + orderDetails[0].Order.Tax, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 90));
            e.Graphics.DrawString(" Grand Total (R) : " + orderDetails[0].Order.Total, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 120));
            e.Graphics.DrawString(" Supplied by : " + orderDetails[0].Order.SelectedSupplier.SupplierName, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 150));
            e.Graphics.DrawString(" " + orderDetails[0].Order.SelectedSupplier.SupplierTelephone, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, YPos + 180));
            e.Graphics.DrawString(" " + orderDetails[0].Order.SelectedSupplier.SupplierEmailAddress, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, YPos + 210));
            e.Graphics.DrawString(" " + orderDetails[0].Order.SelectedSupplier.SupplierPhysicalAddress, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, YPos + 240));
            NumberOfItemsPage = 0;
            itemsPrintedSoFar = 0;
        }

        private void PrintPreviewItemsToReorder_Click(object sender, EventArgs e)
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

        private void PrintPreviewReportOrder_Click(object sender, EventArgs e)
        {
            if (orderDetails.Count == 0 || orderDetails == null)
            {
                MessageBox.Show("The which order do you want to preview !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SearchOrderNumberTxt.Clear();
                SearchOrderNumberTxt.Focus();
            }
            else
            {
                printPreviewDialogOrder.Document = printOrderDocument;
                printPreviewDialogOrder.ShowDialog();
            }
        }

        private void printItemsToReorderDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<OrderLine> itemsToReorder = _ordersProcessor.GetItemsToReorder(items) as dynamic;
            //int s = itemsToReorder[0].Id;
            //int t = s;
            e.Graphics.DrawString("Page   " + ((itemsPrintedSoFar % 7) == 0 ? (itemsPrintedSoFar / 7) + 1 : (itemsPrintedSoFar / 7) + 2),
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString("List of items To Reorder", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToLongDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString("", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 410));
            e.Graphics.DrawString("*****************************************************************************************************************************************",
                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, 440));
            e.Graphics.DrawString(" No ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 460));
            e.Graphics.DrawString(" Stock Code ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(70, 460));
            e.Graphics.DrawString(" Designation ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(180, 460));
            e.Graphics.DrawString(" In Stock ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(480, 460));
            e.Graphics.DrawString(" ReorderLevel  ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(590, 460));
            //e.Graphics.DrawString(" Measure  ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(720, 460));
            e.Graphics.DrawString("*****************************************************************************************************************************************",
                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, 490));
            int YPos = 490;
            for (int i = itemsPrintedSoFar; i < itemsToReorder.Count; i++)
            {
                NumberOfItemsPage++;
                if (NumberOfItemsPage <= 7)
                {
                    itemsPrintedSoFar++;

                    if (itemsPrintedSoFar <= itemsToReorder.Count)
                    {
                        // e.Graphics.DrawString(itemsToReorder[i].Id.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, YPos + 30));
                        e.Graphics.DrawString(itemsToReorder[i].SelectedItem.StockCode, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(70, YPos + 30));
                        e.Graphics.DrawString(itemsToReorder[i].SelectedItem.Descript, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, YPos + 30));
                        e.Graphics.DrawString(itemsToReorder[i].PurchasedQuantity.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(480, YPos + 30));
                        e.Graphics.DrawString(itemsToReorder[i].SelectedItem.ReOrderlevel.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(590, YPos + 30));
                        // e.Graphics.DrawString(itemsToReorder[i].MeasureName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(720, YPos + 30));
                        YPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    NumberOfItemsPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("*******************************************************************************************************************",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, YPos + 30));

            NumberOfItemsPage = 0;
            itemsPrintedSoFar = 0;
        }
    }
}