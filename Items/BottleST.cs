using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class BottleST : Bottle
    {
        public readonly new string Name = "Stamina bottle";

        public override short Restore(short stamina)
        {
            return stamina += 30;
        }
    }
}
