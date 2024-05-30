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
            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
                Console.WriteLine($"{name} is deleted from Contacts");
            }
            else {
                Console.WriteLine($"There is no {name} in contacts");
            }
        }
        public void ChangeContact(string name)
        {

            if (contacts.ContainsKey(name))
            {
                Console.Write("Enter new phone number: ");
                contacts[name] = Console.ReadLine();
                Console.WriteLine($"{name} is changed");
            }
            else {
                Console.WriteLine($"There is no {name} in contacts");
            }    
        }
        public void FindContact(string name)
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"{name}: {contacts[name]}");
            }
            else {
                Console.WriteLine($"There is no {name} in contacts");
            }  
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
