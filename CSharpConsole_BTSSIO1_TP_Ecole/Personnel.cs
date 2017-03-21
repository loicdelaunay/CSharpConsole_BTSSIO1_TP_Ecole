using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Personnel:ContactEcole
    {
        protected string nomLaboratoire;
        protected double salaire;

        public Personnel(int pAnneeArrivee, string pNom, string pNomLaboratoire, double pSalaire) : base(pAnneeArrivee, pNom)
        {
            nomLaboratoire = pNomLaboratoire;
            salaire = pSalaire;
        }

        /// <summary>
        /// Retourne le nom du laboratoire 
        /// </summary>
        /// <returns>Nom du laboratoire</returns>
        public string GetNomLaboratoire()
        {
            return nomLaboratoire;
        }

        /// <summary>
        /// Retourne le salaire
        /// </summary>
        /// <returns>Salaire</returns>
        public double GetSalaire()
        {
            return salaire;
        }

        /// <summary>
        /// Retourne l'objet en string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString()+" Nom du laboratoire : "+nomLaboratoire+" Salaire : "+salaire;
        }
    }
}
