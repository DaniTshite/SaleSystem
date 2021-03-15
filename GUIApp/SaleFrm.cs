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
using LogicLibrary;
using LogicLibrary.HelperProcesses;
using LogicLibrary.Processes;

namespace GUIApp
{
    public partial class SaleFrm : Form
    {
        ISalesProcessor _salesProcessor;
        IOrderLineProcessor _orderLineProcessor ;
        ICustomerAccountProcessor _customerAccountsProcessor;
        IUsersProcessor _usersProcessor;
        IItemProcessor _itemProcessor;
        IQuotationsProcessor _quotationsProcessor;
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
        //current invoice IsNumber
        int CurrentInvoiceNumber;
        decimal RetailPrice;
        int StockQuantity;
        decimal SubTotal;
        decimal Total=0,Tax=0;

        //quotation details to display
        List<QuotationLine> quotationDetails;
        public SaleFrm()
        {
            InitializeComponent();
            Initialize();
        }
        //This method initialises comboboxes ,instantiates objects,resets controls ,etc 
        private void Initialize()
        {
            ItemsListBox.SelectedValueChanged -=ItemsListBox_SelectedValueChanged;
            QuotationsCmb.SelectedValueChanged -= QuotationsCmb_SelectedValueChanged;
            _customerAccountsProcessor = ContainerConfig.CreateCustomerAccountProcessor();
            _salesProcessor = ContainerConfig.CreateSalesProcessor();
            _orderLineProcessor = ContainerConfig.CreateOrderLineProcessor();
            _itemProcessor = ContainerConfig.CreateItemProcessor();
            _usersProcessor = ContainerConfig.CreateUsersProcessor();
            _quotationsProcessor = ContainerConfig.CreateQuotationsProcessor();
            quotations = new List<Quotations>();
            quotations = _quotationsProcessor.GetQuotations();
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
            QuotationsCmb.DisplayMember = "QuotationNumber";
            QuotationsCmb.ValueMember = "QuotationNumber";
            CustomerAccountsCmb.DataSource = customerAccounts;
            CustomerAccountsCmb.DisplayMember = "FirstName";
            CustomerAccountsCmb.ValueMember = "AccountId";
            itemsToDisplay = new List<OrderCart>();
            itemsToSave = new List<SaleLine>();
            ResetAllControls();
            QuotationsCmb.SelectedValueChanged += QuotationsCmb_SelectedValueChanged;
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
                SaleQuantityTxt.Enabled = true;
                
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
                        if(!IsItemFound)
                        {
                            StockQuantity = HelperProcessor.GetStockQuantity(itemQuantity.SelectedItem.Itemid);
                        }
                        
                        StockQuantityLbl.Text = StockQuantity.ToString();
                        RetailPrice = _itemProcessor.CalculateSalePrice(itemQuantity.SelectedItem.Itemid);
                        RetailPriceLbl.Text = String.Format("{0:C2}", RetailPrice);
                    }
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
                bool IsNumber = int.TryParse(SaleQuantityTxt.Text, out TempQty);
                if (!IsNumber)
                {
                    MessageBox.Show("Quantity must be a IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleQuantityTxt.Clear();
                    SaleQuantityTxt.Focus();
                    return false;
                }
                if (TempQty <= 0)
                {
                    MessageBox.Show("Quantity must be a positive IsNumber !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Instantiation of sales object
            ISales sale = ContainerConfig.CreateSales();
            sale.InvoiceNumber = CurrentInvoiceNumber;
            sale.Discount = 1;
            sale.SubTotal = SubTotal;
            sale.Tax = 1;
            sale.Total = Total;
            sale.PaymentMode = "cash";
            sale.SaleOrderDetails = itemsToSave;

            // Instantiation of delivery object
            IDelivery delivery = ContainerConfig.CreateDelivery();
            delivery.DeliveryDate = dateValue;
            delivery.DeliveryType = DeliveryCmb.Text;
            
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

            if(quotationDetails != null)
            {
                //initialize line counter from the last value of the quotation deails
                //populate the list of salelines to save
                itemCounter = itemsToDisplay.Count + 1;
                foreach (var quotation in quotationDetails)
                {
                    //instanciation of saleline object to save into the DB
                    SaleLine saleLine = new SaleLine
                    {
                        SelectedItem = quotation.SelectedItem,
                        RetailPrice = quotation.RetailPrice,
                        SaleQuantity = quotation.QuotationQuantity,
                        LineTotal = quotation.LineTotal
                    };
                    //list of items to save into the DB
                    itemsToSave.Add(saleLine);
                }
                
            }
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
                            row.Cells["LineTotal"].Value = RetailPrice * Convert.ToDecimal(row.Cells["PurchasedQuantity"].Value);
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
                    quotationDetails = null;
                }
                else
                {
                    MessageBox.Show(" There is no enough stock !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleQuantityTxt.Clear();
                    RetailPriceLbl.Text = "0";
                    StockQuantityLbl.Text = "0";
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
        //This method disables the delivery datetimepicker when "cash and carry is selected "
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

        private void QuotationsCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            AddToCartBtn.Enabled = true;
            CashBtn.Enabled = true;
            EFTBtn.Enabled = true;
            PaidTxt.Enabled = true;
            RefundBtn.Enabled = true;
            ResetBtn.Enabled = true;
            quotationDetails = _quotationsProcessor.GetQuotationDetails(((Quotations)QuotationsCmb.SelectedItem).QuotationNumber.ToString());
            itemsToDisplay = new List<OrderCart>();

            int lineCounter = 1;

            foreach (var quotation in quotationDetails)
            {
                OrderCart shoppingCartLine = new OrderCart
                {
                    Id = lineCounter,
                    StockCode = quotation.SelectedItem.StockCode,
                    Descript = quotation.SelectedItem.Descript,
                    PurchasedQuantity = quotation.QuotationQuantity,
                    PurchasePrice = quotation.RetailPrice,
                    LineTotal = quotation.LineTotal
                };
                itemsToDisplay.Add(shoppingCartLine);
                lineCounter += 1;
            }
            ItemsGridView.DataSource = null;
            ItemsGridView.DataSource = itemsToDisplay;
            //hide 2 columns(ItemId,OrderNumber) in the grid

            ItemsGridView.Columns[4].DefaultCellStyle.Format = "c2";
            ItemsGridView.Columns[5].DefaultCellStyle.Format = "c2";

            SubTotal = itemsToDisplay.Sum(x => x.LineTotal);
            Total = SubTotal;
            SubTotalLbl.Text = String.Format("{0:C2}", SubTotal);
            TotalLbl.Text = String.Format("{0:C2}", Total);
            
        }
    

        private void SaleFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
