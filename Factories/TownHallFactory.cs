using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class TownHallFactory : IBuildingFactory
    {
        public Building Build()
        {
            return new TownHall();
        }
    }
}
