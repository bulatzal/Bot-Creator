using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormDiscord : Form
    {
        public FormDiscord()
        {
            InitializeComponent();
            openChildForm(new FormDiscordMain());
        }

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
        private void buttonVKMain_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDiscordMain());
        }

        private void buttonVKSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDiscordSettings());
        }
    }
}
