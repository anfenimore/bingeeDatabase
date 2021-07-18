using MySql.Data.MySqlClient;
using watchlist;
using watchlist.interfaces;

namespace database
{
    public class DeleteShow : IDeleteShow
    {
        // public static void DropShowTable()
        // {
        //     ConnectionString myConnection = new ConnectionString();
        //     string cs = myConnection.cs;

        //     using var con = new MySqlConnection(cs);
        //     con.Open();

        //     string stm = @"DROP TABLE IF EXISTS shows";

        //     using var cmd = new MySqlCommand(stm, con);

        //     cmd.ExecuteNonQuery();
        // }


        void IDeleteShow.RemoveShow(int showId)
        {
            ConnectionString mycs = new ConnectionString();
            string cs = mycs.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            // System.Console.WriteLine(showId);
            //Removes an item from the cart
            string stm = "DELETE FROM qzmcs9waprksg9rs.mylist WHERE showId = @showId";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@showId", showId);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}