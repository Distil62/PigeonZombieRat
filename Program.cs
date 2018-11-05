using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 10;
            int height = 10;
            int nuisibles = 10;
            var Monsters = new UmbrellaCorpFactory().Build(nuisibles, width, height);
            var Eco = new CommonEcosystem(width, height);

            var simu = new Simulation(Eco, Monsters);

            simu.Run();
            Console.ReadKey();
        }
    }
}
