using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAccessLayer
{
    public class BusinessAccess
    {
        
        public static int IsAuthenticateUser(string userName,string password)
        {
            return  DataAccess.IsAuthenticate(userName, password);

            
        }

        public static void InsertAccountData(string userName,string password,string gender,int age,string userType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@userType", userType);

            DataAccess.InsertAccountData(cmd);
        }
        public static void InsertProductData(string productID,string productName,string price,string productType,string companyName)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@companyName", companyName);

            DataAccess.InsertProductDate(cmd);
        }
        public static DataSet GetAvailableProduct()
        {
            return DataAccess.GetAvailableProduct();
        }
        public static DataSet GetAvailableCustomer()
        {
            
            return DataAccess.GetAvailableCustomer();
        }

        public static DataSet SearchItem(string itemName)
        {
            return DataAccess.SerachItem(itemName);
        }
    }
}
