using MySql.Data.MySqlClient;
using watchlist.models;

namespace watchlist.database
{
    public class DeleteWatched
    {
        public void RemoveWatchedShow(int showId)
        {
            ConnectionString mycs = new ConnectionString();
            string cs = mycs.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            // System.Console.WriteLine(showId);
            //Removes an item from the cart
            string stm = "DELETE FROM qzmcs9waprksg9rs.watched WHERE showId = @showId";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@showId", showId);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}