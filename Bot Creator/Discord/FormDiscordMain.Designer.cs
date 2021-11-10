
namespace Bot_Creator
{
    partial class FormDiscordMain
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
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommand = new System.Windows.Forms.PictureBox();
            this.pictureBoxToken = new System.Windows.Forms.PictureBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.dataGridViewVK = new System.Windows.Forms.DataGridView();
            this.Команды = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ответы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVK)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.Image = global::Bot_Creator.Properties.Resources.Bot;
            this.pictureBoxName.Location = new System.Drawing.Point(37, 15);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxName.TabIndex = 65;
            this.pictureBoxName.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(63, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 15);
            this.labelName.TabIndex = 64;
            this.labelName.Text = "Наименование бота";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(37, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(389, 23);
            this.textBoxName.TabIndex = 63;
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Image = global::Bot_Creator.Properties.Resources.Answer;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(450, 96);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnswer.TabIndex = 62;
            this.pictureBoxAnswer.TabStop = false;
            // 
            // pictureBoxCommand
            // 
            this.pictureBoxCommand.Image = global::Bot_Creator.Properties.Resources.Command;
            this.pictureBoxCommand.Location = new System.Drawing.Point(37, 96);
            this.pictureBoxCommand.Name = "pictureBoxCommand";
            this.pictureBoxCommand.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommand.TabIndex = 61;
            this.pictureBoxCommand.TabStop = false;
            // 
            // pictureBoxToken
            // 
            this.pictureBoxToken.Image = global::Bot_Creator.Properties.Resources.Key;
            this.pictureBoxToken.Location = new System.Drawing.Point(450, 15);
            this.pictureBoxToken.Name = "pictureBoxToken";
            this.pictureBoxToken.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxToken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToken.TabIndex = 60;
            this.pictureBoxToken.TabStop = false;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.ForeColor = System.Drawing.Color.White;
            this.labelToken.Location = new System.Drawing.Point(476, 20);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(155, 15);
            this.labelToken.TabIndex = 59;
            this.labelToken.Text = "Ключ доступа Discord бота";
            // 
            // textBoxToken
            // 
            this.textBoxToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxToken.ForeColor = System.Drawing.Color.White;
            this.textBoxToken.Location = new System.Drawing.Point(450, 41);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(389, 23);
            this.textBoxToken.TabIndex = 58;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.ForeColor = System.Drawing.Color.White;
            this.labelAnswer.Location = new System.Drawing.Point(476, 101);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(38, 15);
            this.labelAnswer.TabIndex = 57;
            this.labelAnswer.Text = "Ответ";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.ForeColor = System.Drawing.Color.White;
            this.labelCommand.Location = new System.Drawing.Point(63, 101);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(55, 15);
            this.labelCommand.TabIndex = 56;
            this.labelCommand.Text = "Команда";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer.Location = new System.Drawing.Point(450, 122);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(389, 68);
            this.textBoxAnswer.TabIndex = 55;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.textBoxCommand.ForeColor = System.Drawing.Color.White;
            this.textBoxCommand.Location = new System.Drawing.Point(37, 122);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommand.Size = new System.Drawing.Size(389, 68);
            this.textBoxCommand.TabIndex = 54;
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.buttonAddCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCommand.ForeColor = System.Drawing.Color.White;
            this.buttonAddCommand.Location = new System.Drawing.Point(37, 201);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(802, 45);
            this.buttonAddCommand.TabIndex = 53;
            this.buttonAddCommand.Text = "Добавить команду";
            this.buttonAddCommand.UseVisualStyleBackColor = false;
            // 
            // dataGridViewVK
            // 
            this.dataGridViewVK.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.dataGridViewVK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Команды,
            this.Ответы});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVK.EnableHeadersVisualStyles = false;
            this.dataGridViewVK.GridColor = System.Drawing.Color.White;
            this.dataGridViewVK.Location = new System.Drawing.Point(37, 251);
            this.dataGridViewVK.Name = "dataGridViewVK";
            this.dataGridViewVK.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVK.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVK.RowTemplate.Height = 25;
            this.dataGridViewVK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewVK.Size = new System.Drawing.Size(838, 202);
            this.dataGridViewVK.TabIndex = 52;
            // 
            // Команды
            // 
            this.Команды.HeaderText = "Команды";
            this.Команды.Name = "Команды";
            this.Команды.ReadOnly = true;
            this.Команды.Width = 376;
            // 
            // Ответы
            // 
            this.Ответы.HeaderText = "Ответы";
            this.Ответы.Name = "Ответы";
            this.Ответы.ReadOnly = true;
            this.Ответы.Width = 385;
            // 
            // FormDiscordMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(868, 457);
            this.Controls.Add(this.pictureBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxAnswer);
            this.Controls.Add(this.pictureBoxCommand);
            this.Controls.Add(this.pictureBoxToken);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonAddCommand);
            this.Controls.Add(this.dataGridViewVK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscordMain";
            this.Text = "FormDiscordMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBoxCommand;
        private System.Windows.Forms.PictureBox pictureBoxToken;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.DataGridView dataGridViewVK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Команды;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ответы;
    }
}