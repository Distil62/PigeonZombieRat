using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    public class PacificPigeonDecorator : Pigeon
    {
        protected Pigeon Pigeon;

        public PacificPigeonDecorator(Pigeon wrappedPigeon) : base (wrappedPigeon)
        {
            Pigeon = wrappedPigeon;
        }
    }
}
