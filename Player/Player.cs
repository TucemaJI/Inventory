using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Player
    {
        public string Name { get; set; }

        public short hp = 300;
        public short mp = 600;
        public short stamina = 700;

        public Inventory inventory = new Inventory();

        public void IntoInventory(Item item)
        {
            inventory.IntoInventory(item);
        }

        public int CapacityInventory()
        {
            return inventory.inventory.Capacity;
        }

        //public List<Item> ContentInventory (string bottle)
        //{

        //}

    }
}
