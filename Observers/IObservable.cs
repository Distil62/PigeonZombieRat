using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    /// <summary>
    /// Interface générique à implementer sur les éléments à observer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IObservable<T>
    {
        T GetState();
        void SetState(T newState);
        void Attach(Observer obs);
    }
}
