using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    public abstract class Observer : IObserver
    {
        protected Entities Subject { get; set; }

        public abstract void Update(Entity src, Entity target);
    }
}
