using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatmailGUI
{
    class ChatVerlauf
    {
        Benutzer chatverlaufEmpfänger;
        Nachricht chatVerlaufNachricht;

        public ChatVerlauf(Benutzer empfänger, Nachricht nachricht)
        {
            chatverlaufEmpfänger = empfänger;
            chatVerlaufNachricht = nachricht;
        }

        public Benutzer Empfänger()
        {
            return chatverlaufEmpfänger;
        }

        public Nachricht Nachricht()
        {
            return chatVerlaufNachricht;
        }

    }
}
