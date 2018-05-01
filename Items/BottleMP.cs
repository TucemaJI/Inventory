using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class BottleMP : Bottle
    {
        protected new string Name = "MP bottle";

        protected override short Restore(short mp)
        {
            return mp += 30;
        }
    }
}
