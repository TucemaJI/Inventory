using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class BottleMP : Bottle
    {
        public readonly new string Name = "MP bottle";

        public override short Restore(short mp)
        {
            return mp += 30;
        }
    }
}
