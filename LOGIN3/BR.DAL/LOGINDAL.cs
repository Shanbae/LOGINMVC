
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataAdapter = System.Data.SqlClient.SqlDataAdapter;

namespace LOGIN3.DAL
{
    public class LOGINDAL
    {
        public void Add(string Username, string Password, DateTime Sessiondate)
        {
            // string drr= IConfiguration.get
            SqlConnection conn = new SqlConnection("Data Source=SHANS-7799;Initial Catalog=LOGIN;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("LoginAdd", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("Sessiondate", Sessiondate);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void RegistrationAdd(string firstName, string lastName, string email, string phoneNumber, string passWord)
        {

            SqlConnection conn = new SqlConnection("Data Source=SHANS-7799;Initial Catalog=LOGIN;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("RegistrationAdd", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FirstName", firstName);
            cmd.Parameters.AddWithValue("LastName", lastName);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("Phone", phoneNumber);
            cmd.Parameters.AddWithValue("Password", passWord);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable fetchusernamepassword(string useName, string passWord, DataTable dt)
        {
            SqlConnection conn = new SqlConnection("Data Source=SHANS-7799;Initial Catalog=LOGIN;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("USERNAMEPASSWORDFETCH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Username", useName);
            cmd.Parameters.AddWithValue("Password", passWord);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;


        }


    }
}
