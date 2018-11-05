using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class Simulation
    {
        private Ecosystem Map { get; set; }
        private Entities Units { get; set; }

        public Simulation(Ecosystem map, Entities units)
        {
            Map = map;
            Units = units;
        }

        public void Run()
        {
            int iteration = 0;
            do
            {
                iteration++;
                Console.Clear();
                Units.MooveAll(Map.Height, Map.Width);
                Units.ShowAll();
                Console.WriteLine("Itération num " + iteration);
                Console.WriteLine("Appuyez sur flèche droite pour faire avancer la simulation...");
            } while (Console.ReadKey().Key == ConsoleKey.RightArrow);
        }

    }
}
