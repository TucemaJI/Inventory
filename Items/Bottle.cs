using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    abstract class Bottle : Item
    {
        protected new float Weight = 0.1f;

        internal abstract short Restore(short element);
    }
}
