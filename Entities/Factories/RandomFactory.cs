using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class RandomFactory : IEntitiesFactory
    {
        public Entities Build(int number, int height, int width)
        {
            int tmpRng;
            var Dico = new Dictionary<string, Entity>(number);
            var Entities = new Entities();
            var Rng = new Random();
            var ObsCol = new CollisionObserver(Entities);
            Entity CreatedEntity;
            string key;

            while (number-- > 0)
            {
                tmpRng = Rng.Next() % 3;
                key = Guid.NewGuid().ToString();

                switch (tmpRng)
                {
                    case 0:
                        CreatedEntity = new Zombie(Rng.Next() % width, Rng.Next() % height, key, ObsCol);
                        break;
                    case 1:
                        CreatedEntity = new Pigeon(Rng.Next() % width, Rng.Next() % height, key, ObsCol);
                        if (Rng.Next() % 2 == 0)
                        {
                            CreatedEntity = new PacificPigeonDecorator((Pigeon)CreatedEntity);
                        }
                        break;
                    case 2:
                    default:
                        CreatedEntity = new Rat(Rng.Next() % width, Rng.Next() % height, key, ObsCol);
                        break;
                }
                Dico.Add(key, CreatedEntity);
            }

            Entities.AllEntities = Dico;

            return Entities;
        }
    }
}
