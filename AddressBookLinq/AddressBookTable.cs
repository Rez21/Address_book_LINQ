using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBookTable
    {
        // UC 1 Create a new DataTable
        DataTable table = new DataTable("AddressBook");


        // UC 2 Initializes a new instance of the class.

        public AddressBookTable()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));

            // UC3 - add data to table
            table.Rows.Add("Raghav", "Ban", "Center Mall", "Yavatmal", "Maharashtra", "445001", "9595959595", "rban@gmail.com");
            table.Rows.Add("Ajay", "Rathod", "Ner", "Yavatmal", "Maharashtra", "125121", "8570934858", "aj@gmail.com");
            table.Rows.Add("Akshay", "Poriya", "Goregaon", "Bangalore", "Karnataka", "125433", "8585858585", "akshay.a@gmail.com");
            table.Rows.Add("Kretika", "Arora", "Andheri", "Mumbai", "Maharashtra", "125445", "7575757575", "kretika.arora@gmail.com");
            table.Rows.Add("Praveen", "Kumar", "rohini", "Delhi", "Delhi", "435121", "7897897898", "praveen.kumar@gmail.com");
            table.Rows.Add("Apoorva", "Singh", "Andheri", "Mumbai", "Maharashtra", "125445", "8598598599", "apporva.singh@gmail.com");
        }
    }
    }
}
