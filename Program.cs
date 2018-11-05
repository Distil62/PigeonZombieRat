using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuildingFactory> creators = new List<IBuildingFactory>()
            {
                new CasernFactory(),
                new MineFactory(),
                new TownHallFactory()
            };

            foreach (IBuildingFactory creator in creators)
            {
                Building product = creator.Build(); // 1 seule ligne….
                Console.WriteLine("Created {0}", product.GetType().Name);
                Console.WriteLine(product.ToString());
            }
                Console.ReadKey();
        }
    }
}
