using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;


namespace ArcticInteractiveASP.Database
{
    public class BlogLoginDB
    {
        private static Account _LoggedInUser;


        public static bool CheckLoginASP(string account, string password, string HashedPwd)
        {
            return (CheckLoginASPMethod(account, password, HashedPwd));
        }

        private static bool CheckLoginASPMethod(string account, string password, string HashedPwd)
        {
            
            Account DbUser = new Account();
            string query = "SELECT * FROM Users WHERE Name =?account";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["FridaiBlog"].ConnectionString;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("account", account));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DbUser.Username = reader["Name"].ToString();
                        DbUser.PwdHash = reader["PwdHash"].ToString();
                        ;
                    }
                }
            }

            if (DbUser.PwdHash == HashedPwd)
            {
                return true;
                
            }

            return false;


        }

        //protected void Clicked(object sender, EventArgs e)
        //{
        //    CheckLogin();
        //}

        //private string Sha1Hash(string pwd)
        //{
        //    using (SHA1Managed sha1 = new SHA1Managed())
        //    {
        //        var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pwd));
        //        var sb = new StringBuilder(hash.Length * 2);

        //        foreach (byte b in hash)
        //        {
        //            // can be "x2" if you want lowercase
        //            sb.Append(b.ToString("X2"));
        //        }

        //        return sb.ToString();
        //    }
        //}
    }
}