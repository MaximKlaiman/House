using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Particle
    {
        public int x;
        public int y;
        public int pastx;
        public int pasty;
        

        public Particle(int xx, int yy)
        {
            x = xx;
            y = yy;
        }

        public void Particleupdate()
        {
            pastx = x;
            pasty = y;

            y += 35;
            x -= 4;
            
        }

        public bool shouldelete()
        {
            if (y > 900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}
