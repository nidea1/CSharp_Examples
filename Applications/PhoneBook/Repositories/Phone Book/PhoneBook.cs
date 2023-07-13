using System;
using System.Collections.Generic;
public class PhoneBook : IPhoneBook
{
    private List<Contact> _contacts = new List<Contact> {
        new Contact { FullName = "Ali Mehmet", Number = "5301231212"},
        new Contact { FullName = "Ahmet Mehmet", Number = "5311231212"},
        new Contact { FullName = "Ali Mahmut", Number = "5321231212"},
        new Contact { FullName = "Ayşe Fatma", Number = "5331231212"},
        new Contact { FullName = "Murat Hayriye", Number = "5341231212"},
    };

    public List<Contact> GetAllContacts()
    {
        return _contacts;
    }

    public Contact GetContactByName(string fullName)
    {
        return _contacts.Find(contact => contact.FullName == fullName);
    }

    public Contact GetContactByNumber(string number)
    {
        return _contacts.Find(contact => contact.Number == number);
    }

    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }

    public void DeleteContact(string fullName)
    {
        var contact = GetContactByName(fullName);
        _contacts.Remove(contact);
    }

    public void UpdateContact(string fullName, Contact newContact)
    {
        var oldContact = GetContactByName(fullName);
        if (oldContact != null)
        {
            oldContact.FullName = newContact.FullName;
            oldContact.Number = newContact.Number;
        }
    }    
}
