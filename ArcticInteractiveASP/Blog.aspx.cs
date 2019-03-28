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


            string query = "SELECT * FROM Posts";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["FridaiBlog"].ConnectionString;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BlogPost blogpost = new BlogPost();
                        blogpost.Author = reader["Author"].ToString();
                        blogpost.IdPosts = (int)reader["IdPosts"];
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
