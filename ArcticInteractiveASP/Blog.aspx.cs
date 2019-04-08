using ArcticInteractiveASP.Database;
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
            blogPosts = CallBlogFromDB();
        }

        private List<BlogPost> CallBlogFromDB()
        {

            BlogDB blogDB = new BlogDB();

            return blogDB.LoadFromDB();

  

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
