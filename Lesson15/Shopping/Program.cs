using System;


namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            int customerChoice;
            int managerChoice;
            bool isEnough;

            Helper.FillShop();

            do
            {
                Console.WriteLine("Main menu:\n" +
                    "1. For customer\n" +
                    "2. For manager\n" +
                    "0. For Exit");

                Console.WriteLine("Please, make your choice:");
                userChoice = Helper.ReadChoice();
                Console.Clear();
                switch (userChoice)
                {
                    case 1:
                        Cart cart = new Cart();
                        isEnough = true;
                        do
                        {
                            Console.WriteLine("Customer menu:\n" +
                                "1. Add product to cart\n" +
                                "2. Remove product from cart\n" +
                                "3. Total price\n" +
                                "4. Show all products in the cart\n" +
                                "5. Show all products in the shop\n" +
                                "0. Back to Maim menu");

                            Console.WriteLine("Please, make your choice:");
                            customerChoice = Helper.ReadChoice();
                            Console.Clear();
                            switch (customerChoice)
                            {
                                case 1:
                                    Console.WriteLine("Enter product for adding:");
                                    cart.AddToCart(Console.ReadLine());
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter product for removing:");
                                    cart.RemoveFromCart(Console.ReadLine());
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine(cart.GetTotalPrice());
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    cart.GetProductsInCart();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine(Shop.GetAllProductsName());
                                    Console.ReadKey();
                                    break;
                                case 0:
                                    isEnough = false;
                                    break;
                            }
                            Console.Clear();
                        } while (isEnough);
                        
                        break;
                    case 2:
                        Shop shop = new Shop();
                        isEnough = true;
                        do 
                        {
                            Console.WriteLine("Manager menu:\n" +
                            "1. Add product to shop\n" +
                            "2. Remove product from shop\n" +
                            "3. Get product by ID\n" +
                            "4. Get all products name\n" +
                            "5. Get all products data\n" +
                            "0. Back to Maim menu");

                            Console.WriteLine("Please, make your choice:");
                            managerChoice = Helper.ReadChoice();
                            Console.Clear();
                            switch (managerChoice)
                            {
                                case 1:
                                    Console.WriteLine("Enter product's name:");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Enter product's price:");
                                    double price = Convert.ToDouble(Console.ReadLine());
                                    Product product = new Product(name, price);
                                    shop.AddProduct(product);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter product ID for removing:");
                                    shop.RemoveProduct(Convert.ToInt32(Console.ReadLine()));
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter product ID:");
                                    shop.GetProductById(Convert.ToInt32(Console.ReadLine()));
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine(Shop.GetAllProductsName());
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    shop.GetAllProductsData();
                                    Console.ReadKey();
                                    break;
                                case 0:
                                    isEnough = false;
                                    break;
                            }
                            Console.Clear();
                        } while (isEnough);
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Enter correct value: 1, 2, 0");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
