using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Scribo.UI
{
    class startPage
    {
        private List<Control> startPageCtl = new List<Control>();

        public startPage(bool firstTime, Form mainForm)
        {
            if (firstTime)
            {
                loadStartPage(mainForm);
            }
            else
            {
                addStartPageCtl(mainForm);
            }
        }

        private void loadStartPage(Form f)
        {
            for(int i = 0; i < 3; i++)
            {
                Document.recentDocuments rD = new Document.recentDocuments(true);
                Document.readDoc readDoc = new Document.readDoc();
                Resources.resourceManager rM = new Resources.resourceManager();

                //Setting up the panel  
                Panel startPagePnl = new Panel();
                startPagePnl.Width = f.Width / 3 - 50;
                startPagePnl.Height = startPagePnl.Width;
                startPagePnl.Anchor = (AnchorStyles.Top & AnchorStyles.Left);
                startPagePnl.Top = f.Height / 2 - startPagePnl.Height + 10;
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
                    }
                    else if (p.Tag == "openPnl")
                    {
                    }
                    else if (p.Tag == "recentPnl")
                    {
                        rD.displayRecentsPanel(f);
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
                    }
                    else if (picBox.Tag == "openPicBox")
                    {
                    }
                    else if (picBox.Tag == "recentPicBox")
                    {
                        rD.displayRecentsPanel(f);
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
                    }
                    else if (l.Tag == "openLbl")
                    {
                        rD.displayRecentsPanel(f);
                    }
                    else if (l.Tag == "recentLbl")
                    {
                    }
                };

                //Adding controls to their parents
                f.Controls.Add(startPagePnl);
                startPagePnl.Controls.Add(startPagePicBox);
                startPagePnl.Controls.Add(startPageLbl);

                switch (i)
                {
                    case (0):
                        startPagePicBox.Image = rM.startPageNewImage;
                        startPageLbl.Text = "New";
                        startPagePnl.Tag = "newPnl";
                        startPagePicBox.Tag = "newPicBox";
                        startPageLbl.Tag = "newLbl";
                        break;
                    case (1):
                        startPagePnl.Left = startPagePnl.Left + startPagePnl.Width + 20;
                        startPagePicBox.Image = rM.startPageOpenImage;
                        startPageLbl.Text = "Open";
                        startPagePnl.Tag = "openPnl";
                        startPagePicBox.Tag = "openPicBox";
                        startPageLbl.Tag = "openLbl";
                        break;
                    case (2):
                        startPagePnl.Left = startPagePnl.Left * 2 + startPagePnl.Width * 2 - 10;
                        startPagePicBox.Image = rM.startPageRecentImage;
                        startPageLbl.Text = "Open recent";
                        startPagePnl.Tag = "recentPnl";
                        startPagePicBox.Tag = "recentPicBox";
                        startPageLbl.Tag = "recentLbl";
                        break;
                }

                foreach (Control ctl in f.Controls)
                {
                    if (ctl.Visible)
                    {
                        startPageCtl.Add(ctl);
                    }
                }
            }
        }

        private void addStartPageCtl(Form f)
        {
            foreach (Control ctl in f.Controls)
            {
                f.Controls.Remove(ctl);
            }
            foreach (Control ctl in startPageCtl)
            {
                f.Controls.Add(ctl);
            }
        }

        private void removeStartPageCtl()
        {

        }
    }
}
