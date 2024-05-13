using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleData
{
    public class Person
    {
        private string name;
        private int age = 0;
        private string sex = "Not defined";

        public Person(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }
        public void PrintDetails() {
            Console.WriteLine("Person data:");
            Console.WriteLine($"Name: {name}\n" +
                $"Age: {age}\n" +
                $"Sex: {sex}");
            Console.WriteLine();
        }
        public bool IsAdult() {
            return age > 18;
        }
        public void ChangeName() {
            string name;
            Console.WriteLine("Do you want to change name? Enter correct one:");
            name = Console.ReadLine();
            this.name = name;
            Console.WriteLine();
        }

    }
}
