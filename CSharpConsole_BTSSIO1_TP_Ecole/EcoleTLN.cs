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
            uneEcole.AjouterUnContact(new EtudiantRegulier(2010,"Gaston Peutimide","système de communication",6.0));
            uneEcole.AjouterUnContact(new EtudiantRegulier(2003,"Gaston Peutimide","système de communication",6.0));
            Console.WriteLine(uneEcole.AncienneMoyenne());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
