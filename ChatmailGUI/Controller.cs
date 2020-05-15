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
            
        public List<Benutzer> BenutzerLaden()
        {
            return model.Benuterliste();
        }

        public List<Nachricht> NachrichtenLaden() 
        {
            return model.NachrichtenListe();
        }

        public void VerbindungPrüfen()
        {

        }

        public void NachrichtenSenden()
        {

        }
    }
}
