using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class EtudiantRegulier : Etudiant
    {
        protected double noteMoyenne;

        public EtudiantRegulier(int pAnneeArrivee, string pNom, string pSection, double pNoteMoyenne) : base(pAnneeArrivee, pNom, pSection)
        {
            noteMoyenne = pNoteMoyenne;
        }

        public override string ToString()
        {
            return "EtudiantRegulier : \n" + base.ToString();
        }
    }
}
