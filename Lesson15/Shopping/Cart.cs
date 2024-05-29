using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Cart
    {
        public List<Product> productsInCart = new List<Product>();

        public void AddToCart(string name)
        {
            foreach (Product item in Shop.listOfProducts) {
                if (name == item.Name)
                {
                    productsInCart.Add(item);
                    Console.WriteLine($"Product {item.Name} is added to cart");
                    break;
                }
            }   
        }
        public void RemoveFromCart(string name)
        {
            foreach (Product item in productsInCart)
            {
                if (name == item.Name)
                {
                    productsInCart.Remove(item);
                    Console.WriteLine($"Product {item.Name} is removed from cart");
                    break;
                }
                else
                {
                    Console.WriteLine("There is no product {name} in your cart");
                }
            }
        }
        public double GetTotalPrice() {
            double totalPrice = 0;
            foreach (Product item in productsInCart)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
        public void GetProductsInCart() {
            foreach (Product item in productsInCart)
            {
                Console.WriteLine(item);
            }
        }
    }
}
