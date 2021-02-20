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
using DataLibrary.Data;
using LogicLibrary.Processes;
using GUIApp.Models;

namespace GUIApp
{
    public partial class OrderFrm : Form
    {
        //Lists used for 2 comboboxes and OrderLineCart 

        List<Item> items = new List<Item>();
        List<Item> activeItems = new List<Item>();
        List<Supplier> suppliers = new List<Supplier>();

        List<OrderLine> gridItems;
        List<OrderCart> gridOrderItems;

        //print Order Document

        private int NumberOfItemsPage = 0;
        private int itemsPrintedSoFar = 0;

        //Item counter for Order Cart

        int itemCounter = 1;
        List<OrderLine> orderDetails1;


        public OrderFrm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            ListItemsCmb.SelectedValueChanged -= ListItemsCmb_SelectedValueChanged;
            items = null;
            suppliers = null;
            activeItems = null;
            SqlDataAccess.MultipleSets();
            items = SqlDataAccess.loadedItems;
            suppliers = SqlDataAccess.loadedSuppliers;
            activeItems = ItemProcessor.LoadData();
            ListItemsCmb.DataSource = activeItems;
            ListSuppliersCmb.DataSource = suppliers;
            ListSuppliersCmb.DisplayMember = "SupplierName";
            ListItemsCmb.DisplayMember = "Descript";
            ListSuppliersCmb.ValueMember = "SupplierId";
            ListItemsCmb.ValueMember = "ItemId";
            ListSuppliersCmb.SelectedIndex = -1;
            ListItemsCmb.Text = "";
            gridItems = new List<OrderLine>();
            gridOrderItems = new List<OrderCart>();
            //orderDetails = new List<OrderFullDetails>();
            orderDetails1 = new List<OrderLine>();
            ListItemsCmb.SelectedValueChanged += ListItemsCmb_SelectedValueChanged;
        }

        private void OrderFrm_Load(object sender, EventArgs e)
        {
            ItemsGridView.DataSource = null;
            //ItemsGridView.DataSource = OrdersProcessor.GetCombinedItems(items);
            //ItemsGridView.Columns[4].Visible = false;
            //ItemsGridView.Columns[5].Visible = false;
            //ItemsGridView.Columns[6].Visible = false;
            //ItemsGridView.Columns[8].Visible = false;
            //ItemsGridView.Columns[9].Visible = false;
            //HightlightInactiveItems();

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {

            if (IsOrderLineValid())
            {

                bool ItemSelectedAgain = false;
                OrderCart line = new OrderCart
                {
                    Id = itemCounter,
                    Descript = ListItemsCmb.Text,
                    StockCode = items.Find(x => x.Itemid == int.Parse(ListItemsCmb.SelectedValue.ToString())).StockCode,
                    PurchasePrice = decimal.Parse (purchasePriceTxt.Text),
                    PurchasedQuantity = int.Parse(PurchasedQuantityTxt.Text),
                    LineTotal = decimal.Parse(PurchasedQuantityTxt.Text) * decimal.Parse(purchasePriceTxt.Text)
                };

                if (OrdersProcessor.IsStockQuantityEnough(int.Parse(PurchasedQuantityTxt.Text), int.Parse(StockQuantityTxt.Text)) == true)
                {
                    foreach (DataGridViewRow row in ItemsGridView.Rows)
                    {
                        if (Convert.ToString(row.Cells["Descript"].Value) == Convert.ToString(ListItemsCmb.Text))
                        {
                            row.Cells["PurchasedQuantity"].Value = Convert.ToInt16(row.Cells["PurchasedQuantity"].Value) + Convert.ToInt16(PurchasedQuantityTxt.Text);
                            row.Cells["LineTotal"].Value = Convert.ToDecimal(purchasePriceTxt.Text) * Convert.ToDecimal(row.Cells["PurchasedQuantity"].Value);
                            row.Cells["Id"].Value = row.Cells["Id"].Value;
                            ItemSelectedAgain = true;
                        }

                    }

                    if (ItemSelectedAgain == false)
                    {

                        ItemsGridView.DataSource = null;
                        gridOrderItems.Add(line);
                        ItemsGridView.DataSource = gridOrderItems;
                        ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
                        ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";
                        itemCounter += 1;
                        SaveOrderBtn.Enabled = true;

                    }
                    decimal subTotal = gridOrderItems.Sum(x => x.LineTotal);
                    STotalTxt.Text = subTotal.ToString();
                    GdTotalTxt.Text = subTotal.ToString();
                    ListSuppliersCmb.SelectedIndex = -1;
                    purchasePriceTxt.Clear();
                    PurchasedQuantityTxt.Clear();
                }
                else
                {
                    MessageBox.Show(" There is no enough stock !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PurchasedQuantityTxt.Clear();
                    StockQuantityTxt.Clear();
                    PurchasedQuantityTxt.Focus();
                }

            }
        }

        public bool IsOrderLineValid()
        {

            if (ListItemsCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item please !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ListItemsCmb.Focus();
                return false;
            }

            if (purchasePriceTxt.Text == string.Empty)
            {
                MessageBox.Show("Unit Price is Required !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                purchasePriceTxt.Focus();
                return false;
            }
            else
            {
                decimal TempUnitPrice;
                bool deciml = decimal.TryParse(purchasePriceTxt.Text, out TempUnitPrice);
                if (!deciml)
                {
                    MessageBox.Show("Unit Price must be a decimal !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    purchasePriceTxt.Clear();
                    purchasePriceTxt.Focus();
                    return false;
                }
                if (TempUnitPrice <= 0)
                {
                    MessageBox.Show("Unit Price must be a positive number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    purchasePriceTxt.Clear();
                    purchasePriceTxt.Focus();
                    return false;
                }
            }
            if (PurchasedQuantityTxt.Text == string.Empty)
            {
                MessageBox.Show("Quantity is Required !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PurchasedQuantityTxt.Focus();
                return false;
            }
            else
            {
                int TempQty;
                bool number = int.TryParse(PurchasedQuantityTxt.Text, out TempQty);
                if (!number)
                {
                    MessageBox.Show("Quantity must be a number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PurchasedQuantityTxt.Clear();
                    PurchasedQuantityTxt.Focus();
                    return false;
                }
                if (TempQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PurchasedQuantityTxt.Clear();
                    PurchasedQuantityTxt.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SupplierLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierFrm Sf = new SupplierFrm();
            Sf.Show();
        }

        private void ItemLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemFrm Itf = new ItemFrm();
            Itf.Show();
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            if (IsOrderValid())
            {
                Orders data = new Orders
                {
                    OrderNumber = OrderNumberTxt.Text,
                    OrderDate = OrderDatePicker.Value.Date,
                    SubTotal = decimal.Parse(STotalTxt.Text),
                    Tax = decimal.Parse(TaxTxt.Text),
                    Total = decimal.Parse(GdTotalTxt.Text),
                    SelectedSupplier = (Supplier)ListSuppliersCmb.SelectedValue,
                    Details = gridItems
                };

                OrdersProcessor.SaveSupplyOrder(data);
                MessageBox.Show("1 Record has been added Successfully !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControls();
            }
        }
        private bool IsOrderValid()
        {

            if (ListSuppliersCmb.SelectedIndex == -1)
            {
                MessageBox.Show("The Select a Supplier please !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ListSuppliersCmb.Focus();
                return false;
            }
            if (OrderNumberTxt.Text == string.Empty)
            {
                MessageBox.Show("The OrderNumber is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OrderNumberTxt.Focus();
                return false;
            }
            return true;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            SaveOrderBtn.Enabled = false;
            ListItemsCmb.Text = "";
            ListItemsCmb.Focus();
            ListSuppliersCmb.SelectedIndex = -1;
            TotalOrdersLbl.Text = "";
            purchasePriceTxt.Clear();
            PurchasedQuantityTxt.Clear();
            StockQuantityTxt.Clear();
            SearchOrderNumberTxt.Clear();
            STotalTxt.Text = "0";
            TaxTxt.Text = "0";
            GdTotalTxt.Text = "0";
            OrderNumberTxt.Clear();
            ItemsGridView.DataSource = null;
            orderDetails1 = null;
            Initialize();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = ItemsGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            using (ModifyGridQuantity mgq = new ModifyGridQuantity())
            {
                mgq.CurrentQuantity = Int16.Parse(ItemsGridView.Rows[row].Cells["Quantity"].Value.ToString());
                if (mgq.ShowDialog() == DialogResult.OK)
                {
                    ItemsGridView.Rows[row].Cells["Quantity"].Value = mgq.NewQuantity;
                    ItemsGridView.Rows[row].Cells["TotalLine"].Value = mgq.NewQuantity * decimal.Parse(ItemsGridView.Rows[row].Cells["UnitPrice"].Value.ToString());
                }
                decimal subTotal = gridItems.Sum(x => x.LineTotal);
                STotalTxt.Text = subTotal.ToString();
                GdTotalTxt.Text = subTotal.ToString();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = ItemsGridView.CurrentCell.RowIndex;
            gridItems.RemoveAt(row);
            ItemsGridView.DataSource = null;
            ItemsGridView.DataSource = gridItems;
            decimal subTotal = gridItems.Sum(x => x.LineTotal);
            STotalTxt.Text = subTotal.ToString();
            GdTotalTxt.Text = subTotal.ToString();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void EnableControls()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            SearchGroupBox.Enabled = true;
            TotalsGroupBox.Enabled = true;
            InactiveItemsGroupBox.Enabled = true;
            ItemsToReorderGroupBox.Enabled = true;
            FilterOrdersByDateGroupBox.Enabled = true;
            ResetBtn.Enabled = true;
            SupplierLinkLbl.Enabled = true;
            ItemLinkLbl.Enabled = true;
            UsersLinkLbl.Enabled = true;
            ItemsGridView.DataSource = null;
            ResetControls();
            ListItemsCmb.Focus();
        }

        private void printOrderDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ////Image image = SalesProject.Properties.Resources.logo;
            ////e.Graphics.DrawImage(image,0,0,image.Width,image.Height);
            ///
            e.Graphics.DrawString("Page   " + ((itemsPrintedSoFar % 7) == 0 ? (itemsPrintedSoFar / 7) + 1 : (itemsPrintedSoFar / 7) + 2),
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString("Order Report", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date : " + orderDetails1[0].Order.OrderDate.Date.ToLongDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString("Order Number :  " + orderDetails1[0].Order.OrderNumber, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 410));
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

            for (int i = itemsPrintedSoFar; i < orderDetails1.Count; i++)
            {
                NumberOfItemsPage++;
                if (NumberOfItemsPage <= 7)
                {
                    itemsPrintedSoFar++;

                    if (itemsPrintedSoFar <= orderDetails1.Count)
                    {
                        //e.Graphics.DrawString(orderDetails1[i].Id.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, YPos + 30));
                        e.Graphics.DrawString(orderDetails1[i].SelectedItem.Descript, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(70, YPos + 30));
                        e.Graphics.DrawString(orderDetails1[i].PurchasePrice.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(370, YPos + 30));
                        e.Graphics.DrawString(orderDetails1[i].PurchasedQuantity.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(480, YPos + 30));
                        e.Graphics.DrawString(orderDetails1[i].LineTotal.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(640, YPos + 30));
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
            e.Graphics.DrawString(" Sub Total  (R) : " + orderDetails1[0].Order.SubTotal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 60));
            e.Graphics.DrawString(" VAT    (R) : " + orderDetails1[0].Order.Tax, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 90));
            e.Graphics.DrawString(" Grand Total (R) : " + orderDetails1[0].Order.Total, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 120));
            e.Graphics.DrawString(" Supplied by : " + orderDetails1[0].Order.SelectedSupplier.SupplierName, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, YPos + 150));
            e.Graphics.DrawString(" " + orderDetails1[0].Order.SelectedSupplier.SupplierTelephone, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, YPos + 180));
            e.Graphics.DrawString(" " + orderDetails1[0].Order.SelectedSupplier.SupplierEmailAddress, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, YPos + 210));
            e.Graphics.DrawString(" " + orderDetails1[0].Order.SelectedSupplier.SupplierPhysicalAddress, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, YPos + 240));
            NumberOfItemsPage = 0;
            itemsPrintedSoFar = 0;
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
                orderDetails1 = OrdersProcessor.GetOrderDetails(SearchOrderNumberTxt.Text);
                if (orderDetails1.Count == 0 || orderDetails1 == null)
                {
                    MessageBox.Show(" Order Number  " + SearchOrderNumberTxt.Text + "  does not exist in the System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SearchOrderNumberTxt.Clear();
                    SearchOrderNumberTxt.Focus();
                }
                else
                {
                    List<OrderCart> OrderReportToDisplay = new List<OrderCart>();

                    int lineCounter = 1;

                    foreach (var order in orderDetails1)
                    {

                        //order.Id = lineCounter;
                        OrderCart line = new OrderCart
                        {
                            Id = lineCounter,
                            StockCode = order.SelectedItem.StockCode,
                            Descript = order.SelectedItem.Descript,
                            PurchasedQuantity = order.PurchasedQuantity,
                            PurchasePrice = order.PurchasePrice,
                            LineTotal = order.LineTotal
                        };
                        OrderReportToDisplay.Add(line);
                        lineCounter += 1;
                    }
                    ItemsGridView.DataSource = null;
                    ItemsGridView.DataSource = OrderReportToDisplay;
                    //hide 2 columns(ItemId,OrderNumber) in the grid

                    ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
                    ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";
                    STotalTxt.Text = orderDetails1[0].Order.SubTotal.ToString();
                    TaxTxt.Text = orderDetails1[0].Order.Tax.ToString();
                    GdTotalTxt.Text = orderDetails1[0].Order.Total.ToString();
                }
            }
        }

        private void PrintPreviewReportOrder_Click(object sender, EventArgs e)
        {

            if (orderDetails1.Count == 0 || orderDetails1 == null)
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


        private void ListItemsCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            var listItemQuantities = OrderLineProcessor.GetEntryQuantityByItem();
            bool IsItemFound = false;
            foreach (var itemQuantity in listItemQuantities)
            {
                if (int.Parse(ListItemsCmb.SelectedValue.ToString()) == itemQuantity.SelectedItem.Itemid)
                {
                    StockQuantityTxt.Text = itemQuantity.PurchasedQuantity.ToString();
                    purchasePriceTxt.Text = (ItemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid)).ToString();
                    IsItemFound = true;
                }
            }
            if (!IsItemFound)
            {
                StockQuantityTxt.Text = "0";
                purchasePriceTxt.Text = "0";
            }
        }

        private void ItemsGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //checks if the list of ordercart items contains data so that it can show the contextual menu
            if (gridItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.ItemsGridView.Rows[e.RowIndex].Selected = true;
                    //this.rowIndex = e.RowIndex;
                    this.ModifyQuantityMenu.Show(this.ItemsGridView, e.Location);
                    this.ModifyQuantityMenu.Show(Cursor.Position);
                }
            }

        }

        private void ReOrderListBtn_Click(object sender, EventArgs e)
        {
            Initialize();
            ItemsGridView.DataSource = null;
            var p = OrdersProcessor.GetItemsToReorder(items);
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
            var p = OrdersProcessor.GetInactiveItems(items);
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

        private void printItemsToReorderDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<OrderLine> itemsToReorder = OrdersProcessor.GetItemsToReorder(items) as dynamic;
            //int s = itemsToReorder[0].Id;
            //int t = s;
            e.Graphics.DrawString("Page   " + ((itemsPrintedSoFar % 7) == 0 ? (itemsPrintedSoFar / 7) + 1 : (itemsPrintedSoFar / 7) + 2),
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString("List of Items To Reorder", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 330));
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

        private void PrintPreviewItemsToReorder_Click(object sender, EventArgs e)
        {
            List<OrderLine> itemsToReorder = OrdersProcessor.GetItemsToReorder(items);
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

        private void HightlightInactiveItems()
        {
            var listItemQuantities = OrderLineProcessor.GetEntryQuantityByItem();

            if (ItemsGridView.DataSource != null)
            {
                if (ItemsGridView.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in ItemsGridView.Rows)
                    {
                        foreach (var i in items)
                        {
                            if ((int.Parse(row.Cells["ItemId"].Value.ToString()) == i.Itemid))
                            {
                                foreach (var iq in listItemQuantities)
                                {
                                    if (i.Itemid == iq.SelectedItem.Itemid)
                                    {
                                        if ((int.Parse(row.Cells["ReOrderLevel"].Value.ToString()) > iq.PurchasedQuantity))
                                        {
                                            row.DefaultCellStyle.BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void printInactiveItemsDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void UsersLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsersForm Uf = new UsersForm();
            Uf.Show();
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
                    totalOrders = ordersToDisplay.Sum(x=>x.Total);
                    TotalOrdersLbl.Text ="R "+totalOrders.ToString();
                    ItemsGridView.DataSource = null;
                    ItemsGridView.DataSource = ordersToDisplay;
                }
                
            }
            
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
                    TotalOrdersLbl.Text = "R " + totalOrders.ToString();
                    ItemsGridView.DataSource = null;
                    ItemsGridView.DataSource = ordersToDisplay;
                }

            }
        }
    }
}
