using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scribo.Properties;

namespace Scribo.Document
{
    class readDoc
    {
        private OpenFileDialog oFD = new OpenFileDialog();

        public readDoc()
        {
            //openfiledialog properties
            oFD.Title = "Select a document...";
            oFD.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
        }

        public void showOfd(TextBox tBox)
        {
            //showing the dialog
            Show: if (oFD.ShowDialog() == DialogResult.OK)
            {
                //attempt to read the file
                try
                {
                    tBox.Text = System.IO.File.ReadAllText(oFD.FileName);
                    //adding the opened file to recents
                    //this will go in recents.cs
                    for (int i = 0; i < 10; i++)
                    {
                        if (Settings.Default.recentDocuments[i] == "n")
                        {
                            Settings.Default.recentDocuments[i] = oFD.FileName;
                            if (i == 9)
                            {
                                string[] tempRecents = 
                                    new string[Settings.Default.recentDocuments.Length];
                                for (int a = 0;  a < Settings.Default.recentDocuments.Length; a++)
                                {
                                    tempRecents[a - 1] = Settings.Default.recentDocuments[a];
                                }
                                Settings.Default.recentDocuments = tempRecents;
                                Settings.Default.recentDocuments[i] = oFD.FileName;
                            }
                            tBox.Text += Settings.Default.recentDocuments[i] + " " + i.ToString();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("Error occoured when trying to read: " + oFD.FileName
                        , "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) 
                        == DialogResult.Retry)
                    {
                        goto Show;
                    }
                }
            }
        }
    }
}
