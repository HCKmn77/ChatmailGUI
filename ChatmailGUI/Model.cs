using it.schule;
using System;
using System.Collections.Generic;
using System.Data;

namespace ChatmailGUI
{
    class Model
    {
        DBconnector db = new DBconnector();

        public string zuSendenderText;
        public int empfängerID;
        int senderID = 7; // <---- aktueller User: Robert Bosch
        public Model()
        {
            db.Connector("localhost", "ChatmailDB", "root", "");

        }



        public List<Benutzer> Benuterliste()
        {
            db.Open();
            List<Benutzer> benutzerListe = new List<Benutzer>();
            DataTable benutzerTabelle = db.ExecuteTable("Select * from Benutzer");

            foreach (DataRow zeile in benutzerTabelle.Rows)
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
            db.Open();
            int nachrichtenID = 0;
            string hochladenNachricht = "INSERT INTO nachrichten (NachrichtenID, NachrichtenInhalt, Zeitstempel, SenderID) VALUES(NULL, '" + zuSendenderText + "', current_timestamp(), '" + senderID + "');";
            string getNachrichtenID = "SELECT NachrichtenID FROM nachrichten where SenderID = " + senderID + " ORDER BY Zeitstempel DESC LIMIT 1;";
            DataTable sqlAbfrage;
            sqlAbfrage = db.ExecuteTable(hochladenNachricht);
            sqlAbfrage = db.ExecuteTable(getNachrichtenID);
            foreach (DataRow zeile in sqlAbfrage.Rows)
            {
               nachrichtenID = Int32.Parse(zeile["NachrichtenID"].ToString());
            }
            string hochladenEmpfänger = "INSERT INTO `chatverlauf` (`EmpfängerID`, `NachrichtenID`) VALUES('" + empfängerID + "', '" + nachrichtenID + "')"; //letzter Eintrag wo Sender ID senderID(in diesem Fall 7) ist
            sqlAbfrage = db.ExecuteTable(hochladenEmpfänger);
            db.Close();
        }
    }
}
