using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory
    {
        private byte maxWeight = 100;

        List<Item> inventory = new List<Item>(capacity: 60);

        internal void IntoInventory(Item item)
        {
            inventory.Add(item);
        }
    }
}
