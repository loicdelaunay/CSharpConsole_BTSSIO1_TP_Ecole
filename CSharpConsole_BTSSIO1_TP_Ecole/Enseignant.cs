using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Enseignant : Personnel

    {
        protected string section;

        public Enseignant(int pAnneeArrivee, string pNom, string pNomLaboratoire, double pSalaire, string pSection) : base(pAnneeArrivee, pNom, pNomLaboratoire, pSalaire)
        {
            section = pSection;
        }

        public override string ToString()
        {
            return "\nEnseignant : \n" + base.ToString();
        }
    }
}
