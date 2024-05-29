using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Product
    {
        private static int id = 10000;
        public int Id {get; set;}
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) 
        {
            Id = id++;
            Name = name;
            Price = price;
        }
        public override string ToString() {
            return $"ID: {Id} \t Name: {Name} \t Price: {Price}";
        }
    }
}
