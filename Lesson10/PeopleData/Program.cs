using System;

namespace PeopleData
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John Gaspar", 32, "Male");
            Person person2 = new Person("Jack Black");
            Person person3 = new Person("Hanky Bannister", 16);

            PersonData(person1);
            PersonData(person2);
            PersonData(person3);
        }

        public static void PersonData(Person person) {
            Console.Clear();
            person.PrintDetails();
            Console.WriteLine($"Is he/she adult? {person.IsAdult()}\n");
            person.ChangeName();
            person.PrintDetails();
            Console.ReadKey();
        }
    }
}
