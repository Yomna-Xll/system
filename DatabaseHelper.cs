using System.Data.SQLite;

namespace WinFormsApp7
{
    public static class DatabaseHelper
    {
        private static string dbPath = "Data Source=citizen_app.db";

        public static void InsertRequest(string name, string national, string phone, string requestText)
        {
            using (var con = new SQLiteConnection(dbPath))
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Requests (Name, National, Phone, RequestText) VALUES (@n, @nat, @p, @r)", con);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@nat", national);
                cmd.Parameters.AddWithValue("@p", phone);
                cmd.Parameters.AddWithValue("@r", requestText);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertComplaint(string name, string national, string phone, string complaintText)
        {
            using (var con = new SQLiteConnection(dbPath))
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Complaints (Name, National, Phone, ComplaintText) VALUES (@n, @nat, @p, @c)", con);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@nat", national);
                cmd.Parameters.AddWithValue("@p", phone);
                cmd.Parameters.AddWithValue("@c", complaintText);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertReply(int requestId, string replyText)
        {
            using (var con = new SQLiteConnection(dbPath))
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Replies (RequestId, ReplyText) VALUES (@id, @r)", con);
                cmd.Parameters.AddWithValue("@id", requestId);
                cmd.Parameters.AddWithValue("@r", replyText);
                cmd.ExecuteNonQuery();
            }
        }
    }
} 