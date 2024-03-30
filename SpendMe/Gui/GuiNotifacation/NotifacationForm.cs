using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpendMe.Gui.GuiNotifacation
{
    public partial class NotifacationForm : Form
    {
        public NotifacationForm()
        {
            InitializeComponent();
            timerNotifacation.Interval = Properties.Settings.Default.HideNotificationInterval*1000;
        }

        private void timerNotifacation_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
