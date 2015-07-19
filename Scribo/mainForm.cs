using Scribo.Document;
using Scribo.Resources;
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
        private textEditor tE = new textEditor();
        private recentDocuments rD = new recentDocuments();

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
            newBtn.Image = rm.startPageNewImage;
            openBtn.Image = rm.startPageOpenImage;
            recentBtn.Image = rm.startPageRecentImage;
            newBtn.Click += NewBtn_Click;
            recentsPanel.VisibleChanged += RecentsPanel_VisibleChanged;
            recentBtn.Click += RecentBtn_Click;

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            removeAllControls();
            tE.addControlsToForm(this);     
        }

        private void RecentBtn_Click(object sender, EventArgs e)
        {
            if (recentsPanel.Visible)
            {
                recentsPanel.Visible = false;
            }
            else
            {
                recentsPanel.Visible = true;
            }
        }

        private void RecentsPanel_VisibleChanged(object sender, EventArgs e)
        {       
            if (recentsPanel.Visible)
            {
                foreach (Control ctl in this.Controls)
                {
                    if (ctl != recentsPanel)
                    {
                        ctl.Top -= 40;
                    }
                }
                rD.addRecentsToPanel(recentsPanel);
            }
            else
            {
                foreach (Control ctl in this.Controls)
                {
                    if (ctl != recentsPanel)
                    {
                        ctl.Top += 40;
                    }
                }
                rD.removeRecentsFromPanel(recentsPanel);
            }
        }

        private void removeAllControls()
        {
            if (recentsPanel.Visible)
            {
                recentsPanel.Visible = false;
            }
            foreach(Control ctl in this.Controls)
            {
                ctl.Hide();
            }
        }
    }
}
