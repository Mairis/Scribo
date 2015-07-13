using Scribo.Resources;
using Scribo.Document;
using Scribo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scribo
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //Loading the resourceManager and getting the needed resources
            resourceManager rm = new resourceManager();
            this.Icon = rm.mainFormIcon;
            startPage sP = new startPage(true, this);
        }
    }
}
