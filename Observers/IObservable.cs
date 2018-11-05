using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonVsRatsVsZombie
{
    interface IObservable<T>
    {
        T GetState();
        void SetState(T newState);
        void Attach(Observer obs);
    }
}
