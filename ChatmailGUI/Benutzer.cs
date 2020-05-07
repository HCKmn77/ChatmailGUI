using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatmailGUI
{
    class Benutzer
    {

        string benutzerName;
        int benutzerID;

        public Benutzer(string name, int id)
        {
           
            
            benutzerName = name;
            benutzerID = id;
        }

        public int id()
        {
            return benutzerID;
        }
        public string name()
        {
            return benutzerName;
        }

    }
}
