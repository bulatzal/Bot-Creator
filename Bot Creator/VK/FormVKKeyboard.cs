using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bot_Creator
{
    public partial class FormVKKeyboard : Form
    {
        public FormVKKeyboard()
        {
            InitializeComponent();
            StartForm();
        }

        public void StartForm()
        {
            checkBoxKeyboard.Checked = FormVK.keyboardCondition;

            if (FormVK.keyboardButtons != null)
            {
                textBoxKeyboardButton1.Text = FormVK.keyboardButtons[0];
                textBoxKeyboardButton2.Text = FormVK.keyboardButtons[1];
                textBoxKeyboardButton3.Text = FormVK.keyboardButtons[2];
                textBoxKeyboardButton4.Text = FormVK.keyboardButtons[3];
                textBoxKeyboardButton5.Text = FormVK.keyboardButtons[4];
                textBoxKeyboardButton6.Text = FormVK.keyboardButtons[5];
                textBoxKeyboardButton7.Text = FormVK.keyboardButtons[6];
                textBoxKeyboardButton8.Text = FormVK.keyboardButtons[7];
                textBoxKeyboardButton9.Text = FormVK.keyboardButtons[8];
                textBoxKeyboardButton10.Text = FormVK.keyboardButtons[9];
                textBoxKeyboardButton11.Text = FormVK.keyboardButtons[10];
                textBoxKeyboardButton12.Text = FormVK.keyboardButtons[11];
                textBoxKeyboardButton13.Text = FormVK.keyboardButtons[12];
                textBoxKeyboardButton14.Text = FormVK.keyboardButtons[13];
                textBoxKeyboardButton15.Text = FormVK.keyboardButtons[14];
                textBoxKeyboardButton16.Text = FormVK.keyboardButtons[15];
                textBoxKeyboardButton17.Text = FormVK.keyboardButtons[16];
                textBoxKeyboardButton18.Text = FormVK.keyboardButtons[17];
                textBoxKeyboardButton19.Text = FormVK.keyboardButtons[18];
                textBoxKeyboardButton20.Text = FormVK.keyboardButtons[19];
            }

            bool keyboardColorCondition = true;
            for (int i = 0; i < FormVK.keyboardButtonsColor.Length; i++)
            {
                if (FormVK.keyboardButtonsColor[i] != null)
                    keyboardColorCondition = false;
            }

            if (keyboardColorCondition == true)
            {
                comboBoxKeyboardButtonColor1.SelectedIndex = 0;
                comboBoxKeyboardButtonColor2.SelectedIndex = 0;
                comboBoxKeyboardButtonColor3.SelectedIndex = 0;
                comboBoxKeyboardButtonColor4.SelectedIndex = 0;
                comboBoxKeyboardButtonColor5.SelectedIndex = 0;
                comboBoxKeyboardButtonColor6.SelectedIndex = 0;
                comboBoxKeyboardButtonColor7.SelectedIndex = 0;
                comboBoxKeyboardButtonColor8.SelectedIndex = 0;
                comboBoxKeyboardButtonColor9.SelectedIndex = 0;
                comboBoxKeyboardButtonColor10.SelectedIndex = 0;
                comboBoxKeyboardButtonColor11.SelectedIndex = 0;
                comboBoxKeyboardButtonColor12.SelectedIndex = 0;
                comboBoxKeyboardButtonColor13.SelectedIndex = 0;
                comboBoxKeyboardButtonColor14.SelectedIndex = 0;
                comboBoxKeyboardButtonColor15.SelectedIndex = 0;
                comboBoxKeyboardButtonColor16.SelectedIndex = 0;
                comboBoxKeyboardButtonColor17.SelectedIndex = 0;
                comboBoxKeyboardButtonColor18.SelectedIndex = 0;
                comboBoxKeyboardButtonColor19.SelectedIndex = 0;
                comboBoxKeyboardButtonColor20.SelectedIndex = 0;
            }
            else
            {
                comboBoxKeyboardButtonColor1.SelectedItem = FormVK.keyboardButtonsColor[0];
                comboBoxKeyboardButtonColor2.SelectedItem = FormVK.keyboardButtonsColor[1];
                comboBoxKeyboardButtonColor3.SelectedItem = FormVK.keyboardButtonsColor[2];
                comboBoxKeyboardButtonColor4.SelectedItem = FormVK.keyboardButtonsColor[3];
                comboBoxKeyboardButtonColor5.SelectedItem = FormVK.keyboardButtonsColor[4];
                comboBoxKeyboardButtonColor6.SelectedItem = FormVK.keyboardButtonsColor[5];
                comboBoxKeyboardButtonColor7.SelectedItem = FormVK.keyboardButtonsColor[6];
                comboBoxKeyboardButtonColor8.SelectedItem = FormVK.keyboardButtonsColor[7];
                comboBoxKeyboardButtonColor9.SelectedItem = FormVK.keyboardButtonsColor[8];
                comboBoxKeyboardButtonColor10.SelectedItem = FormVK.keyboardButtonsColor[9];
                comboBoxKeyboardButtonColor11.SelectedItem = FormVK.keyboardButtonsColor[10];
                comboBoxKeyboardButtonColor12.SelectedItem = FormVK.keyboardButtonsColor[11];
                comboBoxKeyboardButtonColor13.SelectedItem = FormVK.keyboardButtonsColor[12];
                comboBoxKeyboardButtonColor14.SelectedItem = FormVK.keyboardButtonsColor[13];
                comboBoxKeyboardButtonColor15.SelectedItem = FormVK.keyboardButtonsColor[14];
                comboBoxKeyboardButtonColor16.SelectedItem = FormVK.keyboardButtonsColor[15];
                comboBoxKeyboardButtonColor17.SelectedItem = FormVK.keyboardButtonsColor[16];
                comboBoxKeyboardButtonColor18.SelectedItem = FormVK.keyboardButtonsColor[17];
                comboBoxKeyboardButtonColor19.SelectedItem = FormVK.keyboardButtonsColor[18];
                comboBoxKeyboardButtonColor20.SelectedItem = FormVK.keyboardButtonsColor[19];
            }
        }

        private void EnableKeyboard(object sender, EventArgs e)
        {
            FormVK.keyboardCondition = checkBoxKeyboard.Checked;

            textBoxKeyboardButton1.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton2.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton3.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton4.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton5.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton6.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton7.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton8.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton9.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton10.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton11.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton12.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton13.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton14.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton15.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton16.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton17.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton18.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton19.Enabled = FormVK.keyboardCondition;
            textBoxKeyboardButton20.Enabled = FormVK.keyboardCondition;

            comboBoxKeyboardButtonColor1.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor2.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor3.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor4.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor5.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor6.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor7.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor8.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor9.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor10.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor11.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor12.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor13.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor14.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor15.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor16.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor17.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor18.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor19.Enabled = FormVK.keyboardCondition;
            comboBoxKeyboardButtonColor20.Enabled = FormVK.keyboardCondition;
        }

        private void EditKeyboardButton1(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[0] = textBoxKeyboardButton1.Text;
        }
        private void EditKeyboardButton2(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[1] = textBoxKeyboardButton2.Text;
        }

        private void EditKeyboardButton3(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[2] = textBoxKeyboardButton3.Text;
        }

        private void EditKeyboardButton4(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[3] = textBoxKeyboardButton4.Text;
        }

        private void EditKeyboardButton5(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[4] = textBoxKeyboardButton5.Text;
        }

        private void EditKeyboardButton6(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[5] = textBoxKeyboardButton6.Text;
        }

        private void EditKeyboardButton7(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[6] = textBoxKeyboardButton7.Text;
        }

        private void EditKeyboardButton8(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[7] = textBoxKeyboardButton8.Text;
        }

        private void EditKeyboardButton9(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[8] = textBoxKeyboardButton9.Text;
        }

        private void EditKeyboardButton10(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[9] = textBoxKeyboardButton10.Text;
        }

        private void EditKeyboardButton11(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[10] = textBoxKeyboardButton11.Text;
        }

        private void EditKeyboardButton12(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[11] = textBoxKeyboardButton12.Text;
        }

        private void EditKeyboardButton13(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[12] = textBoxKeyboardButton13.Text;
        }

        private void EditKeyboardButton14(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[13] = textBoxKeyboardButton14.Text;
        }

        private void EditKeyboardButton15(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[14] = textBoxKeyboardButton15.Text;
        }
        private void EditKeyboardButton16(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[15] = textBoxKeyboardButton16.Text;
        }

        private void EditKeyboardButton17(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[16] = textBoxKeyboardButton17.Text;
        }

        private void EditKeyboardButton18(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[17] = textBoxKeyboardButton18.Text;
        }

        private void EditKeyboardButton19(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[18] = textBoxKeyboardButton19.Text;
        }

        private void EditKeyboardButton20(object sender, EventArgs e)
        {
            FormVK.keyboardButtons[19] = textBoxKeyboardButton20.Text;
        }

        private void EditKeyboardButton1Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[0] = comboBoxKeyboardButtonColor1.SelectedItem.ToString();
        }

        private void EditKeyboardButton2Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[1] = comboBoxKeyboardButtonColor2.SelectedItem.ToString();
        }

        private void EditKeyboardButton3Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[2] = comboBoxKeyboardButtonColor3.SelectedItem.ToString();
        }

        private void EditKeyboardButton4Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[3] = comboBoxKeyboardButtonColor4.SelectedItem.ToString();
        }

        private void EditKeyboardButton5Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[4] = comboBoxKeyboardButtonColor5.SelectedItem.ToString();
        }

        private void EditKeyboardButton6Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[5] = comboBoxKeyboardButtonColor6.SelectedItem.ToString();
        }

        private void EditKeyboardButton7Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[6] = comboBoxKeyboardButtonColor7.SelectedItem.ToString();
        }

        private void EditKeyboardButton8Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[7] = comboBoxKeyboardButtonColor8.SelectedItem.ToString();
        }

        private void EditKeyboardButton9Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[8] = comboBoxKeyboardButtonColor9.SelectedItem.ToString();
        }

        private void EditKeyboardButton10Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[9] = comboBoxKeyboardButtonColor10.SelectedItem.ToString();
        }

        private void EditKeyboardButton11Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[10] = comboBoxKeyboardButtonColor11.SelectedItem.ToString();
        }

        private void EditKeyboardButton12Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[11] = comboBoxKeyboardButtonColor12.SelectedItem.ToString();
        }

        private void EditKeyboardButton13Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[12] = comboBoxKeyboardButtonColor13.SelectedItem.ToString();
        }

        private void EditKeyboardButton14Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[13] = comboBoxKeyboardButtonColor14.SelectedItem.ToString();
        }

        private void EditKeyboardButton15Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[14] = comboBoxKeyboardButtonColor15.SelectedItem.ToString();
        }

        private void EditKeyboardButton16Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[15] = comboBoxKeyboardButtonColor16.SelectedItem.ToString();
        }

        private void EditKeyboardButton17Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[16] = comboBoxKeyboardButtonColor17.SelectedItem.ToString();
        }

        private void EditKeyboardButton18Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[17] = comboBoxKeyboardButtonColor18.SelectedItem.ToString();
        }

        private void EditKeyboardButton19Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[18] = comboBoxKeyboardButtonColor19.SelectedItem.ToString();
        }

        private void EditKeyboardButton20Color(object sender, EventArgs e)
        {
            FormVK.keyboardButtonsColor[19] = comboBoxKeyboardButtonColor20.SelectedItem.ToString();
        }

    }
}
