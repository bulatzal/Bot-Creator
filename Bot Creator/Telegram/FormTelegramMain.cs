using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormTelegramMain : Form
    {
        public FormTelegramMain()
        {
            InitializeComponent();
            StartForm();
        }

        public void StartForm()
        {
            textBoxName.Text = FormTelegram.name;
            textBoxToken.Text = FormTelegram.token;
            textBoxStartCommand.Text = FormTelegram.startCommand;
            if (FormTelegram.data != null)
                for (int i = 0; i < FormTelegram.data.Count; i++)
                    dataGridViewTelegram.Rows.Add(FormTelegram.data[i][0], FormTelegram.data[i][1]);
        }

        private void EditName(object sender, EventArgs e)
        {
            FormTelegram.name = textBoxName.Text;
        }

        private void EditToken(object sender, EventArgs e)
        {
            FormTelegram.token = textBoxToken.Text;
        }

        private void EditStartCommand(object sender, EventArgs e)
        {
            FormTelegram.startCommand = textBoxStartCommand.Text;
        }

        private void AddCommand(object sender, EventArgs e)
        {
            if (textBoxCommand.Text != "" & textBoxAnswer.Text != "")
            {
                dataGridViewTelegram.Rows.Add(textBoxCommand.Text, textBoxAnswer.Text);

                FormTelegram.data.Add(new List<string>());
                FormTelegram.data[FormTelegram.data.Count - 1].Add(textBoxCommand.Text);
                FormTelegram.data[FormTelegram.data.Count - 1].Add(textBoxAnswer.Text);
            }
        }
    }
}
