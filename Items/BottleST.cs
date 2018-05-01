using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    class BottleST : Bottle
    {
        protected new string Name = "Stamina bottle";

        protected override short Restore(short stamina)
        {
            return stamina += 30;
        }
    }
}
