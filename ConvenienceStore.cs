using System;
using System.Collections.Generic;

namespace ConvenienceStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Run();
        }
    }

    class Store
    {
        private decimal cash;
        private Dictionary<string, Item> inventory;

        public Store()
        {
            cash = 5000m; // Starting cash in PHP
            inventory = new Dictionary<string, Item>
            {
                { "Pic-A", new Item("Pic-A", 75.00m, 100) },
                { "Piattos", new Item("Piattos", 38.00m, 50) },
                { "Nova", new Item("Nova", 38.00m, 200) },
                { "Pillows", new Item("Pillows", 40.00m, 100) },
                { "Boy Bawang", new Item("Boy Bawang", 20.00m, 50) },
                { "Cheezy", new Item("Cheezy", 38.00m, 200) },
                { "Miggos", new Item("Miggos", 30.00m, 100) },
                { "O-puff", new Item("O-puff", 50.00m, 50) },
                { "Mentos", new Item("Mentos", 50.00m, 200) }
            };
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nConvenience Store ni EJAY");
                Console.WriteLine("1. Sell Item");
                Console.WriteLine("2. Restock Item");
                Console.WriteLine("3. View Cash Balance");
                Console.WriteLine("4. View Inventory");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SellItem();
                        break;
                    case "2":
                        RestockItem();
                        break;
                    case "3":
                        ViewCashBalance();
                        break;
                    case "4":
                        ViewInventory();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option, please try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        private void SellItem()
        {
            Console.WriteLine();
            Console.Write("Enter item name to sell: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Pic-A");
            Console.WriteLine("[2] Piattos");
            Console.WriteLine("[3] Nova");
            Console.WriteLine("[4] Pillows");
            Console.WriteLine("[5] Boy Bawang");
            Console.WriteLine("[6] Cheezy");
            Console.WriteLine("[7] Miggos");
            Console.WriteLine("[8] O-puff");
            Console.WriteLine("[9] Mentos");
            Console.WriteLine();
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {
                Item item = inventory[itemName];

                if (item.Quantity > 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Selling {item.Name} for ₱{item.Price}. Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    if (quantity <= item.Quantity)
                    {
                        decimal totalSale = item.Price * quantity;
                        cash += totalSale;
                        item.Quantity -= quantity;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Sold {quantity} {item.Name}(s). Total Sale: ₱{totalSale}. Cash balance: ₱{cash}.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Not enough {item.Name} in stock. Available: {item.Quantity}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{item.Name} is out of stock.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Item not found.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void RestockItem()
        {
            Console.WriteLine();
            Console.Write("Enter item name to restock: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Pic-A");
            Console.WriteLine("[2] Piattos");
            Console.WriteLine("[3] Nova");
            Console.WriteLine("[4] Pillows");
            Console.WriteLine("[5] Boy Bawang");
            Console.WriteLine("[6] Cheezy");
            Console.WriteLine("[7] Miggos");
            Console.WriteLine("[8] O-puff");
            Console.WriteLine("[9] Mentos");
            Console.WriteLine();
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Enter quantity to restock for {itemName}: ");
                int quantity = int.Parse(Console.ReadLine());
                inventory[itemName].Quantity += quantity;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Restocked {quantity} {itemName}(s). New quantity: {inventory[itemName].Quantity}.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Item not found.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void ViewCashBalance()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current Cash Balance: ₱{cash}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ViewInventory()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Current Inventory:");
            foreach (var item in inventory.Values)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{item.Name}: ₱{item.Price} - Quantity: {item.Quantity}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; set; }

        public Item(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
