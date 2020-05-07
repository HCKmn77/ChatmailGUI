using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        DBconnector db = new DBconnector();


        public FormChatmail()
        {
            InitializeComponent();
        }
        public void verbindungHerstellen()
        {
            try
            {
                db.Open();
                radioButtonDBVerbindung.Checked = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Verbindung zur Datenbank konnte nicht hergestellt werden!");
                radioButtonDBVerbindung.Checked = false;
                db.Close();
            }
        }
        private void FormChatmail_Load(object sender, EventArgs e)
        {
                db.Connector("localhost", "ChatmailDB", "root", "");
                DataTable benutzerLaden = db.ExecuteTable("Select Namen from Benutzer");

                for (int i = 0; i < benutzerLaden.Rows.Count; i++)
                {
                    comboBoxEmpfänger.Items.Add(benutzerLaden.Rows[i][0]);
                }


            db.Close();
        }
       


        private void buttonSenden_Click(object sender, EventArgs e)
        {
            verbindungHerstellen();
            DataTable ergebnisTabelle = db.ExecuteTable("Select * from Benutzer");
           
            db.Close();
        }

        private void timerUpdateGui_Tick(object sender, EventArgs e)
        {
            verbindungHerstellen();
           
            DataTable nachrichtenTabelle = db.ExecuteTable("Select Zeitstempel, NachrichtenInhalt from nachrichten where SenderID = 1 ");
            dataGridView1.Columns.Add("Zeitstempel", "Zeit");
            dataGridView1.Columns.Add("NachrichtenInhalt", "Nachricht");
            dataGridView1.Columns.Add("SenderID", "Sender");


            foreach (DataRow row in nachrichtenTabelle.Rows)
            {
                /* 
                 * if (item != vorhanden)
                {
                    textBoxEmfangeneNachricht.AppendText(item);
                } 
                */
                dataGridView1.
                dataGridView1.Rows.Add(row);

            }
            db.Close();
        }
    }
}
