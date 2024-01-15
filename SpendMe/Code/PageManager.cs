using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SpendMe.Code
{
    public class PageManager
    {
        private readonly Main main;
        public PageManager(Main main)
        {
            this.main = main;
        }

        public void LoadPage(UserControl PageUserControl)
        {
            // Load old page
            var OldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (OldPage != null)
            {
                main.panelContainer.Controls.Remove(OldPage);  //Remove Old Page
                OldPage.Dispose(); 
            }

            //Load New Page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);

        }
    }
}
