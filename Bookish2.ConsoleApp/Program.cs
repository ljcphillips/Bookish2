using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish2.DataAccess;

namespace Bookish2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string SqlString = "SELECT TOP 100 [ItemID],[UserID],[ReturnDate],[BookID] FROM [Items]";
            var ourItems = (List<DataAccess.Item>)db.Query<Item>(SqlString);
            foreach (var Item in ourItems)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nItem ID: " + Item.ItemID.ToString());
                Console.WriteLine("\nUser ID: " + Item.UserID.ToString());
                Console.WriteLine("\nReturn Date: " + Item.ReturnDate.ToString());
                Console.WriteLine("\nBook ID: " + Item.BookID.ToString());
                Console.WriteLine(new string('*', 20));
            }
            Console.ReadLine();
        }
    }
}
