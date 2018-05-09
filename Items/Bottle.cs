using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public abstract class Bottle : Item
    {
        public new float Weight = 0.1f;

        public abstract short Restore(short element);


    }
}
