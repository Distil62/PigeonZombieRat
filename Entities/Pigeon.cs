using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    public class Pigeon : Entity
    {
        public Pigeon(int x, int y, string key, CollisionObserver obs) : base(x, y, key, obs)
        {
            Token = 'P';
        }

        public Pigeon(Entity cpy) : base(cpy)
        {
            Token = 'P';
        }
    }
}
