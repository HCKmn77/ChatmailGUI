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
            this.groupBoxNachrichtVerfassen = new System.Windows.Forms.GroupBox();
            this.radioButtonDBVerbindung = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSenden = new System.Windows.Forms.Button();
            this.comboBoxEmpfänger = new System.Windows.Forms.ComboBox();
            this.labelEmpfänger = new System.Windows.Forms.Label();
            this.groupBoxEmpfangeneNachricht = new System.Windows.Forms.GroupBox();
            this.textBoxEmfangeneNachricht = new System.Windows.Forms.TextBox();
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
            this.groupBoxNachrichtVerfassen.Controls.Add(this.textBox1);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.buttonSenden);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.comboBoxEmpfänger);
            this.groupBoxNachrichtVerfassen.Controls.Add(this.labelEmpfänger);
            this.groupBoxNachrichtVerfassen.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNachrichtVerfassen.Name = "groupBoxNachrichtVerfassen";
            this.groupBoxNachrichtVerfassen.Size = new System.Drawing.Size(510, 189);
            this.groupBoxNachrichtVerfassen.TabIndex = 0;
            this.groupBoxNachrichtVerfassen.TabStop = false;
            this.groupBoxNachrichtVerfassen.Text = "Nachricht verfassen";
            // 
            // radioButtonDBVerbindung
            // 
            this.radioButtonDBVerbindung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDBVerbindung.AutoSize = true;
            this.radioButtonDBVerbindung.Location = new System.Drawing.Point(298, 20);
            this.radioButtonDBVerbindung.Name = "radioButtonDBVerbindung";
            this.radioButtonDBVerbindung.Size = new System.Drawing.Size(97, 17);
            this.radioButtonDBVerbindung.TabIndex = 4;
            this.radioButtonDBVerbindung.Text = "DB Verbindung";
            this.radioButtonDBVerbindung.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(498, 137);
            this.textBox1.TabIndex = 2;
            // 
            // buttonSenden
            // 
            this.buttonSenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSenden.Location = new System.Drawing.Point(401, 17);
            this.buttonSenden.Name = "buttonSenden";
            this.buttonSenden.Size = new System.Drawing.Size(103, 23);
            this.buttonSenden.TabIndex = 3;
            this.buttonSenden.Text = "Senden";
            this.buttonSenden.UseVisualStyleBackColor = true;
            this.buttonSenden.Click += new System.EventHandler(this.buttonSenden_Click);
            // 
            // comboBoxEmpfänger
            // 
            this.comboBoxEmpfänger.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEmpfänger.FormattingEnabled = true;
            this.comboBoxEmpfänger.Location = new System.Drawing.Point(70, 19);
            this.comboBoxEmpfänger.Name = "comboBoxEmpfänger";
            this.comboBoxEmpfänger.Size = new System.Drawing.Size(173, 21);
            this.comboBoxEmpfänger.TabIndex = 1;
            this.comboBoxEmpfänger.Text = "Empfänger wählen";
            // 
            // labelEmpfänger
            // 
            this.labelEmpfänger.AutoSize = true;
            this.labelEmpfänger.Location = new System.Drawing.Point(6, 22);
            this.labelEmpfänger.Name = "labelEmpfänger";
            this.labelEmpfänger.Size = new System.Drawing.Size(58, 13);
            this.labelEmpfänger.TabIndex = 0;
            this.labelEmpfänger.Text = "Empfänger";
            // 
            // groupBoxEmpfangeneNachricht
            // 
            this.groupBoxEmpfangeneNachricht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmpfangeneNachricht.Controls.Add(this.textBoxEmfangeneNachricht);
            this.groupBoxEmpfangeneNachricht.Location = new System.Drawing.Point(12, 207);
            this.groupBoxEmpfangeneNachricht.Name = "groupBoxEmpfangeneNachricht";
            this.groupBoxEmpfangeneNachricht.Size = new System.Drawing.Size(510, 192);
            this.groupBoxEmpfangeneNachricht.TabIndex = 1;
            this.groupBoxEmpfangeneNachricht.TabStop = false;
            this.groupBoxEmpfangeneNachricht.Text = "Empfangene Nachrichten";
            // 
            // textBoxEmfangeneNachricht
            // 
            this.textBoxEmfangeneNachricht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmfangeneNachricht.Location = new System.Drawing.Point(9, 19);
            this.textBoxEmfangeneNachricht.Multiline = true;
            this.textBoxEmfangeneNachricht.Name = "textBoxEmfangeneNachricht";
            this.textBoxEmfangeneNachricht.ReadOnly = true;
            this.textBoxEmfangeneNachricht.Size = new System.Drawing.Size(495, 167);
            this.textBoxEmfangeneNachricht.TabIndex = 4;
            this.textBoxEmfangeneNachricht.TabStop = false;
            // 
            // timerUpdateGui
            // 
            this.timerUpdateGui.Enabled = true;
            this.timerUpdateGui.Interval = 1000;
            this.timerUpdateGui.Tick += new System.EventHandler(this.timerUpdateGui_Tick);
            // 
            // FormChatmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.groupBoxEmpfangeneNachricht);
            this.Controls.Add(this.groupBoxNachrichtVerfassen);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "FormChatmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatmail";
            this.Load += new System.EventHandler(this.FormChatmail_Load);
            this.groupBoxNachrichtVerfassen.ResumeLayout(false);
            this.groupBoxNachrichtVerfassen.PerformLayout();
            this.groupBoxEmpfangeneNachricht.ResumeLayout(false);
            this.groupBoxEmpfangeneNachricht.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNachrichtVerfassen;
        private System.Windows.Forms.GroupBox groupBoxEmpfangeneNachricht;
        private System.Windows.Forms.Label labelEmpfänger;
        private System.Windows.Forms.ComboBox comboBoxEmpfänger;
        private System.Windows.Forms.Button buttonSenden;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxEmfangeneNachricht;
        private System.Windows.Forms.RadioButton radioButtonDBVerbindung;
        private System.Windows.Forms.Timer timerUpdateGui;
        
    }
}

