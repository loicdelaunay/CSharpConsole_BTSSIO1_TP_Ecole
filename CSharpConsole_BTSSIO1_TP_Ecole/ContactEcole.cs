using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
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

        /// <summary>
        /// Retourne l'année d'arrivée
        /// </summary>
        /// <returns>Année d'arrivée</returns>
        public int GetAnneeArrivee()
        {
            return anneeArrivee;
        }

        /// <summary>
        /// Retourne le nom
        /// </summary>
        /// <returns>Nom</returns>
        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "\nArrivé le : " + anneeArrivee;
        }
    }
}
