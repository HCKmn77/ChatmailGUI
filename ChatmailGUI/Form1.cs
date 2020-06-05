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
            foreach (Benutzer benutzer in controller.BenutzerLaden())
            {
                comboBoxEmpfänger.Items.Add(benutzer.Name + " - " + benutzer.ID);
            }

            
            /*
            foreach (List<string> nachrichten in controller.NachrichtenLaden())
            {
                
                richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Bold);
                richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[0]);
                richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Regular);
                richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[1]);

                nachrichtenLog.Add(Int32.Parse(nachrichten[2]));

            }

            */
            


        }
       
        private void buttonSenden_Click(object sender, EventArgs e)
        {
            controller.zuSendenderText = textBoxNachrichtVerfassen.Text;
            string benutzerID = comboBoxEmpfänger.SelectedItem.ToString().Split('-')[1].Remove(0,1);
            controller.empfängerID = Int32.Parse(benutzerID);
            controller.NachrichtenSenden();
        }

        private void timerUpdateGui_Tick(object sender, EventArgs e)
        {
            foreach (List<string> nachrichten in controller.NachrichtenLaden())
            {
                if (!(nachrichtenLog.Contains(Int32.Parse(nachrichten[2]))))
                {
                    richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Bold);
                    richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[0]);
                    richTextBoxEmfpangeneNachrichten.SelectionFont = new Font(richTextBoxEmfpangeneNachrichten.Font, FontStyle.Regular);
                    richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[1]);

                    nachrichtenLog.Add(Int32.Parse(nachrichten[2]));
                }


            }

            
            /*
            Log-Liste 
            if Ist ID in Log Liste
            true: pass
            else: richtTextBox.AppendText 
                            richTextBoxEmfpangeneNachrichten.AppendText(nachrichten[1]);

     */
        }
    }
}
