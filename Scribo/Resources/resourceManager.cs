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
        private string defaultResDir = 
            System.IO.Directory.GetCurrentDirectory() + @"\Resources\default\";
        private string defaultStartPageResDir =
            System.IO.Directory.GetCurrentDirectory() + @"\Resources\default\startPage\";
        private string defaultTopPanelResDir = 
            System.IO.Directory.GetCurrentDirectory() + @"\Resources\default\topPanel\";

        public Icon mainFormIcon
        {
            get
            {
                return new Icon(defaultResDir + @"scriboIconSmall.ico");
            } 
        }

        #region startPage
        public Image startPageNewImage
        {
            get
            {
                return Image.FromFile(defaultStartPageResDir + @"startPageNewImage.png");
            }
        }

        public Image startPageOpenImage
        {
            get
            {
                return Image.FromFile(defaultStartPageResDir + @"startPageOpenImage.png");
            }
        }

        public Image startPageRecentImage
        {
            get
            {
                return Image.FromFile(defaultStartPageResDir + @"startPageRecentImage.png");
            }
        }
        #endregion

        #region topPanel
        public Image topPanelBackImage
        {
            get
            {
                return Image.FromFile(defaultTopPanelResDir + @"backBtnImage.png");
            }
        }
        #endregion
    }
}
