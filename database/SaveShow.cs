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
            // myShow.userId = 1;
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "INSERT INTO qzmcs9waprksg9rs.mylist (userId, showId, name, image_thumbnail_path, network) VALUES(@userId, @showId, @name, @image_thumbnail_path, @network)";
            using var cmd = new MySqlCommand(stm, con);
            // cmd.Parameters.AddWithValue("@userId", myShow.userId);
            cmd.Parameters.AddWithValue("@userId", 1);
            cmd.Parameters.AddWithValue("@showId", myShow.showId);
            // cmd.Parameters.AddWithValue("@name", myShow.name);
            cmd.Parameters.AddWithValue("@name", myShow.name);
            cmd.Parameters.AddWithValue("@image_thumbnail_path", myShow.image_thumbnail_path);
            cmd.Parameters.AddWithValue("@network", myShow.network);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        void ISaveShow.SaveShow(Show myShow)
        {
            throw new System.NotImplementedException();
        }
    }
}