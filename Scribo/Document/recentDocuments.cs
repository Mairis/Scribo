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

        public void addRecentsToPanel(Panel p)
        {
            for (int i = 0; i < 5; i++)
            {
                if(Settings.Default.recentDocuments[i] != "n")
                {
                    Label recentDocDisplay = new Label();
                    recentDocDisplay.Height = p.Height - 26 - 20;
                    recentDocDisplay.Width = (p.Width / 5) - 11;
                    recentDocDisplay.Top = 26 + 10;
                    recentDocDisplay.Left = (recentDocDisplay.Width * i) + (10 * (i + 1));
                    recentDocDisplay.BackColor = Color.White;
                    recentDocDisplay.ForeColor = p.BackColor;
                    recentDocDisplay.Font = new Font("Segoe UI", 12);
                    recentDocDisplay.Text = System.IO.File.ReadAllText(Settings.Default.recentDocuments[i]);
                    recentDocDisplay.Anchor = (AnchorStyles.Top & AnchorStyles.Left);
                    p.Controls.Add(recentDocDisplay);
                }
            }
        }

        public void removeRecentsFromPanel(Panel p)
        {
            foreach (Control ctl in p.Controls)
            {
                if (ctl.Tag != "lbl")
                {
                    p.Controls.Remove(ctl);
                }
            }
        }
    }
}