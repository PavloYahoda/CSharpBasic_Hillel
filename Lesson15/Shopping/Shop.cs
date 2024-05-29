using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Shop
    {
        public static List<Product> listOfProducts = new List<Product>();

        public void AddProduct(Product prod) 
        {
            listOfProducts.Add(prod);
            Console.WriteLine($"Product {prod.Name} is added to shop");
        }
        public void RemoveProduct(int productId) {
            foreach (Product item in listOfProducts){
                if (item.Id == productId) {
                    listOfProducts.Remove(item);
                    Console.WriteLine($"Product {item.Name} is removed from shop");
                    break;
                }
            }
        }
        public string GetProductById(int productId)
        {
            string prodName = null;
            foreach (Product item in listOfProducts)
            {
                if (item.Id == productId)
                {
                    prodName = item.Name;
                }
            }
            return prodName != null ? prodName : $"There is no product with Id {productId}";
        }
        public static string GetAllProductsName() 
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                sb.Append(listOfProducts[i].Name);
                if (i < listOfProducts.Count - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
        public void GetAllProductsData() {
            foreach (Product item in listOfProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
