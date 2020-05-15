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
        

        public List<Benutzer> Benuterliste()
        {
            db.Open();
                 List<Benutzer> benutzerListe = new List<Benutzer>();
                DataTable benutzerTabelle = db.ExecuteTable("Select * from Benutzer");
           
            foreach ( DataRow zeile in benutzerTabelle.Rows)
            {
                Benutzer tempBenutzer = new Benutzer();
                tempBenutzer.Name = zeile["Namen"].ToString();
                tempBenutzer.ID = int.Parse(zeile["BenutzerID"].ToString());
                benutzerListe.Add(tempBenutzer);
            }

            db.Close();
            return benutzerListe;
        }

        public List<Nachricht> NachrichtenListe()
        {
            db.Open();
            List<Nachricht> nachrichtenListe = new List<Nachricht>();
            DataTable nachrichtenTabelle = db.ExecuteTable("Select * from Nachrichten");

            foreach (DataRow zeile in nachrichtenTabelle.Rows)
            {
                Nachricht tempNachricht = new Nachricht();
                tempNachricht.Text = zeile["NachrichtenInhalt"].ToString();
                tempNachricht.ID = int.Parse(zeile["NachrichtenID"].ToString());
                tempNachricht.SenderID = int.Parse(zeile["SenderID"].ToString());
                tempNachricht.Zeitstempel = zeile["Zeitstempel"].ToString();
                nachrichtenListe.Add(tempNachricht);
            }

            db.Close();
            return nachrichtenListe;

        }

        public void NachrichtHochladen() 
        { 

        }
    }
}
