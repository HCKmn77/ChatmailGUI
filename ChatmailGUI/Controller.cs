using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatmailGUI
{
    class Controller
    {
        Model model = new Model();
            
        public void BenutzerLaden()
        {
        model.BenuterlisteErstellen();
        
        }

        public void NachrichtenLaden() 
        {
            model.NachrtichtenlisteErstellen();
        }

        public void VerbindungPrüfen()
        {

        }

        public void NachrichtenSenden()
        {

        }
    }
}
