using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Assignment 3 Main Menu ===");
            Console.WriteLine("1. Finance Management System (Q1)");
            Console.WriteLine("2. Healthcare System (Q2)");
            Console.WriteLine("3. Warehouse Inventory Management (Q3)");
            Console.WriteLine("4. School Grading System (Q4)");
            Console.WriteLine("5. Inventory Records System (Q5)");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1-6): ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    new FinanceApp().Run();
                    break;
                case "2":
                    new HealthSystemApp().Run();
                    break;
                case "3":
                    new WareHouseManager().Run();
                    break;
                case "4":
                    new StudentResultProcessor().Run();
                    break;
                case "5":
                    new InventoryApp().Run();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
