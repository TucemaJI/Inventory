namespace Inventory
{
    public class Player
    {
        public string Name { get; set; }

        public short HP { get; set; } = 300;
        public short MP { get; set; } = 600;
        public short Stamina { get; set; } = 700;

        public Inventory inventory = new Inventory();

        public void Restore(byte key)
        {
            switch (key)
            {
                case 1:
                    if (inventory.UseItem(key))
                    {
                        HP += 30;
                    }
                    break;
                case 2:
                    if (inventory.UseItem(key))
                    {
                        MP += 30;
                    }
                    break;
                case 3:
                    if (inventory.UseItem(key))
                    {
                        Stamina += 30;
                    }
                    break;
            }
        }
    }
}
