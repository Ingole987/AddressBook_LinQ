// See https://aka.ms/new-console-template for more information
using AddressBook_LinQ;
using System.Data;

Console.WriteLine("Welcome To Address Book Using LINQ !");
Console.WriteLine("------------------------------------");
AddressBookTable addressBookTable = new AddressBookTable();

DataTable data = addressBookTable.CreateAddressBookDataTable();

addressBookTable.EditContact(data);

//addressBookTable.DeleteContact(data);

addressBookTable.RetrieveContactByCityOrState(data);

addressBookTable.CheckSizeByCityOrState(data);

addressBookTable.SortContactsByLastName(data);

addressBookTable.DisplayContacts(data);

