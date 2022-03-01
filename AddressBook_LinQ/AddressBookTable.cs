using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LinQ
{
    public class AddressBookTable
    {
        public DataTable CreateAddressBookDataTable()
        {
            //DataTable 
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));

            dataTable.Rows.Add("Ismael ", "Whitlatch", "2319  Burton Avenue", "Memphis", "Tennessee", 38117, 9017658987, "sa5bxlla2e@temporary-mail.net");
            dataTable.Rows.Add("Christopher ", "Forst", "2846  Tori Lane", "Salt Lake City", "Utah", 84113, 8015870002, "ctmgz50esj@temporary-mail.net");
            dataTable.Rows.Add("David ", "Washington", "3379  Echo Lane", "TULAROSA", "New Mexico", 88352, 2699626511, "wkephpw9q2@temporary-mail.net");
            dataTable.Rows.Add("Byron ", "Daniels", "4385  West Street", "Grand Rapids", "Michigan", 49546, 6165758233, "6y4ug4knmib@temporary - mail.net");
            dataTable.Rows.Add("James ", "Juarez", "12564  Clay Street", "Indianapolis", "Indiana", 46214, 3174103617, "penlzpd00f@temporary - mail.net");
            return dataTable;
        }

        public void DisplayContacts(DataTable addresstable)
        {
            var contacts = addresstable.Rows.Cast<DataRow>();

            foreach (var contact in contacts)
            {
                Console.WriteLine("First Name : " + contact.Field<string>("FirstName") + " - " + "Last Name : " + contact.Field<string>("LastName") + " - " + "Address : " + contact.Field<string>("Address") + " - " + "City : " + contact.Field<string>("City") + " - " + "State : " + contact.Field<string>("State")
                    + " - " + "Zip : " + contact.Field<int>("Zip") + " - " + "Phone Number : " + contact.Field<long>("PhoneNumber") + " - " + "Email : " + contact.Field<string>("Email") + " ");
                Console.WriteLine();
            }
        }

        public void EditContact(DataTable dataTable)
        {
            var contacts = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "James");
            int count = contacts.Count();
            if (count > 0)
            {
                foreach (var contact in contacts)
                {
                    contact.SetField("LastName", "Lopez");
                    contact.SetField("City", "Washington Dc");
                    contact.SetField("State", "America");
                }
                Console.WriteLine("Contact is Changed Successfullu");
                DisplayContacts(contacts.CopyToDataTable());
            }
            else
            {
                Console.WriteLine("Contact Does not Found");
            }
        }
    }
}
