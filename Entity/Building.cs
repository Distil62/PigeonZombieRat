using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Building : IBuilding
    {
        public int          NbRows;
        public int          TimeToBuild;
        public int          HP;
        public Object       Mesh;
        public Coordinate   Position;

        protected int   BuildPercent;

        private bool IsBuilding;

        public void Destroy()
        {
        }

        public void PauseBuilding()
        {
        }

        public void StartBuilding()
        {
        }
    }
}
