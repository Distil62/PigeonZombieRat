using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class UmbrellaCorpFactory : IEntitiesFactory
    {
        public Entities Build(int number, int height, int width)
        {
            int half = number / 2;
            var Dico = new Dictionary<string, Entity>(number);
            var Entities = new Entities();
            var Rng = new Random();
            var ObsCol = new CollisionObserver(Entities);
            Entity CreatedEntity;
            string key;

            while (number-- > 0)
            {
                key = Guid.NewGuid().ToString();
                if (number > half)
                {
                    CreatedEntity = new Zombie(Rng.Next() % width, Rng.Next() % height, key, ObsCol);
                }
                else
                {
                    if (Rng.Next() % 2 == 0)
                    {
                        CreatedEntity = new Pigeon(Rng.Next() % width, Rng.Next() % height, key, ObsCol);
                        if (Rng.Next() % 2 == 0)
                        {
                            CreatedEntity = new PacificPigeonDecorator((Pigeon) CreatedEntity);
                        }
                    }
                    else
                    {
                        CreatedEntity = new Rat(Rng.Next() % width, Rng.Next() % height, key, ObsCol);
                    }
                }
                Dico.Add(key, CreatedEntity);
            }

            Entities.AllEntities = Dico;

            return Entities;
        }
    }
}
