
namespace Bot_Creator
{
    partial class FormTelegram
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
            this.panelTelegramSettings = new System.Windows.Forms.Panel();
            this.buttonTelegramInline = new System.Windows.Forms.Button();
            this.buttonTelegramKeyboard = new System.Windows.Forms.Button();
            this.buttonTelegramMain = new System.Windows.Forms.Button();
            this.buttonBotSave = new System.Windows.Forms.Button();
            this.panelTelegramChildForm = new System.Windows.Forms.Panel();
            this.buttonTelegramSettings = new System.Windows.Forms.Button();
            this.panelTelegramSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTelegramSettings
            // 
            this.panelTelegramSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.panelTelegramSettings.Controls.Add(this.buttonTelegramSettings);
            this.panelTelegramSettings.Controls.Add(this.buttonTelegramInline);
            this.panelTelegramSettings.Controls.Add(this.buttonTelegramKeyboard);
            this.panelTelegramSettings.Controls.Add(this.buttonTelegramMain);
            this.panelTelegramSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTelegramSettings.Location = new System.Drawing.Point(0, 0);
            this.panelTelegramSettings.Name = "panelTelegramSettings";
            this.panelTelegramSettings.Size = new System.Drawing.Size(884, 100);
            this.panelTelegramSettings.TabIndex = 10;
            // 
            // buttonTelegramInline
            // 
            this.buttonTelegramInline.BackgroundImage = global::Bot_Creator.Properties.Resources.Inline;
            this.buttonTelegramInline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTelegramInline.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTelegramInline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelegramInline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTelegramInline.ForeColor = System.Drawing.Color.White;
            this.buttonTelegramInline.Location = new System.Drawing.Point(200, 0);
            this.buttonTelegramInline.Name = "buttonTelegramInline";
            this.buttonTelegramInline.Size = new System.Drawing.Size(100, 100);
            this.buttonTelegramInline.TabIndex = 2;
            this.buttonTelegramInline.Text = "Callback";
            this.buttonTelegramInline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTelegramInline.UseVisualStyleBackColor = true;
            this.buttonTelegramInline.Click += new System.EventHandler(this.OpenFormTelegramInline);
            // 
            // buttonTelegramKeyboard
            // 
            this.buttonTelegramKeyboard.BackgroundImage = global::Bot_Creator.Properties.Resources.Keyboard__Big_;
            this.buttonTelegramKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTelegramKeyboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTelegramKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelegramKeyboard.ForeColor = System.Drawing.Color.White;
            this.buttonTelegramKeyboard.Location = new System.Drawing.Point(100, 0);
            this.buttonTelegramKeyboard.Name = "buttonTelegramKeyboard";
            this.buttonTelegramKeyboard.Size = new System.Drawing.Size(100, 100);
            this.buttonTelegramKeyboard.TabIndex = 1;
            this.buttonTelegramKeyboard.Text = "Клавиатура";
            this.buttonTelegramKeyboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTelegramKeyboard.UseVisualStyleBackColor = true;
            this.buttonTelegramKeyboard.Click += new System.EventHandler(this.OpenFormTelegramKeyboard);
            // 
            // buttonTelegramMain
            // 
            this.buttonTelegramMain.BackgroundImage = global::Bot_Creator.Properties.Resources.Chat__Big_;
            this.buttonTelegramMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTelegramMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTelegramMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelegramMain.ForeColor = System.Drawing.Color.White;
            this.buttonTelegramMain.Location = new System.Drawing.Point(0, 0);
            this.buttonTelegramMain.Name = "buttonTelegramMain";
            this.buttonTelegramMain.Size = new System.Drawing.Size(100, 100);
            this.buttonTelegramMain.TabIndex = 0;
            this.buttonTelegramMain.Text = "Основные";
            this.buttonTelegramMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTelegramMain.UseVisualStyleBackColor = true;
            this.buttonTelegramMain.Click += new System.EventHandler(this.OpenFormTelegramMain);
            // 
            // buttonBotSave
            // 
            this.buttonBotSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.buttonBotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBotSave.ForeColor = System.Drawing.Color.White;
            this.buttonBotSave.Location = new System.Drawing.Point(37, 602);
            this.buttonBotSave.Name = "buttonBotSave";
            this.buttonBotSave.Size = new System.Drawing.Size(794, 40);
            this.buttonBotSave.TabIndex = 9;
            this.buttonBotSave.Text = "Сохранить бота";
            this.buttonBotSave.UseVisualStyleBackColor = false;
            this.buttonBotSave.Click += new System.EventHandler(this.BotSave);
            // 
            // panelTelegramChildForm
            // 
            this.panelTelegramChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTelegramChildForm.Location = new System.Drawing.Point(0, 100);
            this.panelTelegramChildForm.Name = "panelTelegramChildForm";
            this.panelTelegramChildForm.Size = new System.Drawing.Size(884, 496);
            this.panelTelegramChildForm.TabIndex = 12;
            // 
            // buttonTelegramSettings
            // 
            this.buttonTelegramSettings.BackgroundImage = global::Bot_Creator.Properties.Resources.Settings;
            this.buttonTelegramSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTelegramSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTelegramSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelegramSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTelegramSettings.ForeColor = System.Drawing.Color.White;
            this.buttonTelegramSettings.Location = new System.Drawing.Point(300, 0);
            this.buttonTelegramSettings.Name = "buttonTelegramSettings";
            this.buttonTelegramSettings.Size = new System.Drawing.Size(100, 100);
            this.buttonTelegramSettings.TabIndex = 5;
            this.buttonTelegramSettings.Text = "Побочные";
            this.buttonTelegramSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTelegramSettings.UseVisualStyleBackColor = true;
            // 
            // FormTelegram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(884, 654);
            this.Controls.Add(this.panelTelegramChildForm);
            this.Controls.Add(this.panelTelegramSettings);
            this.Controls.Add(this.buttonBotSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelegram";
            this.Text = "FormTelegram";
            this.panelTelegramSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTelegramSettings;
        private System.Windows.Forms.Button buttonTelegramKeyboard;
        private System.Windows.Forms.Button buttonTelegramMain;
        private System.Windows.Forms.Button buttonBotSave;
        private System.Windows.Forms.Panel panelTelegramChildForm;
        private System.Windows.Forms.Button buttonTelegramInline;
        private System.Windows.Forms.Button buttonTelegramSettings;
    }
}