using System;
using System.Collections.Generic;

class MenuOrderingSystem
{
    static void Main()
    {
        while (true) // This loop allows the user to restart the process after completion
        {
            // Menu categories and items
            string[] meals = { "Spaghetti", "Pancit Palabok", "Burger Steak with Rice", "Fried Chicken with Rice", "Siomai Rice", "Sisig Rice", "Tapsilog", "Chicken Teriyaki" };

            string[] drinksAndSides = { "Hotdog Sandwich", "Burger", "Hamburger", "Cheeseburger", "Chickenburger", "French Fries", "Coke", "Pineapple Juice", "Lemonade", "Iced Tea", "Iced Coffee", "Water" };

            string[] desserts = { "Brownies", "Egg Pie", "Fruit Salad", "Halo-halo", "Ice Cream Choco", "Ice Cream Vanilla" };

            string[] addOns = { "Rice", "Ketchup", "Mustard" };

            double[] mealPrices = { 50, 60, 70, 80, 45, 85, 30, 70 };
            double[] drinksAndSidesPrices = { 40, 50, 60, 65, 70, 45, 20, 25, 25, 30, 40, 15 };
            double[] dessertPrices = { 20, 25, 60, 70, 50, 50 };
            double[] addOnPrices = { 15, 5, 5 };

            double totalCost = 0;
            string input;

            // Lists to keep track of the items ordered
            List<string> orderedMeals = new List<string>();
            List<string> orderedDrinksAndSides = new List<string>();
            List<string> orderedDesserts = new List<string>();
            List<string> orderedAddOns = new List<string>();

            Console.WriteLine("     Welcome to the Menu Ordering System!     ");
            Console.WriteLine();
            Console.WriteLine("Press any key to proceed with your order.");
            Console.ReadKey(); // Wait for costumer to press a key
            Console.WriteLine();

            // Display and order Meals
            Console.WriteLine("\nMeals:");
            for (int i = 0; i < meals.Length; i++)
                Console.WriteLine($"[{i + 1}] {meals[i]} - Php {mealPrices[i]}.00");

            while (true)
            {
                Console.Write("\nEnter the number of the Meal you want to order (Type 'done' to finish ordering Meals): ");
                input = Console.ReadLine().ToLower();
                if (input == "done") break;

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= meals.Length)
                {
                    orderedMeals.Add(meals[choice - 1]);
                    totalCost += mealPrices[choice - 1];
                    Console.WriteLine();
                    Console.WriteLine($"You added {meals[choice - 1]} to your order.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }

            // Display and order Drinks and Sides
            Console.WriteLine("\nDrinks and Sides:");
            for (int i = 0; i < drinksAndSides.Length; i++)
                Console.WriteLine($"[{i + 1}] {drinksAndSides[i]} - Php {drinksAndSidesPrices[i]}.00");

            while (true)
            {
                Console.Write("\nEnter the number of the Drink/Side you want to order (Type 'done' to finish ordering Drinks and Sides): ");
                input = Console.ReadLine().ToLower();
                if (input == "done") break;

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= drinksAndSides.Length)
                {
                    orderedDrinksAndSides.Add(drinksAndSides[choice - 1]);
                    totalCost += drinksAndSidesPrices[choice - 1];
                    Console.WriteLine();
                    Console.WriteLine($"You added {drinksAndSides[choice - 1]} to your order.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }

            // Display and order Desserts
            Console.WriteLine("\nDesserts:");
            for (int i = 0; i < desserts.Length; i++)
                Console.WriteLine($"[{i + 1}] {desserts[i]} - Php {dessertPrices[i]}.00");

            while (true)
            {
                Console.Write("\nEnter the number of the Dessert you want to order (Type 'done' to finish ordering Dessert): ");
                input = Console.ReadLine().ToLower();
                if (input == "done") break;

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= desserts.Length)
                {
                    orderedDesserts.Add(desserts[choice - 1]);
                    totalCost += dessertPrices[choice - 1];
                    Console.WriteLine();
                    Console.WriteLine($"You added {desserts[choice - 1]} to your order.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }

            // Display and order Add-ons
            Console.WriteLine("\nAdd-ons:");
            for (int i = 0; i < addOns.Length; i++)
                Console.WriteLine($"[{i + 1}] {addOns[i]} - Php {addOnPrices[i]}.00");

            while (true)
            {
                Console.Write("\nEnter the number of the Add-on you want to order (Type 'done' to finish ordering Add-ons): ");
                input = Console.ReadLine().ToLower();
                if (input == "done") break;

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= addOns.Length)
                {
                    orderedAddOns.Add(addOns[choice - 1]);
                    totalCost += addOnPrices[choice - 1];
                    Console.WriteLine();
                    Console.WriteLine($"You added {addOns[choice - 1]} to your order.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }

            // Order Summary
            Console.WriteLine("\n--- Order Summary ---");

            // Meals
            if (orderedMeals.Count > 0)
            {
                Console.WriteLine("\nMeals:");
                foreach (var meal in orderedMeals)
                {
                    Console.WriteLine($"- {meal}");
                }
            }

            // Drinks and Sides
            if (orderedDrinksAndSides.Count > 0)
            {
                Console.WriteLine("\nDrinks and Sides:");
                foreach (var dns in orderedDrinksAndSides)
                {
                    Console.WriteLine($"- {dns}");
                }
            }

            // Desserts
            if (orderedDesserts.Count > 0)
            {
                Console.WriteLine("\nDesserts:");
                foreach (var dessert in orderedDesserts)
                {
                    Console.WriteLine($"- {dessert}");
                }
            }

            // Add-ons
            if (orderedAddOns.Count > 0)
            {
                Console.WriteLine("\nAdd-ons:");
                foreach (var addOn in orderedAddOns)
                {
                    Console.WriteLine($"- {addOn}");
                }
            }

            // Display total cost
            Console.WriteLine($"\nTotal order cost: Php {totalCost}.00");
            Console.WriteLine();

            // Select payment method
            Console.WriteLine("\nSelect Payment Method:");
            Console.WriteLine("[1] Cash");
            Console.WriteLine("[2] G-Cash");
            Console.WriteLine("[3] Card");

            string paymentMethod = "";
            while (true)
            {
                Console.Write("\nEnter the number of your payment method: ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    paymentMethod = "Cash";
                    break;
                }
                else if (input == "2")
                {
                    paymentMethod = "G-Cash";
                    break;
                }
                else if (input == "3")
                {
                    paymentMethod = "Card";
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please select a valid payment method.");
                }
            }

            // Payment process
            while (true)
            {
                Console.Write($"\nEnter the amount you want to pay using {paymentMethod}: Php ");
                if (double.TryParse(Console.ReadLine(), out double payment) && payment >= totalCost)
                {
                    double change = payment - totalCost;
                    Console.WriteLine();
                    Console.WriteLine($"Payment accepted. Your change is: Php {change}.00");
                    Console.WriteLine();
                    Console.WriteLine("     Thank you for ordering! Enjoy your meal!        ");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Insufficient or invalid payment. Please try again.");
                }
            }

            // Dine in or Take out option
            Console.WriteLine("\nSelect Dining Option:");
            Console.WriteLine("[1] Dine in");
            Console.WriteLine("[2] Take out");
            string diningOption = "";
            while (true)
            {
                Console.Write("\nEnter the number of your choice: ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    diningOption = "Dine in";
                    Console.WriteLine("\nThank you! Please proceed to the dining area. Enjoy your meal!");
                    break;
                }
                else if (input == "2")
                {
                    diningOption = "Take out";
                    Console.WriteLine("\nThank you! Your order will be packed for take out. Enjoy your meal!");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }

            // Ask if the user wants to continue or exit
            string choiceExit;
            do
            {
                Console.WriteLine("\nDo you want to place another order?");
                Console.WriteLine("[1] Continue");
                Console.WriteLine("[2] Exit");
                choiceExit = Console.ReadLine();

                if (choiceExit == "2")
                {
                    break; // Exit the program if the user chooses "Exit"
                }
                else if (choiceExit != "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }

            while (choiceExit != "1");

            if (choiceExit == "2")
            {
                break; // Exit the program
            }
        }
    }
