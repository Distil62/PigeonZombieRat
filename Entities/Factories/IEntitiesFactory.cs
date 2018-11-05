using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    interface IEntitiesFactory
    {
        Entities Build(int number, int height, int width);
    }
}
