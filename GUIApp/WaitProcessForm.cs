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
    public partial class WaitProcessForm : Form
    {
        private object v;

        public Action Worker { get; set; }
        public WaitProcessForm(Action worker)
        {
            InitializeComponent();
            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
        }

        public WaitProcessForm(object v)
        {
            this.v = v;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(x => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
