namespace ChatmailGUI
{
    partial class FormChatmail
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatmail));
            this.groupBoxNachrichtVerfassen = new System.Windows.Forms.GroupBox();
            this.radioButtonDBVerbindung = new System.Windows.Forms.RadioButton();
            this.textBoxNachrichtVerfassen = new System.Windows.Forms.TextBox();
            this.buttonSenden = new System.Windows.Forms.Button();
            this.comboBoxEmpfänger = new System.Windows.Forms.ComboBox();
            this.labelEmpfänger = new System.Windows.Forms.Label();
            this.groupBoxEmpfangeneNachricht = new System.Windows.Forms.GroupBox();
            this.richTextBoxEmfpangeneNachrichten = new System.Windows.Forms.RichTextBox();
            this.timerUpdateGui = new System.Windows.Forms.Timer(this.components);
            this.groupBoxNachrichtVerfassen.SuspendLayout();
            this.groupBoxEmpfangeneNachricht.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNachrichtVerfassen
            // 
            this.groupBoxNachrichtVerfassen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNachrichtVerfassen.Controls.Add(this.radioButtonDBVerbindung);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.textBoxNachrichtVerfassen);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.buttonSenden);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.comboBoxEmpfänger);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.labelEmpfänger);
            this.groupBoxNachrichtVerfassen.Location = new System.Drawing.Point(16, 15);
            this.groupBoxNachrichtVerfassen.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxNachrichtVerfassen.Name = "groupBoxNachrichtVerfassen";
            this.groupBoxNachrichtVerfassen.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxNachrichtVerfassen.Size = new System.Drawing.Size(680, 233);
            this.groupBoxNachrichtVerfassen.TabIndex = 0;
            this.groupBoxNachrichtVerfassen.TabStop = false;
            this.groupBoxNachrichtVerfassen.Text = "Nachricht verfassen";
            // 
            // radioButtonDBVerbindung
            // 
            this.radioButtonDBVerbindung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDBVerbindung.AutoSize = true;
            this.radioButtonDBVerbindung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonDBVerbindung.Location = new System.Drawing.Point(403, 25);
            this.radioButtonDBVerbindung.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDBVerbindung.Name = "radioButtonDBVerbindung";
            this.radioButtonDBVerbindung.Size = new System.Drawing.Size(124, 21);
            this.radioButtonDBVerbindung.TabIndex = 4;
            this.radioButtonDBVerbindung.Text = "DB Verbindung";
            this.radioButtonDBVerbindung.UseVisualStyleBackColor = true;
            this.radioButtonDBVerbindung.CheckedChanged += new System.EventHandler(this.radioButtonDBVerbindung_CheckedChanged);
            // 
            // textBoxNachrichtVerfassen
            // 
            this.textBoxNachrichtVerfassen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNachrichtVerfassen.Location = new System.Drawing.Point(8, 57);
            this.textBoxNachrichtVerfassen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNachrichtVerfassen.Multiline = true;
            this.textBoxNachrichtVerfassen.Name = "textBoxNachrichtVerfassen";
            this.textBoxNachrichtVerfassen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNachrichtVerfassen.Size = new System.Drawing.Size(663, 168);
            this.textBoxNachrichtVerfassen.TabIndex = 2;
            // 
            // buttonSenden
            // 
            this.buttonSenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSenden.Location = new System.Drawing.Point(535, 21);
            this.buttonSenden.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSenden.Name = "buttonSenden";
            this.buttonSenden.Size = new System.Drawing.Size(137, 28);
            this.buttonSenden.TabIndex = 3;
            this.buttonSenden.Text = "Senden";
            this.buttonSenden.UseVisualStyleBackColor = true;
            this.buttonSenden.Click += new System.EventHandler(this.buttonSenden_Click);
            // 
            // comboBoxEmpfänger
            // 
            this.comboBoxEmpfänger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpfänger.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEmpfänger.FormattingEnabled = true;
            this.comboBoxEmpfänger.Location = new System.Drawing.Point(93, 23);
            this.comboBoxEmpfänger.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmpfänger.Name = "comboBoxEmpfänger";
            this.comboBoxEmpfänger.Size = new System.Drawing.Size(228, 24);
            this.comboBoxEmpfänger.TabIndex = 1;
            // 
            // labelEmpfänger
            // 
            this.labelEmpfänger.AutoSize = true;
            this.labelEmpfänger.Location = new System.Drawing.Point(8, 27);
            this.labelEmpfänger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmpfänger.Name = "labelEmpfänger";
            this.labelEmpfänger.Size = new System.Drawing.Size(81, 17);
            this.labelEmpfänger.TabIndex = 0;
            this.labelEmpfänger.Text = "Empfänger:";
            // 
            // groupBoxEmpfangeneNachricht
            // 
            this.groupBoxEmpfangeneNachricht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmpfangeneNachricht.Controls.Add(this.richTextBoxEmfpangeneNachrichten);
            this.groupBoxEmpfangeneNachricht.Location = new System.Drawing.Point(16, 255);
            this.groupBoxEmpfangeneNachricht.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEmpfangeneNachricht.Name = "groupBoxEmpfangeneNachricht";
            this.groupBoxEmpfangeneNachricht.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEmpfangeneNachricht.Size = new System.Drawing.Size(683, 238);
            this.groupBoxEmpfangeneNachricht.TabIndex = 1;
            this.groupBoxEmpfangeneNachricht.TabStop = false;
            this.groupBoxEmpfangeneNachricht.Text = "Empfangene Nachrichten";
            // 
            // richTextBoxEmfpangeneNachrichten
            // 
            this.richTextBoxEmfpangeneNachrichten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEmfpangeneNachrichten.Location = new System.Drawing.Point(8, 23);
            this.richTextBoxEmfpangeneNachrichten.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxEmfpangeneNachrichten.Name = "richTextBoxEmfpangeneNachrichten";
            this.richTextBoxEmfpangeneNachrichten.Size = new System.Drawing.Size(663, 207);
            this.richTextBoxEmfpangeneNachrichten.TabIndex = 5;
            this.richTextBoxEmfpangeneNachrichten.Text = "";
            // 
            // timerUpdateGui
            // 
            this.timerUpdateGui.Enabled = true;
            this.timerUpdateGui.Interval = 1000;
            this.timerUpdateGui.Tick += new System.EventHandler(this.timerUpdateGui_Tick);
            // 
            // FormChatmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 506);
            this.Controls.Add(this.groupBoxEmpfangeneNachricht);
            this.Controls.Add(this.groupBoxNachrichtVerfassen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(727, 543);
            this.Name = "FormChatmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatmail";
            this.Load += new System.EventHandler(this.FormChatmail_Load);
            this.groupBoxNachrichtVerfassen.ResumeLayout(false);
            this.groupBoxNachrichtVerfassen.PerformLayout();
            this.groupBoxEmpfangeneNachricht.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNachrichtVerfassen;
        private System.Windows.Forms.GroupBox groupBoxEmpfangeneNachricht;
        private System.Windows.Forms.Label labelEmpfänger;
        private System.Windows.Forms.Button buttonSenden;
        private System.Windows.Forms.TextBox textBoxNachrichtVerfassen;
        public System.Windows.Forms.ComboBox comboBoxEmpfänger;
        private System.Windows.Forms.RichTextBox richTextBoxEmfpangeneNachrichten;
        public System.Windows.Forms.Timer timerUpdateGui;
        public System.Windows.Forms.RadioButton radioButtonDBVerbindung;
    }
}

