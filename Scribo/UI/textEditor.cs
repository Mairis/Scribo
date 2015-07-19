using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Scribo.UI.Contorls;

namespace Scribo.UI
{
    class textEditor
    {
        private Panel topPanel = new Panel();
        private TextBox mainTextBox = new TextBox();
        private List<Control> textEditorCtl = new List<Control>();

        public textEditor()
        {
            addItemsToPanel(topPanel);
            setProperties();
        }

        public void addControlsToForm(Form f)
        {
            if (!f.Contains(mainTextBox))
            {
                f.Controls.Add(mainTextBox);
                mainTextBox.Show();
            }
            if (!f.Contains(topPanel))
            {               
                f.Controls.Add(topPanel);
                topPanel.Show();
            }
            else
            {
                topPanel.Show();
                mainTextBox.Show();
            }
        }

        private void setProperties()
        {
            topPanel.Height = 57;
            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.White;
            mainTextBox.Multiline = true;
            mainTextBox.Dock = DockStyle.Fill;
            mainTextBox.Hide();
            topPanel.Hide();
        }

        private void addItemsToPanel(Panel p)
        {
            Resources.resourceManager rM = new Resources.resourceManager();
            for (int i = 0; i < 4; i++)
            {
                topPanelItem item = new topPanelItem();
                switch (i)
                {
                    case (0):
                        item.Text = "Back";
                        item.Image = rM.topPanelBackImage;
                        break;
                    case (1):
                        item.Text = "New";
                        item.Left = 50;
                        break;
                    case (2):
                        item.Text = "Open";
                        item.Left = 98;
                        break;
                    case (3):
                        item.Text = "Save";
                        item.Left = 146;
                        break;
                }
                item.Click += Item_Click;
                topPanel.Controls.Add(item);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {

            topPanelItem item = (topPanelItem)sender;
            switch (item.Text)
            {
                case ("Back"):
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
                    break;
            }
        }
    }
}
