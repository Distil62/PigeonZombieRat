using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class Program
    {
        /// <summary>
        /// Bonsoir / Bonjour M.Gevrin
        /// Voici ma version du TP de la simulation 🐀 / 🐦 / 💀
        /// Les Designs Patterns intégrés aux projets sont :
        ///     Factory
        ///     Observer
        ///     Decorator
        /// Bugs connus :
        ///     Parfois les observateur de collision attachés aux entitiés sont sur null. Ce qui fait crasher l'application.
        ///     Les entités ne peuvent pas changer de type (être zombifié) dans le dictionnaire de Entities.
        ///     
        /// Bonne chance pour la review et bon courage :) ☕
        /// Louis Charavner - Ingésup B3
        /// </summary>
        static void Main()
        {
            int width = 10;
            int height = 10;
            int nuisibles = 10;
            var Monsters = new RandomFactory().Build(nuisibles, width, height);
            var Eco = new CommonEcosystem(width, height);
            var simu = new Simulation(Eco, Monsters);

            Console.WriteLine("*** Simulateur Pigeon Vs Rat Vs Zombie ***");
            Console.WriteLine("#=============Louis Charavner============#");
            Console.WriteLine("Explications :");
            Console.WriteLine("Cette simulation met en jeu un environnement peuplé de Zombies de Rat et de Pigeons");
            Console.WriteLine("À chaque itération les information de l'environnemnt vous sont données comme suit :");
            Console.WriteLine("\t * Entité \t: Le type de personnage (Pigeon, rat ou Zombie).");
            Console.WriteLine("\t * Position \t: La position x et y.");
            Console.WriteLine("\t * Vitesse \t: La vitesse de déplacement.");
            Console.WriteLine("#========================================#");
            Console.WriteLine("Appuyez sur une touche pour démarrer la simulation...");

            Console.ReadKey();
            simu.Run();
            Console.ReadKey();
        }
    }
}
