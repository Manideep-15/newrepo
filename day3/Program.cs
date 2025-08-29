using System;
using System.Collections.Generic;
using System.Linq;

public class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"{Name} - {PhoneNumber}";
    }
}

public class ContactList
{
    private List<Contact> contacts = new List<Contact>();

    // Add a new contact
    public void AddContact(string name, string phoneNumber)
    {
        var contact = new Contact(name, phoneNumber);
        contacts.Add(contact);
        Console.WriteLine($"Contact added: {contact}");
    }

    // List all contacts
    public void ListContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            Console.WriteLine("Contacts list:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }

    // Find a contact by name
    public void FindContact(string name)
    {
        var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)
        {
            Console.WriteLine($"Contact found: {contact}");
        }
        else
        {
            Console.WriteLine($"No contact found with the name {name}");
        }
    }

    // Delete a contact by name
    public void DeleteContact(string name)
    {
        var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine($"Contact {name} deleted.");
        }
        else
        {
            Console.WriteLine($"No contact found with the name {name}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var contactList = new ContactList();

        while (true)
        {
            Console.WriteLine("\nContact List Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. List Contacts");
            Console.WriteLine("3. Find Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter contact name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter contact phone number: ");
                    string phoneNumber = Console.ReadLine();
                    contactList.AddContact(name, phoneNumber);
                    break;
                case "2":
                    contactList.ListContacts();
                    break;
                case "3":
                    Console.Write("Enter name to find: ");
                    string findName = Console.ReadLine();
                    contactList.FindContact(findName);
                    break;
                case "4":
                    Console.Write("Enter name to delete: ");
                    string deleteName = Console.ReadLine();
                    contactList.DeleteContact(deleteName);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

