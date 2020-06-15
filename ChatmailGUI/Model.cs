﻿using it.schule;
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
        public int aktuellerUser = 7; // <---- aktueller User: Robert Bosch
        public bool nachrichtGesendet = false; 
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
            DataTable chatverlauf = db.ExecuteTable("Select * from Chatverlauf");

            foreach (DataRow zeile in nachrichtenTabelle.Rows)
            {
                Nachricht tempNachricht = new Nachricht();
                tempNachricht.Text = zeile["NachrichtenInhalt"].ToString();
                tempNachricht.ID = int.Parse(zeile["NachrichtenID"].ToString());
                tempNachricht.SenderID = int.Parse(zeile["SenderID"].ToString());
                tempNachricht.Zeitstempel = zeile["Zeitstempel"].ToString();

                foreach(DataRow chatverlaufEintrag in chatverlauf.Rows)
                {
                    if(Int32.Parse(chatverlaufEintrag[1].ToString()) == tempNachricht.ID)
                    {                      
                        tempNachricht.Empfänger.Add(Int32.Parse(chatverlaufEintrag[0].ToString()));
                    }
                }


                nachrichtenListe.Add(tempNachricht);
            }

            db.Close();
            return nachrichtenListe;

        }

        public void NachrichtHochladen()
        {
            db.Open();
            int nachrichtenID = 0;
            int vorherigeNachrichtenID = 0;

            DataTable getVorherigeNachrichtenID = db.ExecuteTable("SELECT NachrichtenID FROM nachrichten ORDER BY Zeitstempel DESC LIMIT 1;");
            foreach (DataRow vorherigeNachricht in getVorherigeNachrichtenID.Rows) { vorherigeNachrichtenID = Int32.Parse(vorherigeNachricht["NachrichtenID"].ToString()); }
            
            //Festlegen der SQL Abfragen
            string hochladenNachricht = "INSERT INTO nachrichten (NachrichtenID, NachrichtenInhalt, Zeitstempel, SenderID) VALUES(NULL, '" + zuSendenderText + "', current_timestamp(), '" + aktuellerUser + "');";
            string getNachrichtenID = "SELECT NachrichtenID FROM nachrichten where SenderID = " + aktuellerUser + " ORDER BY Zeitstempel DESC LIMIT 1;";
            
            //SQL Abfragen
            DataTable sqlAbfrage;
            sqlAbfrage = db.ExecuteTable(hochladenNachricht);
            sqlAbfrage = db.ExecuteTable(getNachrichtenID);

            //Get NachrichtenID
            foreach (DataRow zeile in sqlAbfrage.Rows)
            {
               nachrichtenID = Int32.Parse(zeile["NachrichtenID"].ToString());
            }
            //Nachricht Verknüpfen mit Empfänger Tabelle
            string hochladenEmpfänger = "INSERT INTO `chatverlauf` (`EmpfängerID`, `NachrichtenID`) VALUES('" + empfängerID + "', '" + nachrichtenID + "')"; //letzter Eintrag wo Sender ID senderID(in diesem Fall 7) ist
            sqlAbfrage = db.ExecuteTable(hochladenEmpfänger);

            //Check, ob Nachricht in Datenbank

                if(nachrichtenID != vorherigeNachrichtenID)
                {
                    nachrichtGesendet = true;
                } 
                else
                {
                    nachrichtGesendet = false; 
                }

            db.Close();
        }
    }
}
