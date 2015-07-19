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

        public void showOfd(TextBox tBox, Form mainForm)
        {

            recentDocuments recents = new recentDocuments();

            //showing the dialog
            Show: if (oFD.ShowDialog() == DialogResult.OK)
            {
                //attempt to read the file
                try
                {
                    tBox.Text = System.IO.File.ReadAllText(oFD.FileName);
                    recents.addDocumentToRecent(oFD.FileName);  
                }
                catch
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