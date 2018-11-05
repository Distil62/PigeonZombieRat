using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    public class CollisionObserver : Observer
    {
        public Random Rng = new Random();

        public CollisionObserver(Entities Subject)
        {
            this.Subject = Subject;
            Subject.Attach(this);
        }

        public override void Update(Entity src, Entity target)
        {
            Console.WriteLine("Collision ! entre " + src.GetType() + " et " + target.GetType());
            if (src.GetType() == typeof(Zombie))
            {
                target = new Zombie(target);
                Console.WriteLine("Un nuisible a été zombifié");
            }

            else if (src.GetType() == typeof(Rat))
            {
                if (target.GetType() == typeof(Pigeon))
                {
                    if (Rng.Next() % 2 == 0)
                    {
                        Subject.AllEntities.Remove(target.Key);
                        Console.WriteLine("Un rat a tué un pigeon");
                    }
                    else
                    {
                        Subject.AllEntities.Remove(src.Key);
                        Console.WriteLine("Un pigeon à tué un rat");
                    }
                }
            }

            else if (src.GetType() == typeof(Pigeon))
            {
                if (target.GetType() == typeof(Rat))
                {
                    if (Rng.Next() % 2 == 0)
                    {
                        Subject.AllEntities.Remove(target.Key);
                        Console.WriteLine("Un pigeon à tué un rat");
                    }
                    else
                    {
                        Subject.AllEntities.Remove(src.Key);
                        Console.WriteLine("Un rat a tué un pigeon");
                    }
                }
            }
        }
    }
}
