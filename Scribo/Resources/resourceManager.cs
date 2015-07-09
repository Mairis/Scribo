using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scribo.Resources
{
    class resourceManager
    {
        /// <summary>
        /// This will be become the theme manager one day
        /// </summary>
        private string resDir = 
            System.IO.Directory.GetCurrentDirectory() + @"\Resources\";

        public resourceManager()
        {
        }

        public Icon mainFormIcon
        {
            get
            {
                return new Icon(resDir + @"default\scriboIconSmall.ico");
            } 
        }

        public Image startPageNewImage
        {
            get
            {
                return Image.FromFile(resDir + @"default\startPageNewImage.png");
            }
        }

        public Image startPageOpenImage
        {
            get
            {
                return Image.FromFile(resDir + @"default\startPageOpenImage.png");
            }
        }

        public Image startPageRecentImage
        {
            get
            {
                return Image.FromFile(resDir + @"default\startPageRecentImage.png");
            }
        }
    }
}
