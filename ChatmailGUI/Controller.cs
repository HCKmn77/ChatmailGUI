using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatmailGUI
{
    class Controller
    {
        Model model = new Model();
        public string zuSendenderText;
        public int empfängerID;        

        public List<Benutzer> BenutzerLaden()
        {
            return model.Benuterliste();
        }

        public List<List<String>> NachrichtenLaden() 
        {
            List<List<String>> nachrichtenListe = new List<List<string>>(); 
            foreach (Nachricht nachricht in model.NachrichtenListe())
            {
                //Abfrage, ob Nachricht in Liste = für momentaner Benutzer (RobertBosch(7)) 
                if(nachricht.Empfänger.Contains(model.aktuellerUser))
                {
                    //Erstellen der Query um Benutzername des Senders zu bekommen
                    var senderNameQuery = from benutzer in model.Benuterliste()
                                          where benutzer.ID == nachricht.SenderID
                                          select benutzer.Name;

                    //neue Liste mit Nachrichteninhalt
                    List<string> nachrichten = new List<string>();

                    string nachrichtenInfo = "> " + nachricht.Zeitstempel + " " + senderNameQuery.First() + ": \n";
                    string nachrichtenText = nachricht.Text + "\n";
                    nachrichten.Add(nachrichtenInfo);
                    nachrichten.Add(nachrichtenText);
                    nachrichten.Add(nachricht.ID.ToString());
                    //Liste mit den einzelnen Nachrichten Objekten die den Inhalt NachrichtenInfo und Nachrichtentext haben
                    nachrichtenListe.Add(nachrichten);
                }
            }

            return nachrichtenListe;
                }


        public void NachrichtenSenden()
        {
            model.zuSendenderText = zuSendenderText;
            model.empfängerID = empfängerID;
            model.NachrichtHochladen();

        }
        public bool NachrichtWurdeGesendet()
        {
            return model.nachrichtGesendet;
        }

    }
}
