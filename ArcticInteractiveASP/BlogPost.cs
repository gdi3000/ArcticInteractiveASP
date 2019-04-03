namespace ArcticInteractiveASP
{

    public class BlogPost : System.Web.UI.Page
    {
        public BlogPost()
        {

        }

        public BlogPost(int idBlog, string date, string text, string title)
        {
            IdBlog = idBlog;
            Date = date;
            Text = text;
            Title = title;
        }

        public int IdBlog { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
      
        public string Date { get; set; }
    }
}