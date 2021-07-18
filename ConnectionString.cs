namespace watchlist
{
    public class ConnectionString
    {
        public string cs { get; set; }

        public ConnectionString()
        {
            string server = "s465z7sj4pwhp7fn.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "qzmcs9waprksg9rs";
            string port = "3306";
            string user = "yg3mf2rfbpbnwi91";
            string password = "vic5k9pqqta4w0id";

            cs = $@"server={server};user={user};database={database};port={port};password={password};";
        }
    }
}