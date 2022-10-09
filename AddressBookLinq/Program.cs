using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC 1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();

            // UC4 edit existing contact
            addressBookTable.EditExistingContact("Raghav", "Ban", "PhoneNumber", "8919810751");
            addressBookTable.GetAllContacts();
        }
    }
}