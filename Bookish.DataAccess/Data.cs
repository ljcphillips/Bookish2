using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dapper;
using System.Collections.Specialized;

namespace Bookish2.DataAccess
{
    public class Book
    {
        public int BookID { get; set; }
        public char ISBN { get; set; }
        public char BookTitle { get; set; }
        public char BookAuthor { get; set; }
    }
    public class Item
    {
        public int ItemID { get; set; }
        public int UserID { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookID { get; set; }

        public static List<Item> GetAll()
        {
            string SqlString = "SELECT TOP 100 [ItemID],[UserID],[ReturnDate],[BookID] FROM [Items]";
            return (List<DataAccess.Item>)DataAccess.Connect.Db().Query<Item>(SqlString);
        }
    }

    public class Connect
    {
        public static IDbConnection Db()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
  

        
  
  
}

