using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatmailGUI
{
    class Nachricht
    {
        string nachrichtenText;
        Benutzer nachrichtenSender;
        int NachrichtenID;

        public Nachricht(string text, Benutzer sender, int id)
        {
            nachrichtenText = text;
            nachrichtenSender = sender;
            NachrichtenID = id;
        }


        public string text()
        {
            return nachrichtenText;
        }

        public Benutzer sender()
        {
            return nachrichtenSender;
        }

        public int id()
        {
            return NachrichtenID;
        }


    }
}
