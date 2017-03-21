using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classe;

namespace EcoleTln
{
    class EcoleTln
    {
        static void Main(string[] args)
        {
            try
            {
                GestionEcole uneEcole = new GestionEcole();
                uneEcole.AjouterUnContact(new EtudiantRegulier(2013,"Gaston Peutimide","système de communication",6.0));
                uneEcole.AjouterUnContact(new EtudiantRegulier(2011,"Yvan Rattrepeur","système de communication",6.0));
                uneEcole.AjouterUnContact(new EtudiantEchange(2012,"Björn Borgue","section d'informatique","KTH"));
                uneEcole.AjouterUnContact(new Enseignant(1998,"Mathieu Matheu","Laboratoire des mathématiques",10000,"Section physique"));
                uneEcole.AjouterUnContact(new Secretaire(2002,"Sophie Scribona","LAboratoire des Machines à Taper",5000));
                Console.WriteLine("Parmi les " + uneEcole.NbContacts() + " personnes de l'écoleTLN, " + uneEcole.NbEtudiant() + " sont des étudiants");
                Console.WriteLine("Ils sont à l'école depuis en moyenne " + uneEcole.AncienneMoyenne() + " ans\n");
                Console.WriteLine(uneEcole.AfficheToutv2());
                Console.Read();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
