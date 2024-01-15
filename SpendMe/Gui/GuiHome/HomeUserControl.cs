using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();
        }

        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }

    }
}
