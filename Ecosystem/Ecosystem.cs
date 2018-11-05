using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
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
