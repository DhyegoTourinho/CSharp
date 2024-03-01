using System.Globalization;

namespace Exercicio2.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes {  get; set; }
        public Post() 
        { 
        }

        public Post (DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public List<Comment> PostComments { get; set; } = new List<Comment>();

        public void AddComment(string text)
        {
            PostComments.Add(new Comment(text));
        }

        public void PrintComments() {
            foreach (Comment comment in PostComments)
            {
                Console.WriteLine(comment.Text);
            }
        }

        public override string ToString()
        {
            return Title
                + "\n"
                + Likes
                + " Likes - "
                + Moment
                + "\n"
                + Content 
                + "\n";
        }
    }
}
