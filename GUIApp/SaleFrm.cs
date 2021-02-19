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
using LogicLibrary.Processes;

namespace GUIApp
{
    public partial class SaleFrm : Form
    {
        List<Item> listItems ;
        public SaleFrm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            listItems = new List<Item>();
            listItems = ItemProcessor.LoadData();
            ItemsListBox.DataSource = listItems;
            ItemsListBox.DisplayMember = "Descript";
            ItemsListBox.ValueMember = "ItemId";
        }
    }
}
