using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int userChoice;
                int type;
                bool isEnough = true;
                double cost;
                string[] products = new string[50];
                double[] prices = new double[50];

                Console.Clear();
                Console.WriteLine($"{(int)MainMenu.AddingNewProduct}. Add to cart\n" +
                    $"{(int)MainMenu.Exit}. Exit");
                Console.WriteLine("Please, make your choice:");
                userChoice = ReadChoice();
                Console.Clear();
                switch ((MainMenu)userChoice)
                {
                    case MainMenu.AddingNewProduct:
                        break;
                    case MainMenu.Exit: 
                        Environment.Exit(0);
                        break;
                }
                
                do
                {
                    Console.Clear();
                    Console.WriteLine($"{(int)ProductsMenu.Food}. Food\n" +
                        $"{(int)ProductsMenu.Clothing}. Clothing\n" +
                        $"{(int)ProductsMenu.Electronics}. Electronics\n" +
                        $"{(int)ProductsMenu.Books}. Books\n" +
                        $"{(int)ProductsMenu.Back}. Back");
                    Console.WriteLine("Please, make your choice:");
                    type = ReadType();
                    Console.Clear();
                    switch ((ProductsMenu)type)
                    {
                        case ProductsMenu.Food:
                            cost = SetCost();
                            SetToCard(products, prices, "Food", cost);
                            break;
                        case ProductsMenu.Clothing:
                            cost = SetCost();
                            SetToCard(products, prices, "Clothing", cost);
                            break;
                        case ProductsMenu.Electronics:
                            cost = SetCost();
                            SetToCard(products, prices, "Electronics", cost);
                            break;
                        case ProductsMenu.Books:
                            cost = SetCost();
                            SetToCard(products, prices, "Books", cost);
                            break;
                        case ProductsMenu.Back:
                            isEnough = false;
                            break;
                    }
                    Console.Clear();
                } while (isEnough);
                PrintBill(products, prices);
                PrintTotalCost(prices);
                Console.ReadKey();
                Console.Clear();
            }
            while (true);
        }

        static int ReadChoice()
        {
            MainMenu mainMenu;
            while ((!Enum.TryParse(Console.ReadLine(), out mainMenu) || !Enum.IsDefined(typeof(MainMenu), mainMenu))) 
            {
                ClearLastLine();
                Console.Write("You make wrong choice. Try again: ");
            }
            return (int)mainMenu;
        }
        static int ReadType()
        {
             ProductsMenu product;
            while ((!Enum.TryParse(Console.ReadLine(), out product) || !Enum.IsDefined(typeof(ProductsMenu), product)))
            {
                ClearLastLine();
                Console.Write("You make wrong choice. Try again: ");
            }
            return (int)product;
        }
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            //Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public static void SetToCard(string[] arrayProd, double[] arrayPrice, string product, double value) {
            int indexForProd = -1;
            for (int i = 0; i < arrayProd.Length; i++)
            {
                if (arrayProd[i] == null)
                {
                    indexForProd = i;
                    break;
                }
            }

            int indexForPrice = -1;
            for (int i = 0; i < arrayPrice.Length; i++)
            {
                if (arrayPrice[i] == 0)
                {
                    indexForPrice = i;
                    break;
                }
            }

            if (arrayProd[arrayProd.Length - 1] != null || arrayPrice[arrayPrice.Length - 1] != 0)
            {
                Console.WriteLine("Your card is full");
                Console.ReadKey();
            }
            else
            {
                arrayProd[indexForProd] = product;
                arrayPrice[indexForPrice] = value;
            }  
        }
        private static double SetCost()
        {
            double num;
            Console.Write("Enter the price: ");
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                ClearLastLine();
                Console.Write("Something went wrong. Try again: ");
            }
            return num;
        }
        private static double GetTotalCost(double[] arrayPrice)
        {
            double total = 0;
            int i = 0;
            while (arrayPrice[i] != 0) {
                total += arrayPrice[i];
                i++;
            }
            return total;
        }
        private static void PrintBill(string[] arrayProd, double[] arrayPrice) {
            int i = 0;

            if (arrayProd[0] == null || arrayPrice[0] == 0)
            {
                Console.WriteLine("Your cart is empty");
            }
            else { 
                while (arrayPrice[i] != 0)
                {
                    Console.WriteLine($"{arrayProd[i],-15} --> {arrayPrice[i],10}");
                    i++;
                }
            }
            
        }
        private static void PrintTotalCost(double[] arrayPrice) {
            double totalCost = 0;
            if (arrayPrice[0] == 0)
            {
                return;
            }
            else
            {
                totalCost = GetTotalCost(arrayPrice);
                Console.WriteLine($"Total cost is: {totalCost,15}");
            }
        }
    }
}
