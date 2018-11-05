using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    interface IEntitiesFactory
    {
        /// <summary>
        /// Interface à appliquer sur toutes les EntitiesFactory
        /// </summary>
        /// <param name="number">Nombre d'entités à créer</param>
        /// <param name="height">Hauteur de la grille de l'écosystème (y)</param>
        /// <param name="width">Largeur de la grille de l'écosytème (x)</param>
        /// <returns></returns>
        Entities Build(int number, int height, int width);
    }
}
