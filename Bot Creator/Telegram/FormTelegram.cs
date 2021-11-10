using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormTelegram : Form
    {
        public FormTelegram()
        {
            InitializeComponent();
            openChildForm(new FormTelegramMain());
        }

        Templates.TemplateTelegram botTelegram = new Templates.TemplateTelegram();
        public static List<List<string>> data = new List<List<string>>();
        public static List<List<string>> inlineData = new List<List<string>>();
        public static string name, token, startCommand;
        public static bool keyboardCondition;
        public static string[] keyboardButtons = new string[20];
        public static string[] keyboardButtonsColor = new string[20];

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTelegramChildForm.Controls.Add(childForm);
            panelTelegramChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenFormTelegramInline(object sender, EventArgs e)
        {
            openChildForm(new FormTelegramInline());
        }

        private void OpenFormTelegramKeyboard(object sender, EventArgs e)
        {
            openChildForm(new FormTelegramKeyboard());
        }

        private void OpenFormTelegramMain(object sender, EventArgs e)
        {
            openChildForm(new FormTelegramMain());
        }

        private void BotSave(object sender, EventArgs e)
        {
            string[] keyboard = new string[20];
            for (int i = 0; i < keyboard.Length; i++)
            {
                if (!(keyboardButtons[i] == "" || keyboardButtons[i] == null))
                    keyboard[i] = "createButton('" + keyboardButtons[i] + "', '" + keyboardButtonsColor[i] + "'),";
            }

            botTelegram.CreateCode(token, data, startCommand, keyboard, keyboardCondition, inlineData);
            botTelegram.BotSave(name);
        }
    }
}
