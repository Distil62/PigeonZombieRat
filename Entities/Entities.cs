using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    /// <summary>
    /// Classe qui gère toutes les Entités présente dans un Ecosystème
    /// </summary>
    public class Entities : IEntities, IObservable<Dictionary<string, Entity>>
    {
        public Dictionary<string, Entity> AllEntities { get; set; }
        private List<Observer> Observers = new List<Observer>();
        private Random Rng = new Random();

        public Entities()
        {

        }

        public Entities(Dictionary<string, Entity> allEntities)
        {
            AllEntities = allEntities;
        }

        public void ShowAll()
        {
            foreach(var entity in AllEntities)
            {
                entity.Value.Show();
            }
        }

        public void MooveAll(int Height, int Width)
        {
            var AllEntitiesCpy = new Dictionary<string, Entity>(AllEntities);
            foreach (var entity in AllEntitiesCpy)
            {
                entity.Value.Moove(Height, Width);
                foreach (var verifEntity in AllEntitiesCpy)
                {
                    if (verifEntity.Value.Position.Item1 == entity.Value.Position.Item1
                        && verifEntity.Value.Position.Item2 == entity.Value.Position.Item2
                        && verifEntity.Key != entity.Key)
                    {
                        entity.Value.Collision(verifEntity.Value);
                    }
                }
            }
        }

        public Dictionary<string, Entity> GetState()
        {
            return AllEntities;
        }

        public void SetState(Dictionary<string, Entity> newState)
        {
            throw new NotImplementedException();
        }

        public void Attach(Observer obs)
        {
            Observers.Add(obs);
        }

    }
}
