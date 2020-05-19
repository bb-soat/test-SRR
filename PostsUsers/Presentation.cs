using PostsUsers.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostsUsers
{
    public class Presentation
    {
        public static void ShowPosts(IEnumerable<Post> posts, string userName)
        {
            Console.WriteLine("| Id Post | Post Title                   | UserName |");
            foreach (var post in posts)
            {
                Console.WriteLine($"| {Format(post.Id.ToString(), 8)}| {Format(post.Title, 29)}| {Format(userName, 9)}|");
            }
        }

        private static string Format(string input, int length)
        {
            if (length > input.Length)
            {
                var spaces = new String(' ', length - input.Length);
                return $"{input}{spaces}";
            } else
            {
                return input.Substring(0, length);
            }
        }
    }
}
