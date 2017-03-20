using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole_BTSSIO1_TP_Ecole
{
    class ContactEcole
    {
        private int anneeArrivee;
        private string nom;

        public ContactEcole(int pAnneeArrivee, string pNom)
        {
            anneeArrivee = pAnneeArrivee;
            nom = pNom;
        }

        public int GetAnneeArrivee()
        {
            return anneeArrivee;
        }

        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "Arrivé le : " + anneeArrivee;
        }
    }
}
