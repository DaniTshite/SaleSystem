using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.Data;
using DataLibrary.Models;
using GUIApp.Models;
using LogicLibrary.Processes;

namespace GUIApp
{
    public partial class SaleFrm : Form
    {
        List<Item> listItems ;
        //list of items to display in the shopping cart
        List<OrderCart> itemsToDisplay;
        //list of items in the shopping cart but to be saved in the DB
        List<SaleLine> itemsToSave ;
        //counter used to count items in the shopping cart
        int itemCounter = 1;
        public SaleFrm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            ItemsListBox.SelectedValueChanged -=ItemsListBox_SelectedValueChanged;
            listItems = new List<Item>();
            listItems = ItemProcessor.LoadData();
            ItemsListBox.DataSource = listItems;
            ItemsListBox.DisplayMember = "Descript";
            ItemsListBox.ValueMember = "ItemId";
            itemsToDisplay = new List<OrderCart>();
            itemsToSave = new List<SaleLine>();
            ResetAllControls();
            ItemsListBox.SelectedValueChanged += ItemsListBox_SelectedValueChanged;
        }

        private void ItemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            var listItemQuantities = OrderLineProcessor.GetEntryQuantityByItem();
            bool IsItemFound = false;
            if (ItemsListBox.SelectedValue != null)
            {
                foreach (var itemQuantity in listItemQuantities)
                {
                    if (int.Parse(ItemsListBox.SelectedValue.ToString()) == itemQuantity.SelectedItem.Itemid)
                    {
                        StockQuantityLbl.Text = itemQuantity.PurchasedQuantity.ToString();
                        //RetailPriceLbl.Text = String.Format("{0:C2}", ItemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid));
                        //string.Format("{0:0.##}", 256.58);
                        RetailPriceLbl.Text = string.Format("{0:0.##}", ItemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid));
                        IsItemFound = true;
                    }
                }
                if (!IsItemFound)
                {
                    StockQuantityLbl.Text = "0";
                    RetailPriceLbl.Text = "0";
                }
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (IsSaleLineValid())
            {

                bool ItemSelectedAgain = false;
                OrderCart line = new OrderCart
                {
                    Id = itemCounter,
                    Descript = ((Item)ItemsListBox.SelectedItem).Descript.ToString(),
                    StockCode = ((Item)ItemsListBox.SelectedItem).StockCode.ToString(),
                    PurchasePrice = decimal.Parse(RetailPriceLbl.Text),
                    PurchasedQuantity = int.Parse(SaleQuantityTxt.Text),
                    LineTotal = decimal.Parse(SaleQuantityTxt.Text) * decimal.Parse(RetailPriceLbl.Text)
                };


                if (OrdersProcessor.IsStockQuantityEnough(int.Parse(SaleQuantityTxt.Text), int.Parse(StockQuantityLbl.Text)) == true)
                {
                    foreach (DataGridViewRow row in ItemsGridView.Rows)
                    {
                        if (Convert.ToString(row.Cells["Descript"].Value) == Convert.ToString(ItemsListBox.Text))
                        {
                            row.Cells["PurchasedQuantity"].Value = Convert.ToInt16(row.Cells["PurchasedQuantity"].Value) + Convert.ToInt16(SaleQuantityTxt.Text);
                            row.Cells["LineTotal"].Value = Convert.ToDecimal(RetailPriceLbl.Text) * Convert.ToDecimal(row.Cells["PurchasedQuantity"].Value);
                            row.Cells["Id"].Value = row.Cells["Id"].Value;
                            ItemSelectedAgain = true;
                        }

                    }
                    if (ItemSelectedAgain == false)
                    {
                        //saleline object to save into the DB
                        SaleLine p = new SaleLine
                        {

                        };
                        ItemsGridView.DataSource = null;
                        itemsToDisplay.Add(line);
                        ItemsGridView.DataSource = itemsToDisplay;
                        ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
                        ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";
                        itemCounter += 1;
                        CashBtn.Enabled = true;
                        CreditBtn.Enabled = true;

                    }
                    decimal subTotal = itemsToDisplay.Sum(x => x.LineTotal);
                    SubTotalLbl.Text = String.Format("{0:C2}", subTotal);
                    TotalLbl.Text = String.Format("{0:C2}", subTotal);
                    ItemsListBox.SelectedIndex = -1;
                    RetailPriceLbl.Text = "";
                    StockQuantityLbl.Text = "";
                    SaleQuantityTxt.Clear();
                    
                }
                else
                {
                    MessageBox.Show(" There is no enough stock !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleQuantityTxt.Clear();
                    RetailPriceLbl.Text = "";
                    StockQuantityLbl.Text = "";
                }

            }
        }

        private bool IsSaleLineValid()
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item please !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            if (SaleQuantityTxt.Text == string.Empty)
            {
                MessageBox.Show("Quantity is Required !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaleQuantityTxt.Focus();
                return false;
            }
            else
            {
                int TempQty;
                bool number = int.TryParse(SaleQuantityTxt.Text, out TempQty);
                if (!number)
                {
                    MessageBox.Show("Quantity must be a number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleQuantityTxt.Clear();
                    SaleQuantityTxt.Focus();
                    return false;
                }
                if (TempQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleQuantityTxt.Clear();
                    SaleQuantityTxt.Focus();
                    return false;
                }
            }
            return true;
        }

        private void ResetAllControls()
        {
            StockQuantityLbl.Text = "0";
            SubTotalLbl.Text = "0";
            TotalLbl.Text = "0";
            TaxLbl.Text = "0";
            ItemsListBox.SelectedIndex = -1;
            RetailPriceLbl.Text = "";
            StockQuantityLbl.Text = "";
            SaleQuantityTxt.Clear();
            InvoiceNumberLbl.Text = "INVOICE No : " + SalesProcessor.GetInvoiceNumber().ToString();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetAllControls();
            itemsToDisplay = new List<OrderCart>();
            ItemsGridView.DataSource = null;
            
        }

        private void CashBtn_Click(object sender, EventArgs e)
        {
            //Sales data = new Sales
            //{
            //    OrderNumber = OrderNumberTxt.Text,
            //    OrderDate = OrderDatePicker.Value.Date,
            //    SubTotal = decimal.Parse(STotalTxt.Text),
            //    Tax = decimal.Parse(TaxTxt.Text),
            //    Total = decimal.Parse(GdTotalTxt.Text),
            //    SelectedSupplier = (Supplier)ListSuppliersCmb.SelectedValue,
            //    Details = itemsToDisplay;
            //};

            //SalesProcessor.SaveSaleOrder(data);
            //MessageBox.Show("1 Record has been added Successfully !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ResetAllControls();
        }
    }
}
