using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Casern : Building, ICasern
    {
        public Unit Tier1Prototype;
        public Unit Tier2Prototype;
        public Unit Tier3Prototype;

        public Canon DefenseSlot;

        public Unit BuildUnit()
        {
            throw new NotImplementedException();
        }
    }
}
