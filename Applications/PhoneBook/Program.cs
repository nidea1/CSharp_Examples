using System;
class Program
{
    static IPhoneBook phoneBook = new PhoneBook();

    static void Main()
    {
        Console.WriteLine("Welcome to the Phone Book");

        while (true)
        {
            Console.WriteLine("Please select");
            Console.WriteLine("(1) Add a new number\n(2) Delete a number\n(3) Update a number\n(4) Get all contacts\n(5) Search in contacts\n(6) Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    DeleteContact();
                    break;
                case "3":
                    UpdateContact();
                    break;
                case "4":
                    GetAllContacts();
                    break;
                case "5":
                    SearchInContacts();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Select a valid option.");
                    break;
            }
        }
    }

    static void AddContact()
    {
        
        try{
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Phone Number: ");
            string number = Console.ReadLine();

            if (number.Length != 10){
                throw new Exception();
            }

            Contact _contact = new Contact {
                FullName = firstName + " " + lastName,
                Number = number
            };

            phoneBook.AddContact(_contact);

            Console.WriteLine("New contact added.");
        }catch{
            Console.WriteLine("Try again.");
        }
    }

    static void DeleteContact()
    {
            try
            {
                Console.Write("Enter contact's name or surname: ");
                string name = Console.ReadLine();

                var contact = phoneBook.GetAllContacts().Find(contact => contact.FullName.Split(' ').Any(n => n == name));

                if (contact != null)
                {
                    Console.WriteLine($"Are you confirm to delete this contact {contact.FullName}?(y/n)");
                    string response = Console.ReadLine().ToLower();
                    if (response == "y")
                    {
                        phoneBook.DeleteContact(contact.FullName);
                        Console.WriteLine("Contact deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Operation cancelled.");
                    }
                }
                else
                {
                    Console.WriteLine("No contact found with that name or surname.");
                    Console.WriteLine("Exit (1)");
                    Console.WriteLine("Try again (2)");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            break;
                        case "2":
                            DeleteContact();
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Try again.");
            }
    }

    static void UpdateContact()
    {
            try
            {
                Console.Write("Enter contact's name or surname: ");
                string name = Console.ReadLine();

                var contact = phoneBook.GetAllContacts().Find(contact => contact.FullName.Split(' ').Any(n => n == name));

                if (contact != null)
                {
                    Console.WriteLine($"Are you confirm to update this contact {contact.FullName}?(y/n)");
                    string response = Console.ReadLine().ToLower();
                    if (response == "y")
                    {
                        Console.Write("Enter name: ");
                        string newName = Console.ReadLine();

                        Console.Write("Enter surname: ");
                        string newSurName = Console.ReadLine();

                        Console.Write("Enter number: ");
                        string newNumber = Console.ReadLine();

                        Contact _contact = new Contact {
                            FullName = newName + " " + newSurName,
                            Number = newNumber
                        };

                        phoneBook.UpdateContact(contact.FullName, _contact);
                        Console.WriteLine("Contact updated.");
                    }
                    else
                    {
                        Console.WriteLine("Operation cancelled.");
                    }
                }
                else
                {
                    Console.WriteLine("No contact found with that name or surname.");
                    Console.WriteLine("Exit (1)");
                    Console.WriteLine("Try again (2)");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            break;
                        case "2":
                            UpdateContact();
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Try again.");
            }
    }

    static void GetAllContacts()
    {
        Console.WriteLine("Please select a sorting option");
        Console.WriteLine("(1) A-Z\n(2) Z-A");
        string sortOption = Console.ReadLine();

        var contacts = phoneBook.GetAllContacts();
        
        if (sortOption == "1")
        {
            contacts = contacts.OrderBy(c => c.FullName).ToList();
        }
        else if (sortOption == "2")
        {
            contacts = contacts.OrderByDescending(c => c.FullName).ToList();
        }

        Console.WriteLine("Phone Book\n*****************");

        foreach (var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.FullName.Split(' ')[0]} Surname: {contact.FullName.Split(' ')[1]} Number: {contact.Number}");
        }
    }

    static void SearchInContacts()
    {
        Console.WriteLine("Please select search type\n(1) With name or surname\n(2) With number");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
            {
                Console.Write("Name or surname: ");
                string name = Console.ReadLine();
                var matchingContacts = phoneBook.GetAllContacts().Where(c => c.FullName.Split(' ').Any(n => n == name)).ToList();

                if (matchingContacts.Count == 0)
                {
                    Console.WriteLine("No contact found with that name or surname.");
                }
                else
                {
                    foreach (var contact in matchingContacts)
                    {
                        Console.WriteLine($"Name: {contact.FullName.Split(' ')[0]} Surname: {contact.FullName.Split(' ')[1]} Number: {contact.Number}");
                    }
                }
                break;
            }
            case "2":
            {
                Console.Write("Number: ");
                string number = Console.ReadLine();
                var contact = phoneBook.GetContactByNumber(number);

                if (contact == null)
                {
                    Console.WriteLine("No contact found with that number");
                }
                else
                {
                    Console.WriteLine($"Name: {contact.FullName.Split(' ')[0]} Surname: {contact.FullName.Split(' ')[1]} Number: {contact.Number}");
                }
                break;
            }


        }
    }

}
