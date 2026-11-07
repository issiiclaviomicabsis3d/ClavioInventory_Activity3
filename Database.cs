using System.Data.OleDb;
using System.IO;

namespace claviomica_InventoryMS
{
    internal static class Database
    {
        private const string DatabaseFileName = "mica.accdb";

        private static string DatabasePath =>
            Path.GetFullPath(Path.Combine(
                AppContext.BaseDirectory,
                "..",
                "..",
                "..",
                DatabaseFileName));

        private static string ConnectionString =>
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Persist Security Info=False;";

        public static OleDbConnection CreateConnection()
        {
            if (!File.Exists(DatabasePath))
            {
                throw new FileNotFoundException(
                    $"The Access database '{DatabaseFileName}' was not found.",
                    DatabasePath);
            }

            return new OleDbConnection(ConnectionString);
        }

        public static OleDbConnection OpenConnection()
        {
            OleDbConnection connection = CreateConnection();
            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                connection.Dispose();
                throw;
            }
        }

        public static bool AuthenticateUser(string username, string password)
        {
            using OleDbConnection connection = OpenConnection();
            using OleDbCommand command = connection.CreateCommand();
            command.CommandText =
                "SELECT COUNT(*) FROM [Users] WHERE [Username] = ? AND [Password] = ?";
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }

        public static bool RegisterUser(
            string fullName,
            string username,
            string contactNumber,
            string email,
            string password)
        {
            using OleDbConnection connection = OpenConnection();

            using (OleDbCommand existingUserCommand = connection.CreateCommand())
            {
                existingUserCommand.CommandText =
                    "SELECT COUNT(*) FROM [Users] WHERE [Username] = ?";
                existingUserCommand.Parameters.AddWithValue("@Username", username);

                if (Convert.ToInt32(existingUserCommand.ExecuteScalar()) > 0)
                {
                    return false;
                }
            }

            using OleDbCommand command = connection.CreateCommand();
            command.CommandText =
                "INSERT INTO [Users] ([Full Name], [Username], [Contact Number], [Email], [Password]) " +
                "VALUES (?, ?, ?, ?, ?)";
            command.Parameters.AddWithValue("@FullName", fullName);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            return command.ExecuteNonQuery() == 1;
        }
    }
}
