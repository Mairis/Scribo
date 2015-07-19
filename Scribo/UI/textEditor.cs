using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Scribo.UI
{
    class textEditor
    {

        private Panel topPanel = new Panel();
        private TextBox mainTextBox = new TextBox();
        private List<Control> textEditorCtl = new List<Control>();

        public void addControlsToForm(bool firstTime, Form f)
        {
            if (firstTime)
            {
                setProperties();
                addItemsToPanel(topPanel);
                f.Controls.Add(mainTextBox);
                f.Controls.Add(topPanel);
            }
            else
            {
                topPanel.Show();
                mainTextBox.Show();
            }
        }

        private void setProperties()
        {
            topPanel.Height = 74;
            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.White;
            mainTextBox.Multiline = true;
            mainTextBox.Dock = DockStyle.Fill;
        }

        private void addItemsToPanel(Panel p)
        {
            Scribo.UI.Contorls.topPanelItem item = new Scribo.UI.Contorls.topPanelItem();
            item.Text = "Back";
            item.Click += Item_Click;
            p.Controls.Add(item);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in topPanel.Parent.Controls)
            {
                if (ctl.Tag != "startPage")
                {
                    ctl.Hide();
                }
                else
                {
                    ctl.Show();
                }
            }
        }
    }
}
