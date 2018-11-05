using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    /// <summary>
    /// Decorateur pour Pigeon.
    /// Note de dev : 
    /// J'aurais du faire une factory pour les Pigeons T_T 🐦 🏭
    /// J'ai mal lu la consigne c'était des nuisible pacifique et des Pigeons aggressifs T_T, ici c'est des Pigeons pacifiques
    /// </summary>
    public class PacificPigeonDecorator : Pigeon
    {
        protected Pigeon Pigeon;

        public PacificPigeonDecorator(Pigeon wrappedPigeon) : base (wrappedPigeon)
        {
            Pigeon = wrappedPigeon;
        }
    }
}
