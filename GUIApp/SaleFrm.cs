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
using LogicLibrary.HelperProcesses;
using LogicLibrary.Processes;

namespace GUIApp
{
    public partial class SaleFrm : Form
    {
        ISalesProcessor _salesProcessor;
        OrderLineProcessor _orderLineProcessor ;
        CustomerAccountProcessor _customerAccountsProcessor;
        UsersProcessor _usersProcessor;
        ItemProcessor _itemProcessor;
        List<Item> activeItems ;
        List<Quotations> quotations;
        List<Users> users;
        List<CustomerAccount> customerAccounts;
        //list of items to display in the shopping cart
        List<OrderCart> itemsToDisplay;
        //list of items in the shopping cart but to be saved in the DB
        List<SaleLine> itemsToSave ;
        //counter used to count items in the shopping cart
        int itemCounter = 1;
        //current invoice number
        int CurrentInvoiceNumber;
        decimal RetailPrice;
        decimal SubTotal;
        decimal Total=0,Tax=0;
        public SaleFrm()
        {
            InitializeComponent();
            Initialize();
        }
        //This method initialises comboboxes ,instantiates objects,resets controls ,etc 
        private void Initialize()
        {
            ItemsListBox.SelectedValueChanged -=ItemsListBox_SelectedValueChanged;
            _customerAccountsProcessor = new CustomerAccountProcessor();
            _salesProcessor = new SalesProcessor();
            _orderLineProcessor = new OrderLineProcessor();
            _itemProcessor = new ItemProcessor();
            _usersProcessor = new UsersProcessor();
            quotations = new List<Quotations>();
            users = new List<Users>();
            users = _usersProcessor.GetUsers();
            customerAccounts = new List<CustomerAccount>();
            customerAccounts = _customerAccountsProcessor.GetCustomerAccounts();
            activeItems = new List<Item>();
            activeItems = _itemProcessor.GetActiveItems();
            ItemsListBox.DataSource = activeItems;
            ItemsListBox.DisplayMember = "Descript";
            ItemsListBox.ValueMember = "ItemId";
            UsersCmb.DataSource = users;
            UsersCmb.DisplayMember = "FullName";
            UsersCmb.ValueMember = "userId";
            QuotationsCmb.DataSource = quotations;
            QuotationsCmb.DisplayMember = "QuotationId";
            QuotationsCmb.ValueMember = "QuotationId";
            CustomerAccountsCmb.DataSource = customerAccounts;
            CustomerAccountsCmb.DisplayMember = "FirstName";
            CustomerAccountsCmb.ValueMember = "AccountId";
            itemsToDisplay = new List<OrderCart>();
            itemsToSave = new List<SaleLine>();
            ResetAllControls();
            ItemsListBox.SelectedValueChanged += ItemsListBox_SelectedValueChanged;
        }
        //This displays the retail price when a value is selected in the combobox
        private void ItemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            var listItemQuantities = _orderLineProcessor.GetEntryQuantityByItem();
            bool IsItemFound = false;
            if (ItemsListBox.SelectedValue != null)
            {
                AddToCartBtn.Enabled = true;
                SaleQuantityTxt.Enabled = true;
                
                foreach (var itemQuantity in listItemQuantities)
                {
                    if (int.Parse(ItemsListBox.SelectedValue.ToString()) == itemQuantity.SelectedItem.Itemid)
                    {
                        StockQuantityLbl.Text = HelperProcessor.GetStockQuantity(itemQuantity.SelectedItem.Itemid).ToString();
                        RetailPrice = _itemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid);
                        RetailPriceLbl.Text = String.Format("{0:C2}", RetailPrice); ;
                        IsItemFound = true;
                    }
                }
                if (!IsItemFound)
                {
                    StockQuantityLbl.Text = "0.00";
                    RetailPriceLbl.Text = "0.00";
                }
            }
        }
        //This method validates input sale
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
        //This method resets all controls
        private void ResetAllControls()
        {
            StockQuantityLbl.Text = "0.00";
            SubTotalLbl.Text = "0.00";
            TotalLbl.Text = "0.00";
            TaxLbl.Text = "0.00";
            ChangeLbl.Text = "0.00";
            ItemsListBox.SelectedIndex = -1;
            RetailPriceLbl.Text = "0.00";
            StockQuantityLbl.Text = "";
            SaleQuantityTxt.Clear();
            SaleQuantityTxt.Enabled = false;
            PaidTxt.Clear();
            PaidTxt.Enabled = false;
            CashBtn.Enabled = false;
            EFTBtn.Enabled = false;
            AddToCartBtn.Enabled = false;
            RefundBtn.Enabled = false;
            ResetBtn.Enabled = false;
            CurrentInvoiceNumber = _salesProcessor.GetInvoiceNumber();
            InvoiceNumberLbl.Text = "INVOICE No : " + CurrentInvoiceNumber; ;
        }
        //This method resets all controls including the gridview
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetAllControls();
            itemsToDisplay = new List<OrderCart>();
            ItemsGridView.DataSource = null;
            
        }
        //This method saves sale into the DB when using cash
        private void CashBtn_Click(object sender, EventArgs e)
        {
            DateTime dateValue = new DateTime();
            if (DeliveryCmb.Text == "CASH AND CARRY")
            {
                dateValue = DateTime.Now.Date;
            }
            else dateValue = DeliveryDateTimePicker.Value;
            Sales sale = new Sales
            {
                InvoiceNumber=CurrentInvoiceNumber,
                Discount=1,
                SubTotal= SubTotal,
                Tax=1,
                Total= Total,
                PaymentMode="cash",
                //DeliveryMode="cash and carry",
                SaleOrderDetails = itemsToSave
            };
            
            Delivery delivery = new Delivery
            {
               
                DeliveryDate = dateValue,
                DeliveryType = DeliveryCmb.Text
            };
            
            ChangeLbl.Text = String.Format("{0:C2}", (decimal.Parse(PaidTxt.Text) - Total));
            MessageBox.Show(_salesProcessor.SaveSaleOrder(sale,delivery), "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ItemsGridView.DataSource = null;
            ResetAllControls();
        }

        private void UsersCmb_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Yhis method add an item into the cart 
        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (IsSaleLineValid())
            {

                bool ItemSelectedAgain = false;
                //instanciation of ordercart object that represents 1 line in the cart
                OrderCart line = new OrderCart
                {
                    Id = itemCounter,
                    Descript = ((Item)ItemsListBox.SelectedItem).Descript.ToString(),
                    StockCode = ((Item)ItemsListBox.SelectedItem).StockCode.ToString(),
                    PurchasePrice = RetailPrice,
                    PurchasedQuantity = int.Parse(SaleQuantityTxt.Text),
                    LineTotal = decimal.Parse(SaleQuantityTxt.Text) * RetailPrice
                };

                //checks if quantity to be sold is less than the stock
                if (HelperProcessor.IsStockQuantityEnough(int.Parse(SaleQuantityTxt.Text), int.Parse(StockQuantityLbl.Text)) == true)
                {
                    //checks if the selected item is already in the cart 
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
                    //checks if the selected ittm is not in the cart 
                    if (ItemSelectedAgain == false)
                    {
                        //instanciation of saleline object to save into the DB
                        SaleLine p = new SaleLine
                        {
                            SelectedItem = (Item)ItemsListBox.SelectedItem,
                            RetailPrice = RetailPrice,
                            SaleQuantity = line.PurchasedQuantity,
                            LineTotal = line.LineTotal
                        };
                        //list of items to save into the DB
                        itemsToSave.Add(p);

                        //list of items to display in the cart
                        ItemsGridView.DataSource = null;
                        itemsToDisplay.Add(line);
                        ItemsGridView.DataSource = itemsToDisplay;
                        //add currency symbol to retail price and net total
                        ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
                        ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";
                        //increment counter in the cart
                        itemCounter += 1;
                        CashBtn.Enabled = true;
                        EFTBtn.Enabled = true;
                        PaidTxt.Enabled = true;
                        RefundBtn.Enabled = true;
                        ResetBtn.Enabled = true;
                    }
                    SubTotal = itemsToDisplay.Sum(x => x.LineTotal);
                    Total = SubTotal + Tax;
                    //formatting these labels as currencies with 2 decimals after the comma

                    SubTotalLbl.Text = String.Format("{0:C2}", SubTotal);
                    TotalLbl.Text = String.Format("{0:C2}", Total);
                    ItemsListBox.SelectedIndex = -1;
                    RetailPriceLbl.Text = "";
                    StockQuantityLbl.Text = "";
                    SaleQuantityTxt.Clear();

                }
                else
                {
                    MessageBox.Show(" There is no enough stock !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleQuantityTxt.Clear();
                    RetailPriceLbl.Text = "0.00";
                    StockQuantityLbl.Text = "";
                }

            }
        }
        //This method save sale into the DB when using the credit card
        private void EFTBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void UsersCmb_DropDown(object sender, EventArgs e)
        {
            
        }

        private void UsersCmb_DropDownClosed(object sender, EventArgs e)
        {
            

        }

        private void DeliveryCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if(DeliveryCmb.Text == "CASH AND CARRY")
            {
                DeliveryDateTimePicker.Enabled = false;
            }
            else
            {
                DeliveryDateTimePicker.Enabled = true;
            }
        }

        private void SaleFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
