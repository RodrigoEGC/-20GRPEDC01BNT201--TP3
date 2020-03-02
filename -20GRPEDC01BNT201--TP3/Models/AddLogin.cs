using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _20GRPEDC01BNT201__TP3.Models
{
    public class AddLogin
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\-20GRPEDC01BNT201--TP3\-20GRPEDC01BNT201--TP3\AppData\login.mdf;Integrated Security=True;");
        public int LoginCheck(LoginModel loginModel)
        {

            SqlCommand sqlCommand = new SqlCommand("Sp_Login", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Admin_id", loginModel.Admin_id);
            sqlCommand.Parameters.AddWithValue("@Password", loginModel.Ad_Password);
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@Isvalid";
            sqlParameter.SqlDbType = SqlDbType.Bit;
            sqlParameter.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            int result = Convert.ToInt32(sqlParameter.Value);
            sqlConnection.Close();
            return result;


        }
        
    }
}
