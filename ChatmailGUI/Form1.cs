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
        Controller contr = new Controller();


        public FormChatmail()
        {
            InitializeComponent();
        }
       
        private void FormChatmail_Load(object sender, EventArgs e)
        {
            foreach (Benutzer benutzer in contr.BenutzerLaden())
            {
                comboBoxEmpfänger.Items.Add(benutzer.Name);
            }
            contr.BenutzerLaden();
            contr.NachrichtenLaden();
           
        }
       
        private void buttonSenden_Click(object sender, EventArgs e)
        {
           
          
        }

        private void timerUpdateGui_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
