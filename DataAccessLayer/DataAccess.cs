using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccess
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dataReader;
        public static int IsAuthenticate(string userName, string password)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select * from Account where userName=@un and password=@pw";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@un", userName);
                cmd.Parameters.AddWithValue("@pw", password);

                dataReader = cmd.ExecuteReader();
                
                string takeUserType;
                if (dataReader.Read())
                {
                    takeUserType = dataReader.GetValue(4).ToString();
                    if (takeUserType.ToLower().Equals("customer"))
                    {
                        return 1;
                    }
                    else if (takeUserType.ToLower().Equals("admin"))
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }

        public static void InsertAccountData(SqlCommand cmd)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Insert into Account values(@userName,@password,@gender,@age,@userType)";
                cmd.CommandText = query;
                cmd.Connection = con;

                cmd.ExecuteNonQuery();

            }
        }

        public static void InsertProductDate(SqlCommand cmd)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Insert into Product values(@productID,@productName,@productType,@price,@companyName)";
                cmd.CommandText = query;
                cmd.Connection = con;

                cmd.ExecuteNonQuery();

            }
        }

        public static DataSet GetAvailableProduct()
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "Select * from Product";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Product");
                return ds;


            }
        }

        public static DataSet GetAvailableCustomer()
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "Select * from Account";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Account");
                return ds;


            }
        }


        public static DataSet SerachItem(string itemName)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "select * from Product where productName like '"+itemName+"%'";
                cmd = new SqlCommand(sqlQuery, con);
                

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Product");
                return ds;


            }
        }
    }
}
