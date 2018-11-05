using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    interface IEntity
    {
        void Moove(int width, int height);
        void Collision(Entity target);
        void Show();
    }
}
