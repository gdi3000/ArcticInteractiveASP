using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;
using System.Web.UI;



namespace ArcticInteractiveASP
{
    public class BlogSpecific : System.Web.UI.Page
    {
        private BlogPost _blogpost;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            string BlogId = Request.QueryString["/BlogID"];
           _blogpost = LoadSingleBlog(BlogId);
        }

        private BlogPost LoadSingleBlog(string id)
        {
            BlogPost blogpost = new BlogPost();
            string query = "SELECT * FROM Posts WHERE IdPosts =?id";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["FridaiBlog"].ConnectionString;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("id", id));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        
                        blogpost.IdBlog = (int)reader["IdPosts"];
                        blogpost.Date = reader["Date"].ToString();
                        blogpost.Text = reader["Text"].ToString();
                        blogpost.Title = reader["Title"].ToString();
                        
                    }
                }
            }
            return blogpost;
        }

        public List<BlogPost> BlogPostlist
        {

            get
            {
                List<BlogPost> post = new List<BlogPost>();
                post.Add(_blogpost);
                return post;
            } 
        }

        public BlogPost BlogPost { get => _blogpost;  }
    }
}