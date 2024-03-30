using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SpendMe.Properties;
namespace SpendMe.Code
{
    public static class MessageCollections
    {
        // Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorServer()
        {
            MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFiledsRquired()
        {
            MessageBox.Show(Resources.FiledsReqText, Resources.FiledReqCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowRquiredDeleteRow()
        {
            MessageBox.Show(Resources.ShowReDeleteFiledText, Resources.ShowReDeleteFiledCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Dialog
        public static bool ShowDeleteDialog()
        {
            var result= MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Notifecaitions
        public static void ShowAddNotification()
        {
            Gui.GuiNotifacation.NotifacationForm notifacationForm = new Gui.GuiNotifacation.NotifacationForm();
            notifacationForm.labelTitle.Text = "Процесс добавления успешно завершен";
            notifacationForm.Show();
        }
        public static void ShowUpdateNotification()
        {
            Gui.GuiNotifacation.NotifacationForm notifacationForm = new Gui.GuiNotifacation.NotifacationForm();
            notifacationForm.labelTitle.Text = "Процесс модификации успешно завершен";
            notifacationForm.Show();
        }
        public static void ShowDeleteNotification()
        {
            Gui.GuiNotifacation.NotifacationForm notifacationForm = new Gui.GuiNotifacation.NotifacationForm();
            notifacationForm.labelTitle.Text = "Удаление завершено успешно";
            notifacationForm.Show();
        }
    }
}
