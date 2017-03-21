using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Secretaire : Personnel
    {
        public Secretaire(int pAnneeArrivee, string pNom, string pNomLaboratoire, double pSalaire) : base(pAnneeArrivee, pNom, pNomLaboratoire, pSalaire)
        {
        }

        public override string ToString()
        {
            return "Secretaire : \n" + base.ToString();
        }
    }
}
