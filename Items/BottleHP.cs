using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class BottleHP : Bottle
    {
        public readonly new string Name = "HP bottle";

        public override short Restore (short hp)
        {
            return hp += 30;
        }
    }
}
