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
    public partial class LoadingFrmTwo : Form
    {
        public LoadingFrmTwo()
        {
            InitializeComponent();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            SecondPanel.Width += 3;
            if (SecondPanel.Width >=520)
            {
                LoadingTimer.Stop();
                this.Hide();
                MainFrm mf = new MainFrm();
                mf.ShowDialog();
                this.Close();
            }
        }
    }
}
