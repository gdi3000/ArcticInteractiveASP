using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArcticInteractiveASP.Database
{
    public class BlogSpecificDB
    {

        public BlogPost LoadSingleBlog(string id)
        {
            BlogPost blogpost = new BlogPost();
            string query = "SELECT * FROM Blog WHERE IdBlog =?id";
            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Server=sql7.freemysqlhosting.net;Database=sql7285794;Uid=sql7285794;Pwd=mjbGqW4ly4;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("id", id));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        blogpost.IdBlog = (int)reader["IdBlog"];
                        blogpost.Date = reader["Date"].ToString();
                        blogpost.Text = reader["Text"].ToString();
                        blogpost.Title = reader["Title"].ToString();

                    }
                }
            }
            return blogpost;
        }

    }
}