using ArcticInteractiveASP.Database;
using MySql.Data.MySqlClient;
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

           return BlogSpecificDB.LoadSingleBlog(id);

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