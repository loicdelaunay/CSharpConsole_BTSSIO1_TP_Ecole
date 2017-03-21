using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class EtudiantEchange : Etudiant
    {
        protected string universiteOrigine;

        public EtudiantEchange(int pAnneeArrivee, string pNom, string pSection, string pUniversiteOrigine) : base(pAnneeArrivee, pNom, pSection)
        {
            universiteOrigine = pUniversiteOrigine;
        }

        public string GetUniversiteOrigine()
        {
            return universiteOrigine;
        }

        public override string ToString()
        {
            return "EtudiantEchange : \n" + base.ToString();
        }
    }
}
