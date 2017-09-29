using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogService blogService = new BlogService();
            var post = blogService.GetPost(1).Result;
            Console.WriteLine("Title of first post:");
            Console.WriteLine(post.Title);
            Console.WriteLine("\n");

            var postsCount = blogService.GetNumberOfPosts().Result;
            Console.WriteLine("Number od posts:");
            Console.WriteLine(postsCount);
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
