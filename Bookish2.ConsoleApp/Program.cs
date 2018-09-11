using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish2.DataAccess;
using Dapper;

namespace Bookish2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var allItems = DataAccess.Item.GetAll();
            foreach (var Item in allItems)
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
