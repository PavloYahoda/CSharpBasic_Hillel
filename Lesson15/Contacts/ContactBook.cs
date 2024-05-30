using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContactBook
    {
        public static Dictionary<string, string> contacts = new Dictionary<string, string>() {
            {"Pavlo", "0123456789"},
            {"Bogdan", "0123364455"},
            {"Andrii", "0123894434"},   
        };
        
        public void AddContact(string name, string phone) {
            contacts.Add(name, phone);
            Console.WriteLine("New contact is saved");
        }
        public void RemoveContact(string name)
        {
            bool isExist = false;
            if (contacts.ContainsKey(name)) {
                contacts.Remove(name);
                isExist = true;
            }
            Console.WriteLine(isExist ? $"{name} is deleted from Contacts" : $"There is no {name} in contacts");
        }
        public void ChangeContact(string name)
        {
            bool isExistForGhange = false;
            if (contacts.ContainsKey(name)) {
                Console.Write("Enter new phone number: ");
                contacts[name] = Console.ReadLine();
                isExistForGhange = true;
            }
            Console.WriteLine(isExistForGhange ? $"{name} is changed" : $"There is no {name} in contacts");
        }
        public void FindContact(string name)
        {
            bool isFound = false;
            if (contacts.ContainsKey(name)) {
                isFound = true;
            }
            Console.WriteLine(isFound ? $"{name}: {contacts[name]}" : $"There is no {name} in contacts");
        }
        public void GetAllContacts()
        {
            foreach (var item in contacts)
            {
                Console.Write($"{item.Key}:\t {item.Value}\n");
            }
        }
    }
}
