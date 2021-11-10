
namespace Bot_Creator
{
    partial class FormDiscord
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
            this.buttonBotSave = new System.Windows.Forms.Button();
            this.panelVKSettings = new System.Windows.Forms.Panel();
            this.buttonVKSettings = new System.Windows.Forms.Button();
            this.buttonVKMain = new System.Windows.Forms.Button();
            this.panelVKChildForm = new System.Windows.Forms.Panel();
            this.panelVKSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBotSave
            // 
            this.buttonBotSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.buttonBotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBotSave.ForeColor = System.Drawing.Color.White;
            this.buttonBotSave.Location = new System.Drawing.Point(37, 608);
            this.buttonBotSave.Name = "buttonBotSave";
            this.buttonBotSave.Size = new System.Drawing.Size(794, 40);
            this.buttonBotSave.TabIndex = 9;
            this.buttonBotSave.Text = "Сохранить бота";
            this.buttonBotSave.UseVisualStyleBackColor = false;
            // 
            // panelVKSettings
            // 
            this.panelVKSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(161)))));
            this.panelVKSettings.Controls.Add(this.buttonVKSettings);
            this.panelVKSettings.Controls.Add(this.buttonVKMain);
            this.panelVKSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVKSettings.Location = new System.Drawing.Point(0, 0);
            this.panelVKSettings.Name = "panelVKSettings";
            this.panelVKSettings.Size = new System.Drawing.Size(884, 100);
            this.panelVKSettings.TabIndex = 11;
            // 
            // buttonVKSettings
            // 
            this.buttonVKSettings.BackgroundImage = global::Bot_Creator.Properties.Resources.Settings;
            this.buttonVKSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVKSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonVKSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVKSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVKSettings.ForeColor = System.Drawing.Color.White;
            this.buttonVKSettings.Location = new System.Drawing.Point(100, 0);
            this.buttonVKSettings.Name = "buttonVKSettings";
            this.buttonVKSettings.Size = new System.Drawing.Size(100, 100);
            this.buttonVKSettings.TabIndex = 4;
            this.buttonVKSettings.Text = "Побочные";
            this.buttonVKSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVKSettings.UseVisualStyleBackColor = true;
            this.buttonVKSettings.Click += new System.EventHandler(this.buttonVKSettings_Click);
            // 
            // buttonVKMain
            // 
            this.buttonVKMain.BackgroundImage = global::Bot_Creator.Properties.Resources.Chat__Big_;
            this.buttonVKMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVKMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonVKMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVKMain.ForeColor = System.Drawing.Color.White;
            this.buttonVKMain.Location = new System.Drawing.Point(0, 0);
            this.buttonVKMain.Name = "buttonVKMain";
            this.buttonVKMain.Size = new System.Drawing.Size(100, 100);
            this.buttonVKMain.TabIndex = 0;
            this.buttonVKMain.Text = "Основные";
            this.buttonVKMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVKMain.UseVisualStyleBackColor = true;
            this.buttonVKMain.Click += new System.EventHandler(this.buttonVKMain_Click);
            // 
            // panelVKChildForm
            // 
            this.panelVKChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVKChildForm.Location = new System.Drawing.Point(0, 100);
            this.panelVKChildForm.Name = "panelVKChildForm";
            this.panelVKChildForm.Size = new System.Drawing.Size(884, 496);
            this.panelVKChildForm.TabIndex = 12;
            // 
            // FormDiscord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(884, 654);
            this.Controls.Add(this.panelVKChildForm);
            this.Controls.Add(this.panelVKSettings);
            this.Controls.Add(this.buttonBotSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscord";
            this.Text = "FormDiscord";
            this.panelVKSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBotSave;
        private System.Windows.Forms.Panel panelVKSettings;
        private System.Windows.Forms.Button buttonVKSettings;
        private System.Windows.Forms.Button buttonVKMain;
        private System.Windows.Forms.Panel panelVKChildForm;
    }
}