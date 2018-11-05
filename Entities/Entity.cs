using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    /// <summary>
    /// Classe de base de toutes les entitiés mobiles
    /// </summary>
    public abstract class Entity : IEntity
    {
        protected CollisionObserver CollisionObserver;
        protected char Token;
        public string Key { get; set; }
        public Tuple<int, int> Position { get; set; }
        protected int Speed { get; set; }
        protected Random Rng = new Random();

        protected Entity(int x, int y, string key, CollisionObserver collisionObserver)
        {
            CollisionObserver = collisionObserver;
            Position = new Tuple<int, int>(x, y);
            Key = key;
        }

        protected Entity(Entity cpy)
        {
            Position = cpy.Position;
            Speed = cpy.Speed;
        }

        public void Moove(int Height, int Width)
        {
            Array Values = Enum.GetValues(typeof(Direction));
            Direction where = (Direction)Values.GetValue(Rng.Next(Values.Length));

            switch (where)
            {
                case Direction.Haut:
                    Position = new Tuple<int, int>(Position.Item1 % Width, Position.Item2 - 1 % Height);
                    break;
                case Direction.HautDroite:
                    Position = new Tuple<int, int>((Position.Item1 + 1 )% Width, (Position.Item2 - 1 ) % Height);
                    break;
                case Direction.Droite:
                    Position = new Tuple<int, int>((Position.Item1 + 1 ) % Width, Position.Item2 % Height);
                    break;
                case Direction.BasDroite:
                    Position = new Tuple<int, int>((Position.Item1 + 1) % Width, (Position.Item2 + 1 ) % Height);
                    break;
                case Direction.Bas:
                    Position = new Tuple<int, int>(Position.Item1 % Width, (Position.Item2 + 1) % Height);
                    break;
                case Direction.BasGauche:
                    Position = new Tuple<int, int>((Position.Item1 - 1) % Width, (Position.Item2 + 1) % Height);
                    break;
                case Direction.Gauche:
                    Position = new Tuple<int, int>(Position.Item1 - 1 % Width, Position.Item2);
                    break;
                case Direction.HautGauche:
                    Position = new Tuple<int, int>((Position.Item1 - 1) % Width, (Position.Item2 - 1) % Height);
                    break;
                default:
                    // Unexcepted case
                    throw new Exception();
            }
        }

        public void Show()
        {
            Console.WriteLine("Entité : " + this.GetType());
            Console.WriteLine("Position : x => " + Position.Item1 + " y => " + Position.Item2);
            Console.WriteLine("Vitesse :" + Speed);
        }

        public void Collision(Entity target)
        {
            CollisionObserver.Update(this, target);
        }
    }
}
