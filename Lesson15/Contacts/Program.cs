using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
                int userChoice;
                ContactBook cb = new ContactBook();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Main menu:\n" +
                        "1. Add contact\n" +
                        "2. Remove contact\n" +
                        "3. Edit contact\n" +
                        "4. Find contact\n" +
                        "5. Show all contacts\n" +
                        "0. For Exit");

                    Console.Write("Please, make your choice: ");
                    userChoice = Helper.ReadChoice();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case 1:
                            Console.Write("Enter name: ");
                            string nameForAdding = Console.ReadLine();
                            Console.Write("Enter phone number: ");
                            string phoneForAdding = Console.ReadLine();
                            cb.AddContact(nameForAdding, phoneForAdding);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("Enter name: ");
                            string nameForRemoving = Console.ReadLine();
                            cb.RemoveContact(nameForRemoving);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Enter name: ");
                            string nameForChanging = Console.ReadLine();
                            cb.ChangeContact(nameForChanging);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Write("Enter name: ");
                            string nameForSearching = Console.ReadLine();
                            cb.FindContact(nameForSearching);
                            Console.ReadKey();
                            break;
                        case 5:
                            cb.GetAllContacts();
                            Console.ReadKey();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
            } while (true);
        }
    }
}
