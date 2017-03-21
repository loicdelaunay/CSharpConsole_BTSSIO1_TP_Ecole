using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Etudiant : ContactEcole
    {

        private string section;

        public Etudiant(int pAnneeArrivee, string pNom, string pSection) : base(pAnneeArrivee, pNom)
        {
            section = pSection;
        }

        public override string ToString()
        {
            return base.ToString()+" Section : "+section;
        }
    }
}
