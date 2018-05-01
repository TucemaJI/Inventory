using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class BottleMP : Bottle
    {
        internal readonly new string Name = "MP bottle";

        internal override short Restore(short mp)
        {
            return mp += 30;
        }
    }
}
