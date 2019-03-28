using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using ArcticInteractiveASP;
using ArcticInteractiveASP.Database;


namespace ArcticInteractiveASP
{
    public class BlogLogin : System.Web.UI.Page
    {
        private static Account _LoggedInUser;

        public void CheckLogin()
        {

            BlogLoginDB BLDB = new BlogLoginDB();


            string user = Request["user"];
            string password = Request["pass"];
            string HashedPwd = Sha1Hash(password);
            Account DbUser = new Account();

            if(BLDB.CheckLoginASP(user, password, HashedPwd).Equals(true))
            {
                _LoggedInUser = DbUser;
                Response.Redirect("CreateBlogPost.aspx"); 
            }

                                 
            if (BLDB.CheckLoginASP(user, password, HashedPwd).Equals(false))
            {
                
                Response.Redirect("Error.aspx");
            }


        }

        protected void Clicked(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private string Sha1Hash(string pwd)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }


    }
}