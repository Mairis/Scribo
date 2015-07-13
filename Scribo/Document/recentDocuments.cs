using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Scribo.Properties;

namespace Scribo.Document
{
    class recentDocuments
    {
        private Label recentsMainLbl = new Label();
        private Panel recentsPanel = new Panel();
        private Panel closeRecentsPanel = new Panel();

        public recentDocuments(bool firstTime)
        {
            if (firstTime)
            {
                Scribo.Resources.resourceManager rm = new Scribo.Resources.resourceManager();

                recentsPanel.Dock = DockStyle.Bottom;
                recentsPanel.BackColor = Color.FromArgb(68, 68, 68);
                recentsMainLbl.BackColor = Color.Transparent;
                recentsMainLbl.ForeColor = Color.White;
                recentsMainLbl.AutoSize = false;
                recentsMainLbl.Dock = DockStyle.Top;
                recentsMainLbl.Font = new Font("Segoe UI", 14);
                recentsMainLbl.Text = ("Recent documents: ");
                closeRecentsPanel.BackColor = recentsPanel.BackColor;
                closeRecentsPanel.BackgroundImage = rm.closePnlBackground;
                closeRecentsPanel.Height = recentsMainLbl.Height;
                closeRecentsPanel.Width = closeRecentsPanel.Height;
                closeRecentsPanel.MouseEnter += (object sender, EventArgs e) =>
                { closeRecentsPanel.BackColor = Color.DarkRed; };
                closeRecentsPanel.MouseLeave += (object sender, EventArgs e) =>
                { closeRecentsPanel.BackColor = recentsPanel.BackColor; };
                closeRecentsPanel.Click += (object sender, EventArgs e) =>
                {
                    foreach (Control ctl in recentsPanel.Controls)
                    {
                        if (ctl != recentsMainLbl)
                        {
                            recentsPanel.Controls.Remove(ctl);
                        }
                    }
                    foreach (Control ctl in recentsPanel.Parent.Controls)
                    {
                        ctl.Enabled = true;
                    }
                    recentsPanel.Parent.Controls.Remove(recentsPanel);
                };
                closeRecentsPanel.Dock = DockStyle.Right;
                recentsMainLbl.Controls.Add(closeRecentsPanel);
                
            }
        }

        public void addDocumentToRecent(string path)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Settings.Default.recentDocuments[i] == path)
                {
                    break;
                }
                else if (Settings.Default.recentDocuments[i] != path && Settings.Default.recentDocuments[i] == "n")
                {
                    Settings.Default.recentDocuments[i] = path;
                    break;
                }
                else if (i == 4 && Settings.Default.recentDocuments[i] != path && Settings.Default.recentDocuments[i] != "n")
                {
                    for (int a = 0; a < 5; a++)
                    {
                        if (a < 4)
                        { Settings.Default.recentDocuments[a] = Settings.Default.recentDocuments[a + 1]; }
                        else if (a == 4)
                        { Settings.Default.recentDocuments[a] = path; }
                    }
                }
            }
        }

        public void displayRecentsPanel(Form f)
        {
            foreach (Control ctl in f.Controls)
            {
                ctl.Enabled = false;
            }
            recentsPanel.Height = f.Height / 3;
            f.Controls.Add(recentsPanel);
            addControlsToRecentsPanel(recentsPanel);
        }

        private void addControlsToRecentsPanel(Panel p)
        {
            recentsPanel.Controls.Add(recentsMainLbl);
            for (int i = 0; i < 5; i++)
            {
                if(Settings.Default.recentDocuments[i] != "n")
                {
                    Label recentDocDisplay = new Label();
                    recentDocDisplay.Height = p.Height - recentsMainLbl.Height - 20;
                    recentDocDisplay.Width = (p.Width / 5) - 11;
                    recentDocDisplay.Top = recentsMainLbl.Height + 10;
                    recentDocDisplay.Left = (recentDocDisplay.Width * i) + (10 * (i + 1));
                    recentDocDisplay.BackColor = Color.White;
                    recentDocDisplay.ForeColor = p.BackColor;
                    recentDocDisplay.Font = new Font("Segoe UI", 12);
                    recentDocDisplay.Text = System.IO.File.ReadAllText(Settings.Default.recentDocuments[i]);
                    recentDocDisplay.Anchor = (AnchorStyles.Top & AnchorStyles.Left);
                    p.Controls.Add(recentDocDisplay);
                }
                if(i == 0 && Settings.Default.recentDocuments[0] == "n")
                {
                    recentsMainLbl.Text = "No recents to display";
                }
            }
        }
    }
}