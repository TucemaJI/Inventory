using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory:IEnumerable<Item>
    {
        public byte maxWeight = 100;

        public List<Item> inventory = new List<Item>();

        public IEnumerator<Item> GetEnumerator()
        {
            return ((IEnumerable<Item>)inventory).GetEnumerator();
        }

        public void IntoInventory(Item item)
        {
            if (inventory.Capacity <= 10)
            {
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
                case 1:
                    var bottleHP = new BottleHP();
                    return bottleHP;
                case 2:
                    var bottleMP = new BottleMP();
                    return bottleMP;
                case 3:
                    var bottleST = new BottleST();
                    return bottleST;
            }
            var bottle = new BottleHP();
            return bottle;
        }

        enum Bottles:byte
        {
            bottleHP = 1,
            bottleMP = 2,
            bottleST = 3
        }



        //public Item UseBottleHP()
        //{
        //    foreach(var hpBottle in inventory)
        //    {
        //        if (hpBottle is BottleHP)
        //        {
        //            return hpBottle;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}



    }
}
