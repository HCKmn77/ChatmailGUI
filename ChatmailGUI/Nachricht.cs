using System.Collections.Generic;

namespace ChatmailGUI
{
    class Nachricht
    {
        public string Text;
        public int  SenderID;
        public int ID;
        public string Zeitstempel;
        public List<int> Empfänger = new List<int>();
    }
}
