namespace ArcticInteractiveASP
{

    public class BlogPost
    {
        public BlogPost()
        {

        }

        public BlogPost(int idPosts, string date, string text, string author, string title)
        {
            IdPosts = idPosts;
            Date = date;
            Text = text;
            Author = author;
            Title = title;
        }

        public int IdPosts { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
    }
}