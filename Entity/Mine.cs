using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Mine : Building, IMine
    {
        public int RessourcesLeftQuantity;
        public bool IsWorking;

        public void DeliverRessource()
        {
        }
    }
}
