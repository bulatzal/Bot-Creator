using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormVKMain : Form
    {
        public FormVKMain()
        {
            InitializeComponent();
            StartForm();
        }

        public void StartForm()
        {
            textBoxName.Text = FormVK.name;
            textBoxToken.Text = FormVK.token;
            if (FormVK.data != null)
                for (int i = 0; i < FormVK.data.Count; i++)
                    dataGridViewVK.Rows.Add(FormVK.data[i][0], FormVK.data[i][1]);
        }

        private void AddCommand(object sender, EventArgs e)
        {
            if (textBoxCommand.Text != "" & textBoxAnswer.Text != "")
            {
                dataGridViewVK.Rows.Add(textBoxCommand.Text, textBoxAnswer.Text);

                FormVK.data.Add(new List<string>());
                FormVK.data[FormVK.data.Count - 1].Add(textBoxCommand.Text);
                FormVK.data[FormVK.data.Count - 1].Add(textBoxAnswer.Text);
            }
        }

        private void EditName(object sender, EventArgs e)
        {
            FormVK.name = textBoxName.Text;
        }

        private void EditToken(object sender, EventArgs e)
        {
            FormVK.token = textBoxToken.Text;
        }
    }
}
