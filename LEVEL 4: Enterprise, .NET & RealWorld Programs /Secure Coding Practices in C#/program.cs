using System.Data.SqlClient;

string connectionString =
    "your_connection_string";

string email =
    "user@gmail.com";

using SqlConnection connection =
    new SqlConnection(connectionString);

connection.Open();

string query =
    "SELECT * FROM Users " +
    "WHERE Email = @Email";

using SqlCommand command =
    new SqlCommand(query, connection);

command.Parameters.AddWithValue(
    "@Email",
    email);

using SqlDataReader reader =
    command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(
        reader["Email"]);
}

Console.WriteLine(
    "Secure Query Executed");
