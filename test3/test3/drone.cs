using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    abstract class drone
    {
        private int x;
        private int y;
        private int z;

        public int X1 { get => x; set => x = value; }
        public int Y1 { get => y; set => y = value; }
        public int Z1 { get => z; set => z = value; }

        
    }
    public abstract void Drone (int x, int y, int z);

}
