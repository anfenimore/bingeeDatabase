using System.Collections.Generic;
using watchlist;
using watchlist.interfaces;
using watchlist.models;
using MySql.Data.MySqlClient;

namespace database
{
    public class ReadShow
    {
        public List<MyList> GetAllShows()
        {
            ConnectionString mycs = new ConnectionString();
            string cs = mycs.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            //Gets all items from the cart as well as the things that go with the item
            string stm = "SELECT * FROM qzmcs9waprksg9rs.users u INNER JOIN qzmcs9waprksg9rs.mylist m ON u.userId = m.userId;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            List<MyList> myShows = new List<MyList>();
            while (rdr.Read())
            {
                //creates the list from the database
                myShows.Add(new MyList() { userId = rdr.GetInt32(4), showId = rdr.GetInt32(5), name = rdr.GetString(6), image_thumbnail_page = rdr.GetString(7), network = rdr.GetString(8) });
            }
            return myShows;
        }
    }
}