using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class Rat : Entity
    {
        public Rat(int x, int y, string key, CollisionObserver obs) : base(x, y, key, obs)
        {
            Token = 'R';
        }

        public Rat(Entity cpy) : base(cpy)
        {
            Token = 'R';
        }
    }
}
