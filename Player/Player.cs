using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Player
    {
        internal string Name { get; set; }

        internal short hp = 300;
        internal short mp = 600;
        internal short stamina = 700;

        Inventory inventory = new Inventory();
    }
}
