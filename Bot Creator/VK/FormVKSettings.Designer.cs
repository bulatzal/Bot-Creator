
namespace Bot_Creator
{
    partial class FormVKSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxKeyboard = new System.Windows.Forms.CheckBox();
            this.pictureBoxKeyboard = new System.Windows.Forms.PictureBox();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxKeyboard
            // 
            this.checkBoxKeyboard.AutoSize = true;
            this.checkBoxKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxKeyboard.ForeColor = System.Drawing.Color.Black;
            this.checkBoxKeyboard.Location = new System.Drawing.Point(261, 35);
            this.checkBoxKeyboard.Name = "checkBoxKeyboard";
            this.checkBoxKeyboard.Size = new System.Drawing.Size(12, 11);
            this.checkBoxKeyboard.TabIndex = 59;
            this.checkBoxKeyboard.UseVisualStyleBackColor = true;
            // 
            // pictureBoxKeyboard
            // 
            this.pictureBoxKeyboard.Image = global::Bot_Creator.Properties.Resources.Help;
            this.pictureBoxKeyboard.Location = new System.Drawing.Point(37, 28);
            this.pictureBoxKeyboard.Name = "pictureBoxKeyboard";
            this.pictureBoxKeyboard.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxKeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKeyboard.TabIndex = 58;
            this.pictureBoxKeyboard.TabStop = false;
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.ForeColor = System.Drawing.Color.White;
            this.labelKeyboard.Location = new System.Drawing.Point(63, 33);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(192, 15);
            this.labelKeyboard.TabIndex = 57;
            this.labelKeyboard.Text = "Ответ на неизвестное сообщение";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer.Location = new System.Drawing.Point(37, 54);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(236, 51);
            this.textBoxAnswer.TabIndex = 92;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(216, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(12, 11);
            this.checkBox1.TabIndex = 94;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Выводить логи в консоль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bot_Creator.Properties.Resources.File;
            this.pictureBox1.Location = new System.Drawing.Point(37, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // FormVKSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(868, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.checkBoxKeyboard);
            this.Controls.Add(this.pictureBoxKeyboard);
            this.Controls.Add(this.labelKeyboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVKSettings";
            this.Text = "FormVKSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxKeyboard;
        private System.Windows.Forms.PictureBox pictureBoxKeyboard;
        private System.Windows.Forms.Label labelKeyboard;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}