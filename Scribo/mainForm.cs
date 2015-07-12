using Scribo.Resources;
using Scribo.Document;
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
        private List<Control> startPageCtl = new List<Control>();
        private Image startPageNewImage;
        private Image startPageOpenImage;
        private Image startPageRecentImage;

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
            startPageNewImage = rm.startPageNewImage;
            startPageOpenImage = rm.startPageOpenImage;
            startPageRecentImage = rm.startPageRecentImage;
            loadStartPage(true);
        }

        private void loadStartPage(bool firstTime)
        {
            //Hiding all the previous controls
            this.Controls.Remove(mainTstrip);
            this.Controls.Remove(mainTxtBox);

            for (int i = 0; i < 3; i++)
            {
                if (firstTime)
                {
                    recentDocuments recentDocs = new recentDocuments(true);
                    readDoc readDoc = new readDoc();

                    //Setting up the panel  
                    Panel startPagePnl = new Panel();
                    startPagePnl.Width = this.Width / 3 - 50;
                    startPagePnl.Height = startPagePnl.Width;
                    startPagePnl.Anchor = (AnchorStyles.Top & AnchorStyles.Left);
                    startPagePnl.Top = this.Height / 2 - startPagePnl.Height + 10;
                    startPagePnl.Left = 50;
                    startPagePnl.BackColor = Color.White;

                    //Handling startPagePnl events
                    startPagePnl.MouseEnter += (object sender, EventArgs e) =>
                    { Panel p = (Panel)sender; p.BackColor = Color.LightGray; };
                    startPagePnl.MouseLeave += (object sender, EventArgs e) =>
                    { Panel p = (Panel)sender; p.BackColor = Color.White; };
                    startPagePnl.Click += (object sender, EventArgs e) =>
                    {
                        Panel p = (Panel)sender;
                        if (p.Tag == "newPnl")
                        {
                            loadTextEditor(true);
                        }
                        else if (p.Tag == "openPnl")
                        {
                            loadTextEditor(true);
                            readDoc.showOfd(mainTxtBox);
                        }
                        else if (p.Tag == "recentPnl")
                        {
                            recentDocs.displayRecentsPanel(this);
                        }
                    };

                    //Settings up the picture box
                    PictureBox startPagePicBox = new PictureBox();
                    startPagePicBox.Width = 80;
                    startPagePicBox.Height = 80;
                    startPagePicBox.Left = 18;
                    startPagePicBox.Top = 6;
                    startPagePicBox.BackColor = Color.Transparent;

                    //Handling startPagePicBox events
                    startPagePicBox.MouseEnter += (object sender, EventArgs e) =>
                    { startPagePnl.BackColor = Color.LightGray; };
                    startPagePicBox.MouseLeave += (object sender, EventArgs e) =>
                    { startPagePnl.BackColor = Color.White; };
                    startPagePicBox.Click += (object sender, EventArgs e) =>
                    {
                        PictureBox picBox = (PictureBox)sender;
                        if (picBox.Tag == "newPicBox")
                        {
                            loadTextEditor(true);
                        }
                        else if (picBox.Tag == "openPicBox")
                        {
                            loadTextEditor(true);
                            readDoc.showOfd(mainTxtBox);
                        }
                        else if (picBox.Tag == "recentPicBox")
                        {
                            recentDocs.displayRecentsPanel(this);
                        }
                    };

                    //Setting up the label
                    Label startPageLbl = new Label();
                    startPageLbl.AutoSize = false;
                    startPageLbl.BackColor = Color.Transparent;
                    startPageLbl.Width = startPagePnl.Width;
                    startPageLbl.Height = 22;
                    startPageLbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    startPageLbl.Top = startPageLbl.Height * 4;
                    startPageLbl.TextAlign = ContentAlignment.MiddleCenter;

                    //Handling startPageLbl events
                    startPageLbl.MouseEnter += (object sender, EventArgs e) =>
                    { startPagePnl.BackColor = Color.LightGray; };
                    startPageLbl.MouseLeave += (object sender, EventArgs e) =>
                    { startPagePnl.BackColor = Color.White; };
                    startPageLbl.Click += (object sender, EventArgs e) =>
                    {
                        Label l = (Label)sender;
                        if (l.Tag == "newLbl")
                        {
                            loadTextEditor(true);
                        }
                        else if (l.Tag == "openLbl")
                        {
                            loadTextEditor(true);
                            readDoc.showOfd(mainTxtBox);
                        }
                        else if (l.Tag == "recentLbl")
                        {
                            recentDocs.displayRecentsPanel(this);
                        }
                    };

                    //Adding controls to their parents
                    this.Controls.Add(startPagePnl);
                    startPagePnl.Controls.Add(startPagePicBox);
                    startPagePnl.Controls.Add(startPageLbl);

                    //A few individual properties
                    switch (i)
                    {
                        case (0):
                            startPagePicBox.Image = startPageNewImage;
                            startPageLbl.Text = "New";
                            startPagePnl.Tag = "newPnl";
                            startPagePicBox.Tag = "newPicBox";
                            startPageLbl.Tag = "newLbl";
                            break;
                        case (1):
                            startPagePnl.Left = startPagePnl.Left + startPagePnl.Width + 20;
                            startPagePicBox.Image = startPageOpenImage;
                            startPageLbl.Text = "Open";
                            startPagePnl.Tag = "openPnl";
                            startPagePicBox.Tag = "openPicBox";
                            startPageLbl.Tag = "openLbl";
                            break;
                        case (2):
                            startPagePnl.Left = startPagePnl.Left * 2 + startPagePnl.Width * 2 - 10;
                            startPagePicBox.Image = startPageRecentImage;
                            startPageLbl.Text = "Open recent";
                            startPagePnl.Tag = "recentPnl";
                            startPagePicBox.Tag = "recentPicBox";
                            startPageLbl.Tag = "recentLbl";
                            break;
                    }

                    foreach (Control ctl in this.Controls)
                    {
                        if (ctl.Visible)
                        {
                            startPageCtl.Add(ctl);
                        }
                    }
                }
                else
                {
                    this.Controls.Remove(mainTstrip);
                    this.Controls.Remove(mainTxtBox);
                    foreach (Control ctl in startPageCtl)
                    {
                        this.Controls.Add(ctl);
                    }
                }
            }
        }

        private void loadTextEditor(bool clearText)
        {
            if (clearText)
            {
                mainTxtBox.Text = "";
            }
            foreach (Control ctl in startPageCtl)
            {
                this.Controls.Remove(ctl);
            }
            this.Controls.Add(mainTstrip);
            this.Controls.Add(mainTxtBox);
        }

        private void toolStripBackBtn_Click(object sender, EventArgs e)
        {
            loadStartPage(false);
        }
    }
}
