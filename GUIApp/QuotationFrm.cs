using DataLibrary.Models;
using GUIApp.Models;
using LogicLibrary;
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
    public partial class QuotationFrm : Form
    {
        private IOrderLineProcessor _orderLineProcessor;
        IQuotationsProcessor _quotationsProcessor;
        IQuotationLineProcessor _quotationLineProcessor;
        ICustomerAccountProcessor _customerAccountsProcessor;
        IUsersProcessor _usersProcessor;
        IItemProcessor _itemProcessor;
        List<Item> activeItems;
        //List<Quotations> quotations;
        List<Users> users;
        List<CustomerAccount> customerAccounts;
        //list of items to display in the shopping cart
        List<OrderCart> itemsToDisplay;
        //list of items in the shopping cart but to be saved in the DB
        List<IQuotationLine> itemsToSave;
        //counter used to count items in the shopping cart
        int itemCounter = 1;
        //current invoice IsNumber
        int CurrentQuotatioNumber;
        decimal RetailPrice;
        int StockQuantity;
        decimal SubTotal;
        decimal Total = 0, Tax = 0;
        

        public QuotationFrm()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            ItemsListBox.SelectedValueChanged -= ItemsListBox_SelectedValueChanged;
            _orderLineProcessor = ContainerConfig.CreateOrderLineProcessor();
            _customerAccountsProcessor = ContainerConfig.CreateCustomerAccountProcessor();
            _quotationsProcessor = ContainerConfig.CreateQuotationsProcessor();
            _quotationLineProcessor = ContainerConfig.CreateQuotationLineProcessor();
            _itemProcessor = ContainerConfig.CreateItemProcessor();
            _usersProcessor = ContainerConfig.CreateUsersProcessor();
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
            CustomerAccountsCmb.DataSource = customerAccounts;
            CustomerAccountsCmb.DisplayMember = "FirstName";
            CustomerAccountsCmb.ValueMember = "AccountId";
            itemsToDisplay = new List<OrderCart>();
            itemsToSave = new List<IQuotationLine>();
            ResetAllControls();
            ItemsListBox.SelectedValueChanged += ItemsListBox_SelectedValueChanged;
        }
        //This method displays the retail price when a value is selected in the combobox
        private void ItemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var listItemQuantities = _orderLineProcessor.GetEntryQuantityByItem();
            bool IsItemFound = false;
            if (ItemsListBox.SelectedValue != null)
            {
                AddToCartBtn.Enabled = true;
                QuotationQuantityTxt.Enabled = true;

                foreach (var itemQuantity in listItemQuantities)
                {
                    if (int.Parse(ItemsListBox.SelectedValue.ToString()) == itemQuantity.SelectedItem.Itemid)
                    {
                        //checks if the item is already in the shopping cart so that we can substract that quantity from the stock quantity
                        if (ItemsGridView.DataSource != null)
                        {
                            foreach (DataGridViewRow row in ItemsGridView.Rows)
                            {
                                if (Convert.ToString(row.Cells["Descript"].Value) == Convert.ToString(ItemsListBox.Text))
                                {
                                    StockQuantity = HelperProcessor.GetStockQuantity(itemQuantity.SelectedItem.Itemid) - (int)(row.Cells["PurchasedQuantity"].Value);
                                    IsItemFound = true;
                                }
                            }
                        }
                        if (!IsItemFound)
                        {
                            StockQuantity = HelperProcessor.GetStockQuantity(itemQuantity.SelectedItem.Itemid);
                        }
                        StockQuantityLbl.Text = StockQuantity.ToString();
                        RetailPrice = _itemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid);
                        RetailPriceLbl.Text = String.Format("{0:C2}", RetailPrice); ;
                        
                    }
                }
               
            }
        }

        private void ResetAllControls()
        {
            StockQuantityLbl.Text = "0.00";
            SubTotalLbl.Text = "0.00";
            TotalLbl.Text = "0.00";
            TaxLbl.Text = "0.00";
            
            ItemsListBox.SelectedIndex = -1;
            RetailPriceLbl.Text = "0.00";
            StockQuantityLbl.Text = "";
            QuotationQuantityTxt.Clear();
            QuotationQuantityTxt.Enabled = false;
            
            SaveBtn.Enabled = false;
            
            AddToCartBtn.Enabled = false;
            
            ResetBtn.Enabled = false;
            CurrentQuotatioNumber = _quotationsProcessor.GetQuotationNumber();
            InvoiceNumberLbl.Text = " QUOTATION No : " + CurrentQuotatioNumber;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetAllControls();
            itemsToDisplay = new List<OrderCart>();
            ItemsGridView.DataSource = null;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            //Instantiation of quotations object
            IQuotations quotation = ContainerConfig.CreateQuotations();
            quotation.QuotationNumber = CurrentQuotatioNumber;
            quotation.Discount = 1;
            quotation.SubTotal = SubTotal;
            quotation.Tax = 1;
            quotation.Total = Total;
            quotation.QuotationDetails = itemsToSave;
            MessageBox.Show(_quotationsProcessor.SaveQuotation(quotation), "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ItemsGridView.DataSource = null;
            ResetAllControls();
        }

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
                    PurchasedQuantity = int.Parse(QuotationQuantityTxt.Text),
                    LineTotal = decimal.Parse(QuotationQuantityTxt.Text) * RetailPrice
                };

                //checks if quantity to be sold is less than the stock
                if (HelperProcessor.IsStockQuantityEnough(int.Parse(QuotationQuantityTxt.Text), int.Parse(StockQuantityLbl.Text)) == true)
                {
                    //checks if the selected item is already in the cart 
                    foreach (DataGridViewRow row in ItemsGridView.Rows)
                    {
                        if (Convert.ToString(row.Cells["Descript"].Value) == Convert.ToString(ItemsListBox.Text))
                        {
                            row.Cells["PurchasedQuantity"].Value = Convert.ToInt16(row.Cells["PurchasedQuantity"].Value) + Convert.ToInt16(QuotationQuantityTxt.Text);
                            row.Cells["LineTotal"].Value = RetailPrice * Convert.ToDecimal(row.Cells["PurchasedQuantity"].Value);
                            row.Cells["Id"].Value = row.Cells["Id"].Value;
                            ItemSelectedAgain = true;
                        }

                    }
                    //checks if the selected ittm is not in the cart 
                    if (ItemSelectedAgain == false)
                    {
                        //instanciation of quotation line object to save into the DB
                        //SaleLine p = new SaleLine
                        //{
                        //    SelectedItem = (Item)ItemsListBox.SelectedItem,
                        //    RetailPrice = RetailPrice,
                        //    SaleQuantity = line.PurchasedQuantity,
                        //    LineTotal = line.LineTotal
                        //};
                        IQuotationLine p = ContainerConfig.CreateQuotationLine();
                        p.SelectedItem = (Item)ItemsListBox.SelectedItem;
                        p.RetailPrice = RetailPrice;
                        p.QuotationQuantity = line.PurchasedQuantity;
                        p.LineTotal = line.LineTotal;
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
                        SaveBtn.Enabled = true;
                        
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
                    QuotationQuantityTxt.Clear();

                }
                else
                {
                    MessageBox.Show(" There is no enough stock !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuotationQuantityTxt.Clear();
                    RetailPriceLbl.Text = "0.00";
                    StockQuantityLbl.Text = "";
                }

            }
        }

        private void QuotationFrm_Load(object sender, EventArgs e)
        {
            QuotationValidityLbl.Text = QuotationValidityLbl.Text + DateTime.Today.AddDays(7).ToShortDateString();
        }

        private bool IsSaleLineValid()
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item please !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (QuotationQuantityTxt.Text == string.Empty)
            {
                MessageBox.Show("Quantity is Required !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuotationQuantityTxt.Focus();
                return false;
            }
            else
            {
                int TempQty;
                bool IsNumber = int.TryParse(QuotationQuantityTxt.Text, out TempQty);
                if (!IsNumber)
                {
                    MessageBox.Show("Quantity must be a IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuotationQuantityTxt.Clear();
                    QuotationQuantityTxt.Focus();
                    return false;
                }
                if (TempQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuotationQuantityTxt.Clear();
                    QuotationQuantityTxt.Focus();
                    return false;
                }
            }
            return true;
        }
        
    }
}
