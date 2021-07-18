using watchlist;
using watchlist.interfaces;
using watchlist.models;
using MySql.Data.MySqlClient;

namespace database
{
    public class SaveShow : ISaveShow
    {
        // public static void CreateShowTable()
        // {
        //     ConnectionString myConnection = new ConnectionString();
        //     string cs = myConnection.cs;

        //     using var con = new MySqlConnection(cs);
        //     con.Open();

        //     string stm = @"CREATE TABLE test(id INTEGER PRIMARY KEY AUTO_INCREMENT)";

        //     using var cmd = new MySqlCommand(stm, con);

        //     cmd.ExecuteNonQuery();
        // }
        public void CreateShow(Show myShow)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "INSERT INTO qzmcs9waprksg9rs.mylist (userId, showId) VALUES(@userId, @showId)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@userId", myShow.userId);
            cmd.Parameters.AddWithValue("@showId", myShow.showId);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        void ISaveShow.SaveShow(Show myShow)
        {
            throw new System.NotImplementedException();
        }
    }
}