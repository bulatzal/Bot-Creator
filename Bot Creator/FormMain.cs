using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            HideAllSubPanels();
        }
        private void LogoClick(object sender, EventArgs e)
        {
            HideSubPanel();
            if (activeForm != null)
                activeForm.Close();
        }

        private void HideAllSubPanels()
        {
            panelVK.Visible = false;
            panelTelegram.Visible = false;
            panelDiscord.Visible = false;
        }

        private void HideSubPanel()
        {
            if (panelVK.Visible == true)
                panelVK.Visible = false;
            if (panelTelegram.Visible == true)
                panelTelegram.Visible = false;
            if (panelDiscord.Visible == true)
                panelDiscord.Visible = false;
        }

        private void ShowSubPanel(Panel choosenPanel)
        {
            if (choosenPanel.Visible == false)
            {
                HideSubPanel();
                choosenPanel.Visible = true;
            }
            else
                choosenPanel.Visible = false;
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region VK
        private void buttonVK_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelVK);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVK());
            HideSubPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code
            HideSubPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Code
            HideSubPanel();
        }
        #endregion

        #region Telegram
        private void buttonTelegram_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelTelegram);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTelegram());
            HideSubPanel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Code
            HideSubPanel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code
            HideSubPanel();
        }
        #endregion

        #region Discord
        private void buttonDiscord_Click(object sender, EventArgs e)
        {
            ShowSubPanel(panelDiscord);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDiscord());
            HideSubPanel();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Code
            HideSubPanel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Code
            HideSubPanel();
        }
        #endregion

        
    }
}
