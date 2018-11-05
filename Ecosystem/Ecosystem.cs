using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    /// <summary>
    /// Classe qui gère l'écosystème.
    /// Note de dev :
    /// Je voulais faire un système de case qui contienderais une liste des Entités présentes sur cette case 
    /// afin de stack plusieurs entités sur la même case mais je n'ai pas implementé cette feature.
    /// </summary>
    abstract class Ecosystem
    {
        private Dictionary<Tuple<int, int>, Case> Positions { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        protected Ecosystem(int height, int width)
        {
            Height = height;
            Width = width;
            Positions = InitPosition();
        }

        private Dictionary<Tuple<int, int>, Case> InitPosition()
        {
            var res = new Dictionary<Tuple<int, int>, Case>();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    res.Add(new Tuple<int, int>(x, y), new Case());
                }
            }

            return res;
        }
    }
}
