using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    class CitadinFactory : IEntitiesFactory
    {
        public Entities Build(int number, int height, int width)
        {
            var Dico = new Dictionary<string, Entity>(number);
            Entity CreatedEntity;
            var Entities = new Entities();
            var Rng = new Random();
            var ObsCol = new CollisionObserver(Entities);
            string key;

            while (number-- > 0)
            {
                key = Guid.NewGuid().ToString();
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
                Dico.Add(key, CreatedEntity);
            }

            Entities.AllEntities = Dico;

            return new Entities(Dico);
        }
    }
}
