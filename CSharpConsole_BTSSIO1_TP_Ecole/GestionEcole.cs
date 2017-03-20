using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class GestionEcole
    {
        private List<ContactEcole> contacts;

        public GestionEcole()
        {
            contacts = new List<ContactEcole>();
        }

        /// <summary>
        /// Affiche tout les contacts (méthode pas apprécié car affichage writeline dans la classe )
        /// </summary>
        public void AfficheTout()
        {
            foreach (ContactEcole contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        /// <summary>
        /// Affiche tous les contacts
        /// </summary>
        /// <returns>Retourne en string tous les contacts</returns>
        public string AfficheToutv2()
        {
            string temporaire = "";
            foreach (ContactEcole contact in contacts)
            {
                temporaire += contact.ToString() + "\n";
            }
            return temporaire;
        }

        /// <summary>
        /// Ajoute un contact à l'école
        /// </summary>
        /// <param name="UnContact">Entrer le contact à ajouter</param>
        public void AjouterUnContact (ContactEcole UnContact)
        {
            contacts.Add(UnContact);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double AncienneMotenne() // A la recherche de son utilité !
        {
            return 0.0;
        }

        /// <summary>
        /// Vérifie si le contact est un étudiant 
        /// </summary>
        /// <param name="unContact">Contact à vérifier</param>
        /// <returns>Retourne True si le contact est un étudiant sinon False</returns>
        public Boolean EstEtudiant(ContactEcole unContact)
        {
            return unContact is Etudiant;
        }

        /// <summary>
        /// Retourne le nombre de contact
        /// </summary>
        /// <returns>Nombre de contact</returns>
        public int NbContacts()
        {
            return contacts.Count();
        }

        /// <summary>
        /// Retourne le nombre de contact étudiant 
        /// </summary>
        /// <returns>Nombre de contact étudiant</returns>
        public int NbEtudiant()
        {
            int temporaire = 0;
            foreach (ContactEcole contact in contacts)
            {
                if (EstEtudiant(contact))
                {
                    temporaire += 1;
                }
            }
            return temporaire;

        }

    }
}
