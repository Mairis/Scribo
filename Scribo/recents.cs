using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Scribo.Properties;

namespace Scribo
{
    class recents
    {
        private Panel recentsPanel = new Panel();
        private Label recentsMainLbl = new Label();

        public recents(bool firstTime)
        {
            if (firstTime)
            {
                recentsPanel.Dock = DockStyle.Bottom;
                recentsPanel.BackColor = Color.FromArgb(68, 68, 68);
                recentsMainLbl.BackColor = Color.Transparent;
                recentsMainLbl.ForeColor = Color.White;
                recentsMainLbl.AutoSize = false;
                recentsMainLbl.Dock = DockStyle.Top;
                recentsMainLbl.Font = new Font("Segoe UI", 14);
                recentsMainLbl.Text = ("Recent documents");
                recentsPanel.Controls.Add(recentsMainLbl);
            }
        }

        public void ShowHideRecents(Form f)
        {
            if (!f.Contains(recentsPanel))
            {
                recentsPanel.Height = f.Height / 3;
                f.Controls.Add(recentsPanel);
                loadRecentDocuments();
            }
            else
            {
                f.Controls.Remove(recentsPanel);
            }
        }

        public void addDocumentToRecent(string path)
        {
            for(int i = 0; i < 5; i++)
            {
                if(Settings.Default.recentDocuments[i] == path && i < 4)
                {
                    break;
                }
                else if(Settings.Default.recentDocuments[i] != path && Settings.Default.recentDocuments[i] == "n")
                {
                    Settings.Default.recentDocuments[i] = path;
                    break;
                }
                else if(Settings.Default.recentDocuments[i] == path && i == 4)
                {

                }
            }
        }

        private void loadRecentDocuments()
        {
            foreach(string s in Settings.Default.recentDocuments)
            {
                if(s != "n")
                {
                    MessageBox.Show(s);
                }
            } 
        }
    }
}
