using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class Zombie : Entity
    {

        public Zombie(int x, int y, string key, CollisionObserver obs) : base(x, y, key, obs)
        {
            Token = 'Z';
        }

        public Zombie(Entity cpy) : base(cpy)
        {
            Token = 'Z';
        }
    }
}
