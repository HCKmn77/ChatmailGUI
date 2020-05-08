using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using it.schule;

namespace ChatmailGUI
{
    class Model
    {
        DBconnector db = new DBconnector();

        public Model()
        {
            db.Connector("localhost", "ChatmailDB", "root", "");

        }
        

        public void BenuterlisteErstellen()
        {
            db.Open();
            List<Benutzer> benutzerListe = new List<Benutzer>();
            DataTable benutzerTabelle = db.ExecuteTable("Select * from Benutzer");
            for (int i = 0; i < benutzerTabelle.Rows.Count; i++)
            {
                string x = 
                Benutzer Jeremia = new Benutzer(benutzerTabelle.Rows[i][0].ToString(), Int32.Parse(benutzerTabelle.Rows[i][1].ToString()));
                
                
                //benutzerListe.Add(new Benutzer() { Name = , ID = 1234 });
            }


            //comboBoxEmpfänger.Items.Add(benutzerLaden.Rows[i][0]);



            db.Close();

        }

        public void NachrtichtenlisteErstellen()
        {

        }

        public void NachrichtHochladen() 
        { 

        }
    }
}
