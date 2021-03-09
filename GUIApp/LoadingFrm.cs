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
    public partial class LoadingFrm : Form
    {
        public LoadingFrm()
        {
            InitializeComponent();
        }
        //This method stops the timer,hides the loading form ,shows the main form and closes the loading form
        private void LoadingFrmTimer_Tick(object sender, EventArgs e)
        {
            LoadingFrmTimer.Stop();
            this.Hide();
            MainFrm mainFrm = new MainFrm();
            mainFrm.ShowDialog();
            this.Close();
        }
    }
}
