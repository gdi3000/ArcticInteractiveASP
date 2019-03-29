using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArcticInteractiveASP
{
   
    public class Blog : System.Web.UI.Page
    {
        public bool specificBlogRequested = false;
        private List<BlogPost> blogPosts;
        public BlogPost RequestedBlogPost;
        protected void Page_Load(object sender, EventArgs e)
        {
            blogPosts = LoadFromDB();
        }

        private List<BlogPost> LoadFromDB()
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


        public List<BlogPost> BlogPosts
        {
            get => blogPosts;
        }

        public BlogPost ShowSPecificBlogPost(int id)
        {
            specificBlogRequested = true;
            RequestedBlogPost = blogPosts[id - 1];

            return RequestedBlogPost;
        }


    }
}
