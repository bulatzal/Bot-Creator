
namespace Bot_Creator
{
    partial class FormTelegramInline
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxCommand = new System.Windows.Forms.PictureBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.dataGridViewTelegram = new System.Windows.Forms.DataGridView();
            this.Команды = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ответы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кнопки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кнопки2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ответы1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ответы2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxButton1 = new System.Windows.Forms.PictureBox();
            this.labelButton1 = new System.Windows.Forms.Label();
            this.textBoxButton1 = new System.Windows.Forms.TextBox();
            this.pictureBoxButton2 = new System.Windows.Forms.PictureBox();
            this.labelButton2 = new System.Windows.Forms.Label();
            this.textBoxButton2 = new System.Windows.Forms.TextBox();
            this.pictureBoxAnswer1 = new System.Windows.Forms.PictureBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.pictureBoxAnswer2 = new System.Windows.Forms.PictureBox();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCommand
            // 
            this.pictureBoxCommand.Image = global::Bot_Creator.Properties.Resources.Command;
            this.pictureBoxCommand.Location = new System.Drawing.Point(37, 15);
            this.pictureBoxCommand.Name = "pictureBoxCommand";
            this.pictureBoxCommand.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommand.TabIndex = 72;
            this.pictureBoxCommand.TabStop = false;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.ForeColor = System.Drawing.Color.White;
            this.labelCommand.Location = new System.Drawing.Point(63, 20);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(55, 15);
            this.labelCommand.TabIndex = 70;
            this.labelCommand.Text = "Команда";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxCommand.ForeColor = System.Drawing.Color.White;
            this.textBoxCommand.Location = new System.Drawing.Point(37, 41);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommand.Size = new System.Drawing.Size(389, 51);
            this.textBoxCommand.TabIndex = 68;
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.buttonAddCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCommand.ForeColor = System.Drawing.Color.White;
            this.buttonAddCommand.Location = new System.Drawing.Point(37, 257);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(802, 45);
            this.buttonAddCommand.TabIndex = 67;
            this.buttonAddCommand.Text = "Добавить команду";
            this.buttonAddCommand.UseVisualStyleBackColor = false;
            this.buttonAddCommand.Click += new System.EventHandler(this.AddCommand);
            // 
            // dataGridViewTelegram
            // 
            this.dataGridViewTelegram.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTelegram.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTelegram.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTelegram.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.dataGridViewTelegram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTelegram.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTelegram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTelegram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelegram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Команды,
            this.Ответы,
            this.Кнопки1,
            this.Кнопки2,
            this.Ответы1,
            this.Ответы2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTelegram.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTelegram.EnableHeadersVisualStyles = false;
            this.dataGridViewTelegram.GridColor = System.Drawing.Color.White;
            this.dataGridViewTelegram.Location = new System.Drawing.Point(37, 316);
            this.dataGridViewTelegram.Name = "dataGridViewTelegram";
            this.dataGridViewTelegram.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTelegram.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTelegram.RowTemplate.Height = 25;
            this.dataGridViewTelegram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTelegram.Size = new System.Drawing.Size(850, 141);
            this.dataGridViewTelegram.TabIndex = 66;
            // 
            // Команды
            // 
            this.Команды.HeaderText = "Команды";
            this.Команды.Name = "Команды";
            this.Команды.ReadOnly = true;
            this.Команды.Width = 126;
            // 
            // Ответы
            // 
            this.Ответы.HeaderText = "Ответы";
            this.Ответы.Name = "Ответы";
            this.Ответы.ReadOnly = true;
            this.Ответы.Width = 127;
            // 
            // Кнопки1
            // 
            this.Кнопки1.HeaderText = "Кнопки №1";
            this.Кнопки1.Name = "Кнопки1";
            this.Кнопки1.ReadOnly = true;
            this.Кнопки1.Width = 126;
            // 
            // Кнопки2
            // 
            this.Кнопки2.HeaderText = "Кнопки №2";
            this.Кнопки2.Name = "Кнопки2";
            this.Кнопки2.ReadOnly = true;
            this.Кнопки2.Width = 126;
            // 
            // Ответы1
            // 
            this.Ответы1.HeaderText = "Ответы №1";
            this.Ответы1.Name = "Ответы1";
            this.Ответы1.ReadOnly = true;
            this.Ответы1.Width = 128;
            // 
            // Ответы2
            // 
            this.Ответы2.HeaderText = "Ответы №2";
            this.Ответы2.Name = "Ответы2";
            this.Ответы2.ReadOnly = true;
            this.Ответы2.Width = 128;
            // 
            // pictureBoxButton1
            // 
            this.pictureBoxButton1.Image = global::Bot_Creator.Properties.Resources.Play;
            this.pictureBoxButton1.Location = new System.Drawing.Point(37, 99);
            this.pictureBoxButton1.Name = "pictureBoxButton1";
            this.pictureBoxButton1.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton1.TabIndex = 75;
            this.pictureBoxButton1.TabStop = false;
            // 
            // labelButton1
            // 
            this.labelButton1.AutoSize = true;
            this.labelButton1.ForeColor = System.Drawing.Color.White;
            this.labelButton1.Location = new System.Drawing.Point(63, 104);
            this.labelButton1.Name = "labelButton1";
            this.labelButton1.Size = new System.Drawing.Size(56, 15);
            this.labelButton1.TabIndex = 74;
            this.labelButton1.Text = "Кнопка 1";
            // 
            // textBoxButton1
            // 
            this.textBoxButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxButton1.ForeColor = System.Drawing.Color.White;
            this.textBoxButton1.Location = new System.Drawing.Point(37, 125);
            this.textBoxButton1.Name = "textBoxButton1";
            this.textBoxButton1.Size = new System.Drawing.Size(389, 23);
            this.textBoxButton1.TabIndex = 73;
            // 
            // pictureBoxButton2
            // 
            this.pictureBoxButton2.Image = global::Bot_Creator.Properties.Resources.Play;
            this.pictureBoxButton2.Location = new System.Drawing.Point(450, 99);
            this.pictureBoxButton2.Name = "pictureBoxButton2";
            this.pictureBoxButton2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton2.TabIndex = 78;
            this.pictureBoxButton2.TabStop = false;
            // 
            // labelButton2
            // 
            this.labelButton2.AutoSize = true;
            this.labelButton2.ForeColor = System.Drawing.Color.White;
            this.labelButton2.Location = new System.Drawing.Point(476, 104);
            this.labelButton2.Name = "labelButton2";
            this.labelButton2.Size = new System.Drawing.Size(56, 15);
            this.labelButton2.TabIndex = 77;
            this.labelButton2.Text = "Кнопка 2";
            // 
            // textBoxButton2
            // 
            this.textBoxButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxButton2.ForeColor = System.Drawing.Color.White;
            this.textBoxButton2.Location = new System.Drawing.Point(450, 125);
            this.textBoxButton2.Name = "textBoxButton2";
            this.textBoxButton2.Size = new System.Drawing.Size(389, 23);
            this.textBoxButton2.TabIndex = 76;
            // 
            // pictureBoxAnswer1
            // 
            this.pictureBoxAnswer1.Image = global::Bot_Creator.Properties.Resources.Answer;
            this.pictureBoxAnswer1.Location = new System.Drawing.Point(37, 154);
            this.pictureBoxAnswer1.Name = "pictureBoxAnswer1";
            this.pictureBoxAnswer1.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxAnswer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnswer1.TabIndex = 81;
            this.pictureBoxAnswer1.TabStop = false;
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.ForeColor = System.Drawing.Color.White;
            this.labelAnswer1.Location = new System.Drawing.Point(63, 159);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(105, 15);
            this.labelAnswer1.TabIndex = 80;
            this.labelAnswer1.Text = "Ответ на кнопку 1";
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxAnswer1.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer1.Location = new System.Drawing.Point(37, 180);
            this.textBoxAnswer1.Multiline = true;
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer1.Size = new System.Drawing.Size(389, 51);
            this.textBoxAnswer1.TabIndex = 79;
            // 
            // pictureBoxAnswer2
            // 
            this.pictureBoxAnswer2.Image = global::Bot_Creator.Properties.Resources.Answer;
            this.pictureBoxAnswer2.Location = new System.Drawing.Point(450, 154);
            this.pictureBoxAnswer2.Name = "pictureBoxAnswer2";
            this.pictureBoxAnswer2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxAnswer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnswer2.TabIndex = 84;
            this.pictureBoxAnswer2.TabStop = false;
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.ForeColor = System.Drawing.Color.White;
            this.labelAnswer2.Location = new System.Drawing.Point(476, 159);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(105, 15);
            this.labelAnswer2.TabIndex = 83;
            this.labelAnswer2.Text = "Ответ на кнопку 2";
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxAnswer2.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer2.Location = new System.Drawing.Point(450, 180);
            this.textBoxAnswer2.Multiline = true;
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer2.Size = new System.Drawing.Size(389, 51);
            this.textBoxAnswer2.TabIndex = 82;
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Image = global::Bot_Creator.Properties.Resources.Answer;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(450, 15);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnswer.TabIndex = 87;
            this.pictureBoxAnswer.TabStop = false;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.ForeColor = System.Drawing.Color.White;
            this.labelAnswer.Location = new System.Drawing.Point(476, 20);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(38, 15);
            this.labelAnswer.TabIndex = 86;
            this.labelAnswer.Text = "Ответ";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer.Location = new System.Drawing.Point(450, 41);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(389, 51);
            this.textBoxAnswer.TabIndex = 85;
            // 
            // FormTelegramInline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(868, 457);
            this.Controls.Add(this.pictureBoxAnswer);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.pictureBoxAnswer2);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.pictureBoxAnswer1);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.pictureBoxButton2);
            this.Controls.Add(this.labelButton2);
            this.Controls.Add(this.textBoxButton2);
            this.Controls.Add(this.pictureBoxButton1);
            this.Controls.Add(this.labelButton1);
            this.Controls.Add(this.textBoxButton1);
            this.Controls.Add(this.pictureBoxCommand);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonAddCommand);
            this.Controls.Add(this.dataGridViewTelegram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelegramInline";
            this.Text = "FormTelegramInline";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCommand;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.DataGridView dataGridViewTelegram;
        private System.Windows.Forms.PictureBox pictureBoxButton1;
        private System.Windows.Forms.Label labelButton1;
        private System.Windows.Forms.TextBox textBoxButton1;
        private System.Windows.Forms.PictureBox pictureBoxButton2;
        private System.Windows.Forms.Label labelButton2;
        private System.Windows.Forms.TextBox textBoxButton2;
        private System.Windows.Forms.PictureBox pictureBoxAnswer1;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.PictureBox pictureBoxAnswer2;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Команды;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ответы;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кнопки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кнопки2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ответы1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ответы2;
        private System.Windows.Forms.PictureBox pictureBoxAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}