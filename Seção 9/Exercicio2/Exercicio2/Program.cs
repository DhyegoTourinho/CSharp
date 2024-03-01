using Exercicio2.Entities;
using System;

namespace Exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            Comment comment = new Comment();
            post.AddComment("Have a nice trip");
            post.AddComment("Wow that's awesome!");
            Console.WriteLine(post);
            Console.WriteLine("Comments:");
            post.PrintComments();
            
            Console.WriteLine();

            Post post1 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"), 
                "Good night guys", 
                "See you tomorrow", 
                5);

            post1.AddComment("Good night");
            post1.AddComment("May the Force be with you");
            Console.WriteLine(post1);
            Console.WriteLine("Comments:");
            post1.PrintComments();
        }
    }
}
