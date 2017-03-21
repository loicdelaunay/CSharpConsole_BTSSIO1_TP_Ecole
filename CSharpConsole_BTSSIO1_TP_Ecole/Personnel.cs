using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Personnel:ContactEcole
    {
        private string nomLaboratoire;
        private double salaire;

        public Personnel(int pAnneeArrivee, string pNom, string pNomLaboratoire, double pSalaire) : base(pAnneeArrivee, pNom)
        {
            nomLaboratoire = pNomLaboratoire;
            salaire = pSalaire;
        }

        public string GetNomLaboratoire()
        {
            return nomLaboratoire;
        }

        public double GetSalaire()
        {
            return salaire;
        }

        public override string ToString()
        {
            return base.ToString()+" Nom du laboratoire : "+nomLaboratoire+" Salaire : "+salaire;
        }
    }
}
