using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using it.schule;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Crmf;

namespace ChatmailGUI
{
    

    public partial class FormChatmail : Form       
    {
        Controller controller = new Controller();
        List<int> nachrichtenLog = new List<int>();

        public FormChatmail()
        {
            InitializeComponent();
        }
       
        private void FormChatmail_Load(object sender, EventArgs e)
        {
            // Benutzer in Dropdown laden
            foreach (Benutzer benutzer in controller.BenutzerLaden())
            {
                comboBoxEmpfänger.Items.Add(benutzer.Name + " – ID: " + benutzer.ID);
            }
        }
       
        private void buttonSenden_Click(object sender, EventArgs e)
        {
            // Prüfen, ob ein Empfänger ausgewählt ist. Wenn nicht, dann Fehlermeldung
            if (comboBoxEmpfänger.SelectedIndex == -1)
            {
                MessageBox.Show("Kein Empfänger ausgewählt! Empfänger auswählen und Nachricht erneut senden.", "Empfänger auswählen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Prüfen, ob eine gültige Nachricht verfasst wurde. Wenn nicht, dann Fehlermeldung
            else if (string.IsNullOrWhiteSpace(textBoxNachrichtVerfassen.Text))
            {
                MessageBox.Show("Keine gültige Nachricht eingegeben! Bitte Nachricht erneut eingeben.", "Ungültige Nachricht", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
                    {
                controller.zuSendenderText = textBoxNachrichtVerfassen.Text;
                // Empfänger ID aus Dropdown Menü auslesen
                string benutzerID = comboBoxEmpfänger.SelectedItem.ToString().Split('–')[1].Remove(0, 5);
                controller.empfängerID = Int32.Parse(benutzerID);
                controller.NachrichtenSenden();
                
                //Prüfen, ob Nachricht versendet wurde
                if (controller.NachrichtWurdeGesendet() == true)
                {
                    richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Bold);
                    richTextBoxEmfpangeneNachrichten.SelectionColor = Color.Green;
                    richTextBoxEmfpangeneNachrichten.AppendText("> Nachricht wurde erfolgreich versendet!");
                }
                else
                {
                    richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Bold);
                    richTextBoxEmfpangeneNachrichten.SelectionColor = Color.Red;
                    richTextBoxEmfpangeneNachrichten.AppendText("> Nachricht wurde nicht versendet! Versuchs erneut.");
                }
            }
        }

        private void timerUpdateGui_Tick(object sender, EventArgs e)
        {
            // Prüft im Intervall von einer Sekunde, ob neue Nachrichten vorhanden sind
            foreach (List<string> nachrichten in controller.NachrichtenLaden())
            {
                if (!nachrichtenLog.Contains(Int32.Parse(nachrichten[2])))
                {
                    richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Bold);
                    richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[0]);
                    richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Regular);
                    richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[1]);

                    nachrichtenLog.Add(Int32.Parse(nachrichten[2]));
                }


            }
        }
    }
}
