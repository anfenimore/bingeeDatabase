using MySql.Data.MySqlClient;
using watchlist.models;

namespace watchlist.database
{
    public class SaveWatched
    {
        public void SaveWatchedShow(Show myShow)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "INSERT INTO qzmcs9waprksg9rs.watched (userId, showId, name, image_thumbnail_path, network) VALUES(@userId, @showId, @name, @image_thumbnail_path, @network)";
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
    }
}