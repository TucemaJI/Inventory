using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            var player = new Player();
            Start();

            for (byte round = 0; round < Inventory._capacityInventory; round++)
            {
                ToConsole(player);
                bool isGood = false;
                byte key = 0;
                while (!isGood)
                {
                    Console.WriteLine("You will try while you write wrong number");
                    isGood = byte.TryParse(Console.ReadLine(), out key);
                    Console.Clear();
                }
                player.inventory.IntoInventory(player.inventory.SetItem(key));
                Console.Clear();
            }
            Console.WriteLine("You have filled your inventory!");
            Console.WriteLine("Start the game");
            
            Task usingBottles = new Task(() => UseBottles(player));
            usingBottles.Start();

            Task gettingDamage = new Task(() => GetDamage(player));
            gettingDamage.Start();

            while (!gettingDamage.IsCompleted)
            {
                if (gettingDamage.IsCompleted)
                {
                    usingBottles.Dispose();
                }
            }

            if (player.HP > 0 && player.MP > 0 && player.Stamina > 0)
            {
                Console.WriteLine("You won!");
            }
            Console.ReadLine();
        }

        static void UseBottles(Player player)
        {
            while (true)
            {
                byte.TryParse(Console.ReadLine(), out byte key);

                player.Restore(key);

                Console.Clear();
            }
        }

        static void GetDamage(Player player)
        {
            Random random = new Random();
            for (byte round = 0; round < byte.MaxValue; round++)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        player.HP -= 5;
                        break;
                    case 1:
                        player.MP -= 5;
                        break;
                    case 2:
                        player.Stamina -= 5;
                        break;
                }

                Console.Clear();
                ToConsole(player);

                Thread.Sleep(100);
                if (player.HP <= 0 || player.MP <= 0 || player.Stamina <= 0) 
                {
                    Console.WriteLine("You lose");
                    break; 
                }
            }
        }

        static void ToConsole(Player player)
        {
            Console.WriteLine("Your stats:");
            Console.WriteLine("HP " + player.HP);
            Console.WriteLine("MP " + player.MP);
            Console.WriteLine("ST " + player.Stamina);
            Console.WriteLine();
            Console.WriteLine("Inventory:");
            Console.WriteLine("HP Bottle " + player.inventory.Where(x => x.Name == "HP Bottle").Count());
            Console.WriteLine("MP Bottle " + player.inventory.Where(x => x.Name == "MP Bottle").Count());
            Console.WriteLine("ST Bottle " + player.inventory.Where(x => x.Name == "Stamina bottle").Count());
            Console.WriteLine();
            Console.WriteLine("Use your items:");
            Console.WriteLine("BottleHP is 1");
            Console.WriteLine("BottleMP is 2");
            Console.WriteLine("bottleST is 3");
        }

        static void Start()
        {
            Console.WriteLine("Welcome to my realy simple game!");
            Console.WriteLine("In this game you will try to stay alive.");
            Console.WriteLine("At first: Fill your Inventory!");
        }
    }
}
