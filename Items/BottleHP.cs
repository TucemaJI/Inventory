using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class BottleHP : Bottle
    {
        internal readonly new string Name = "HP bottle";

        internal override short Restore (short hp)
        {
            return hp += 30;
        }
    }
}
