using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroidAppStar
{
    public partial class frmWait : Form
    {
        public Action Worker { get; set; }
        public frmWait(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void frmWait_Load(object sender, EventArgs e)
        {
            //this.TransparencyKey = Color.WhiteSmoke;
            //this.BackColor = Color.WhiteSmoke;
        }
    }
}
