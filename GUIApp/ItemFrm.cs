using DataLibrary.Data;
using DataLibrary.Models;
using LogicLibrary;
using LogicLibrary.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUIApp
{
    public partial class ItemFrm : Form
    {
        ICategoryProcessor _categoryProcessor;
        IItemProcessor _itemProcessor;
        List<Category> categories;
        List<Item> items;
        public ItemFrm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _categoryProcessor = ContainerConfig.CreateCategoryProcessor();
            _itemProcessor = ContainerConfig.CreateItemProcessor();
            categories = new List<Category>();
            items = new List<Item>();
            categories = null;
            items = null;
            items = _itemProcessor.GetItems();
            categories = _categoryProcessor.GetCategories();
            UpdateItemCmb.DataSource = items;
            UpdateItemCmb.DisplayMember = "Descript";
            UpdateItemCmb.ValueMember = "ItemId";
            ListCategoryCmb.DataSource = categories;
            ItemsGridView.DataSource = items;
            ItemsGridView.Columns[2].Visible = false;
            ItemsGridView.Columns[5].Visible = false;
            ItemsGridView.Columns[6].Visible = false;
            ListCategoryCmb.DisplayMember = "CategoryName";
            ListCategoryCmb.ValueMember = "CategoryId";
            HightlightInactiveItems();
        }

        private void ItemFrm_Load(object sender, EventArgs e)
        {
            StockCodeTxt.Focus();
            HightlightInactiveItems();
        }

        private void SaveItemBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                int IsCheccked = 1;
                if (IsActiveChkBtn.Checked == false)
                {
                    IsCheccked = 0;
                }

                IItem item = ContainerConfig.CreateItem();
                item.StockCode = StockCodeTxt.Text;
                item.Descript = DescriptTxt.Text;
                item.Vat = int.Parse(TaxTxt.Text);
                item.CategoryId = int.Parse(ListCategoryCmb.SelectedValue.ToString());
                item.IsActive = IsCheccked;
                item.ReOrderlevel = int.Parse(ReorderLevelTxt.Text);
                _itemProcessor.SaveItem(item);
                MessageBox.Show(" 1 Record Has been added successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StockCodeTxt.Clear();
                StockCodeTxt.Focus();
                DescriptTxt.Clear();
                ListCategoryCmb.SelectedIndex = -1;
                IsActiveChkBtn.Checked = false;
                Initialize();
            }
        }
        private bool IsValid()
        {
            if (StockCodeTxt.Text == string.Empty)
            {
                MessageBox.Show("The Stock Code is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StockCodeTxt.Focus();
                return false;
            }
            
            if (DescriptTxt.Text == string.Empty)
            {
                MessageBox.Show("The Description is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescriptTxt.Focus();
                return false;
            }
            if (TaxTxt.Text == string.Empty)
            {
                MessageBox.Show("The tax is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaxTxt.Focus();
                return false;
            }
            else
            {
                int TempUnitPrice;
                bool IsDecimalNumber = int.TryParse(TaxTxt.Text, out TempUnitPrice);
                if (!IsDecimalNumber)
                {
                    MessageBox.Show("Tax must be a number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TaxTxt.Clear();
                    TaxTxt.Focus();
                    return false;
                }
                if (TempUnitPrice < 0)
                {
                    MessageBox.Show("Tax must be a positive number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TaxTxt.Clear();
                    TaxTxt.Focus();
                    return false;
                }
            }
            if (ReorderLevelTxt.Text == string.Empty)
            {
                MessageBox.Show("Reorder Level is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReorderLevelTxt.Focus();
                return false;
            }
            else
            {
                int TempUnitPrice;
                bool deciml = int.TryParse(ReorderLevelTxt.Text, out TempUnitPrice);
                if (!deciml)
                {
                    MessageBox.Show("Tax must be a number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReorderLevelTxt.Clear();
                    ReorderLevelTxt.Focus();
                    return false;
                }
                if (TempUnitPrice < 0)
                {
                    MessageBox.Show("Reorder Level must be a positive number !", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReorderLevelTxt.Clear();
                    ReorderLevelTxt.Focus();
                    return false;
                }
            }

            if (ListCategoryCmb.SelectedIndex == -1)
            {
                MessageBox.Show("The Category is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ListCategoryCmb.Focus();
                return false;
            }
            return true;
        }

        private void SaveCategoryBtn_Click(object sender, EventArgs e)
        {
            if (CategoryNameTxt.Text == string.Empty)
            {
                MessageBox.Show("The Category Name is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryNameTxt.Focus();
            }
            else
            {
                ICategory category = ContainerConfig.CreateCategory();
                category.CategoryName = CategoryNameTxt.Text;
                _categoryProcessor.SaveCategory(category);
                MessageBox.Show(" 1 Record Has been added successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryNameTxt.Clear();
                CategoryNameTxt.Focus();
                Initialize();
            }

        }

        
        private void HightlightInactiveItems()
        {

            if (ItemsGridView.DataSource != null)
            {
                if (ItemsGridView.Rows.Count > 0)
                {
                    
                    foreach (DataGridViewRow row in ItemsGridView.Rows)
                    {
                        if (int.Parse(row.Cells["IsActive"].Value.ToString()) == 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Coral;
                        }
                    }
                }
            }

        }

        private void UpdateIsActiveBtn_Click(object sender, EventArgs e)
        {
            if (UpdateItemCmb.Text == string.Empty)
            {
                MessageBox.Show(" Select an Item Please ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateItemCmb.Focus();
            }
            else
            {
                if (UpdateItemStatusChk.Checked == true)
                {
                    _itemProcessor.UpdateItemStatus(int.Parse(UpdateItemCmb.SelectedValue.ToString()), 1);
                    MessageBox.Show(" The Item has been activated successfully ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateItemStatusChk.Checked = false;
                }
                else
                {
                    _itemProcessor.UpdateItemStatus(int.Parse(UpdateItemCmb.SelectedValue.ToString()), 0);
                    MessageBox.Show(" The Item has been Deactivated successfully ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateItemStatusChk.Checked = false;
                }
                
                Initialize();
                HightlightInactiveItems();
            }
        }

        private void FilterByStockCodeTxt_TextChanged(object sender, EventArgs e)
        {
            ItemsGridView.DataSource = items.Where(x => x.StockCode.Contains ((FilterByStockCodeTxt.Text).ToUpper())).ToList();
            HightlightInactiveItems();
        }

        private void PrintPreviewBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
