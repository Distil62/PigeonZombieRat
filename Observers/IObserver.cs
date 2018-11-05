using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    interface IObserver
    {
        void Update(Entity src, Entity target);
    }
}
