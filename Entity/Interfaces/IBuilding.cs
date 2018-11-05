using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    interface IBuilding
    {
        void Destroy();

        void StartBuilding();

        void PauseBuilding();
    }
}
