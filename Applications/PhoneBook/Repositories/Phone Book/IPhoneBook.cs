using System;
public interface IPhoneBook
{   
    List<Contact> GetAllContacts();
    
    Contact GetContactByName(string fullName);

    Contact GetContactByNumber(string number);

    void AddContact(Contact contact);

    void DeleteContact(string fullName);
    
    void UpdateContact(string fullName, Contact contact);

}
