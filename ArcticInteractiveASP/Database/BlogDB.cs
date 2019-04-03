using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArcticInteractiveASP.Database
{
    public class BlogDB
    {
        public List<BlogPost> LoadFromDB()
        {


            List<BlogPost> list = new List<BlogPost>();


            string query = "SELECT * FROM Blog";
            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Server=sql7.freemysqlhosting.net;Database=sql7285794;Uid=sql7285794;Pwd=mjbGqW4ly4;";

                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BlogPost blogpost = new BlogPost();
                        blogpost.IdBlog = (int)reader["IdBlog"];
                        blogpost.Date = reader["Date"].ToString();
                        blogpost.Text = reader["Text"].ToString();
                        blogpost.Title = reader["Title"].ToString();
                        list.Add(blogpost);
                    }
                }
            }

            return list;

        }
    }
}