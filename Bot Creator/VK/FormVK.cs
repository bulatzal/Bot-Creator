using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormVK : Form
    {
        public FormVK()
        {
            InitializeComponent();
            openChildForm(new FormVKMain());
        }

        Templates.TemplateVK botVK = new Templates.TemplateVK();
        public static List<List<string>> data = new List<List<string>>();
        public static string name, token;
        public static bool keyboardCondition;
        public static string [] keyboardButtons = new string [20];
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
            panelVKChildForm.Controls.Add(childForm);
            panelVKChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenFormVKMain(object sender, EventArgs e)
        {
            openChildForm(new FormVKMain());
        }

        private void OpenFormVKKeyboard(object sender, EventArgs e)
        {
            openChildForm(new FormVKKeyboard());
        }

        private void OpenFormVKInline(object sender, EventArgs e)
        {
            openChildForm(new FormVKInline());
        }

        private void OpenFormVKSettings(object sender, EventArgs e)
        {
            openChildForm(new FormVKSettings());
        }

        private void BotSave(object sender, EventArgs e)
        {
            string[] keyboard = new string[20];
            for (int i = 0; i < keyboard.Length; i++)
            {
                if (!(keyboardButtons[i] == "" || keyboardButtons[i] == null))
                    keyboard[i] = "createButton('" + keyboardButtons[i] + "', '" + keyboardButtonsColor[i] + "'),";
                    
            }

            botVK.CreateCode(token, data, keyboard, keyboardCondition);
            botVK.BotSave(name);
        }
    }
}
