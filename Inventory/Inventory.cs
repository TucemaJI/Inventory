using System.Collections;
using System.Collections.Generic;

namespace Inventory
{
    public class Inventory : IEnumerable<Item>
    {
        public const byte _maxWeight = 100;
        public const byte _capacityInventory = 10;
        private float CurrentWeight { get; set; } = 0;



        private List<Item> inventory = new List<Item>();

        public IEnumerator<Item> GetEnumerator()
        {
            return ((IEnumerable<Item>)inventory).GetEnumerator();
        }

        public void IntoInventory(Item item)
        {
            if (inventory.Count < _capacityInventory && _maxWeight >= CurrentWeight)
            {
                CurrentWeight += item.Weight;
                inventory.Add(item);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Item>)inventory).GetEnumerator();
        }

        public Item SetItem(byte key)
        {
            switch (key)
            {
                case 1: return new BottleHP();
                case 2: return new BottleMP();
                case 3: return new BottleST();
                default: return new BottleHP();
            }
        }

        public bool UseItem(byte key)
        {
            switch (key)
            {
                case 1: return inventory.Remove(inventory.Find(x => x.Name == "HP Bottle"));
                case 2: return inventory.Remove(inventory.Find(x => x.Name == "MP Bottle"));
                case 3: return inventory.Remove(inventory.Find(x => x.Name == "Stamina bottle"));
                default: return false;
            }
        }
    }
}
