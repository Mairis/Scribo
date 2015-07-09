using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Scribo
{
    class recents
    {
        private Panel recentsPanel = new Panel();
        private Label recentsMainLbl = new Label();        
        private bool recentsOpen;

        public recents()
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
            loadRecentDocuments(recentsPanel);
        }

        public void ShowHideRecents(Form f)
        {
            if (!recentsOpen)
            {
                recentsPanel.Height = f.Height / 3;
                f.Controls.Add(recentsPanel);
                recentsOpen = true;
                
            }
            else
            {
                f.Controls.Remove(recentsPanel);
                recentsOpen = false;
            }
        }

        private void loadRecentDocuments(Panel p)
        {
          
        }
    }
}
