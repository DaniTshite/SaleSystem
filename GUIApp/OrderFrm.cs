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
using LogicLibrary.HelperProcesses;
using LogicLibrary;

namespace GUIApp
{
    public partial class OrderFrm : Form
    {
        readonly IOrderLineProcessor _orderLineProcessor = ContainerConfig.CreateOrderLineProcessor();
        readonly IOrdersProcessor _ordersProcessor = ContainerConfig.CreateOrdersProcessor();
        IItemProcessor _itemProcessor;
        ISupplierProcessor _supplierProcessor;
        //Lists used for 2 comboboxes and OrderLineCart 

        List<Item> items = new List<Item>();
        List<Item> activeItems = new List<Item>();
        List<Supplier> suppliers = new List<Supplier>();

        List<OrderLine> gridItems;
        List<OrderCart> gridOrderItemsToDisplay;

        //print Order Document

        private int NumberOfItemsPage = 0;
        private int itemsPrintedSoFar = 0;

        //Item counter for Order Cart

        int itemCounter = 1;
        List<OrderLine> orderDetails;
        private decimal PurchasePrice;
        List<IOrderLine> itemsToSave;

        public OrderFrm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            ListItemsCmb.SelectedValueChanged -= ListItemsCmb_SelectedValueChanged;
            _itemProcessor = ContainerConfig.CreateItemProcessor();
            _supplierProcessor = ContainerConfig.CreateSupplierProcessor();
            items = new List<Item>();
            suppliers = new List<Supplier>();
            activeItems = new List<Item>();
            items = _itemProcessor.GetItems();
            suppliers = _supplierProcessor.GetSuppliers();
            activeItems = _itemProcessor.GetActiveItemsSupply();
            ListItemsCmb.DataSource = activeItems;
            ListSuppliersCmb.DataSource = suppliers;
            ListSuppliersCmb.DisplayMember = "SupplierName";
            ListItemsCmb.DisplayMember = "Descript";
            ListSuppliersCmb.ValueMember = "SupplierId";
            ListItemsCmb.ValueMember = "ItemId";
            ListSuppliersCmb.SelectedIndex = -1;
            ListItemsCmb.Text = "";
            gridItems = new List<OrderLine>();
            gridOrderItemsToDisplay = new List<OrderCart>();
            itemsToSave = new List<IOrderLine>();
            orderDetails = new List<OrderLine>();
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
                //checks if quantity to be sold is less than the stock
                //if (HelperProcessor.IsStockQuantityEnough(int.Parse(PurchasedQuantityTxt.Text), int.Parse(StockQuantityTxt.Text)) == true)
                //{
                    //checks if the selected item is already in the cart 
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
                    //checks if the selected ittm is not in the cart 
                    if (ItemSelectedAgain == false)
                    {
                        //instanciation of orderline object to save into the DB
                        IOrderLine orderline = ContainerConfig.CreateOrderLine();
                        orderline.SelectedItem = (Item)ListItemsCmb.SelectedItem;
                        orderline.PurchasePrice = decimal.Parse(purchasePriceTxt.Text);
                        orderline.PurchasedQuantity = line.PurchasedQuantity;
                        orderline.LineTotal = line.LineTotal;
                        
                        //list of items to save into the DB
                        itemsToSave.Add(orderline);
                        //list of items to display in the cart
                        ItemsGridView.DataSource = null;
                        gridOrderItemsToDisplay.Add(line);
                        ItemsGridView.DataSource = gridOrderItemsToDisplay;
                        //add currency symbol to retail price and net total
                        ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
                        ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";
                        //increment counter in the cart
                        itemCounter += 1;
                        SaveOrderBtn.Enabled = true;

                    }
                    decimal subTotal = gridOrderItemsToDisplay.Sum(x => x.LineTotal);
                    decimal tax = subTotal * (decimal)0.15;
                    decimal gdTotal = subTotal + tax; 
                    STotalTxt.Text = subTotal.ToString();
                    TaxTxt.Text = tax.ToString();
                    GdTotalTxt.Text = gdTotal.ToString();
                    ListSuppliersCmb.SelectedIndex = -1;
                    purchasePriceTxt.Clear();
                    PurchasedQuantityTxt.Clear();
                    StockQuantityLbl.Text="0";
                //}
                //else
                //{
                //    MessageBox.Show(" There is no enough stock !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    PurchasedQuantityTxt.Clear();
                //    StockQuantityTxt.Clear();
                //    PurchasedQuantityTxt.Focus();
                //}

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
                    MessageBox.Show("Unit Price must be a positive IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bool IsNumber = int.TryParse(PurchasedQuantityTxt.Text, out TempQty);
                if (!IsNumber)
                {
                    MessageBox.Show("Quantity must be a IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PurchasedQuantityTxt.Clear();
                    PurchasedQuantityTxt.Focus();
                    return false;
                }
                if (TempQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                IOrders order = ContainerConfig.CreateOrders();
                order.OrderNumber = OrderNumberTxt.Text;
                order.OrderDate = OrderDatePicker.Value.Date;
                order.SubTotal = decimal.Parse(STotalTxt.Text);
                order.Tax = decimal.Parse(TaxTxt.Text);
                order.Total = decimal.Parse(GdTotalTxt.Text);
                order.SelectedSupplier = (Supplier)ListSuppliersCmb.SelectedItem;
                order.SupplyOrderDetails = itemsToSave;
                MessageBox.Show(_ordersProcessor.SaveSupplyOrder(order), "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            purchasePriceTxt.Clear();
            PurchasedQuantityTxt.Clear();
            StockQuantityLbl.Text="0";
            STotalTxt.Text = "0";
            TaxTxt.Text = "0";
            GdTotalTxt.Text = "0";
            OrderNumberTxt.Clear();
            ItemsGridView.DataSource = null;
            orderDetails = null;
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
            
        }

        private void printOrderDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void SearchOrderNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void PrintPreviewReportOrder_Click(object sender, EventArgs e)
        {

           

        }

        private void ListItemsCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            var listItemQuantities = _orderLineProcessor.GetEntryQuantityByItem();
            bool IsItemFound = false;
            foreach (var itemQuantity in listItemQuantities)
            {
                if (int.Parse(ListItemsCmb.SelectedValue.ToString()) == itemQuantity.SelectedItem.Itemid)
                {
                    StockQuantityLbl.Text = HelperProcessor.GetStockQuantity(itemQuantity.SelectedItem.Itemid).ToString();
                    //purchasePriceTxt.Text = (ItemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid)).ToString();
                    IsItemFound = true;
                }
            }
            if (!IsItemFound)
            {
                StockQuantityLbl.Text = "0";
                purchasePriceTxt.Text = "0";
            }
        }

        private void ItemsGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //checks if the list of ordercart items contains order so that it can show the contextual menu
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

        }

        private void InactiveItemsListBtn_Click(object sender, EventArgs e)
        {

        }

        private void printItemsToReorderDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void PrintPreviewItemsToReorder_Click(object sender, EventArgs e)
        {
            
        }

        private void HightlightInactiveItems()
        {
            var listItemQuantities = _orderLineProcessor.GetEntryQuantityByItem();

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

        private void UsersLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsersForm Uf = new UsersForm();
            Uf.Show();
        }

        private void SuperiorDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InferiorDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CustomerAccountLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void SalesLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
