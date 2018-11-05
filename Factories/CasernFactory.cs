using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class CasernFactory : IBuildingFactory
    {
        public Building Build()
        {
            return new Casern();
        }
    }
}