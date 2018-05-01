using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class BottleHP : Bottle
    {
        protected new string Name = "HP bottle";

        protected override short Restore (short hp)
        {
            return hp += 30;
        }
    }
}
