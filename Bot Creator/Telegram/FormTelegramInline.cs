using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormTelegramInline : Form
    {
        public FormTelegramInline()
        {
            InitializeComponent();
            StartForm();
        }
        public void StartForm()
        {
            if (FormTelegram.inlineData != null)
                for (int i = 0; i < FormTelegram.inlineData.Count; i++)
                    dataGridViewTelegram.Rows.Add(FormTelegram.inlineData[i][0], FormTelegram.inlineData[i][1], FormTelegram.inlineData[i][2], FormTelegram.inlineData[i][3], FormTelegram.inlineData[i][4], FormTelegram.inlineData[i][5]);
        }

        private void AddCommand(object sender, EventArgs e)
        {
            if (textBoxCommand.Text != "" & textBoxAnswer.Text != "" & textBoxButton1.Text != "" & textBoxButton2.Text != "" & textBoxAnswer1.Text != "" & textBoxAnswer2.Text != "")
            {
                dataGridViewTelegram.Rows.Add(textBoxCommand.Text, textBoxAnswer.Text, textBoxButton1.Text, textBoxButton2.Text, textBoxAnswer1.Text, textBoxAnswer2.Text);

                FormTelegram.inlineData.Add(new List<string>());
                FormTelegram.inlineData[FormTelegram.inlineData.Count - 1].Add(textBoxCommand.Text);
                FormTelegram.inlineData[FormTelegram.inlineData.Count - 1].Add(textBoxAnswer.Text);
                FormTelegram.inlineData[FormTelegram.inlineData.Count - 1].Add(textBoxButton1.Text);
                FormTelegram.inlineData[FormTelegram.inlineData.Count - 1].Add(textBoxButton2.Text);
                FormTelegram.inlineData[FormTelegram.inlineData.Count - 1].Add(textBoxAnswer1.Text);
                FormTelegram.inlineData[FormTelegram.inlineData.Count - 1].Add(textBoxAnswer2.Text);
            }
        }
    }
}
