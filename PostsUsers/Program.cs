using System;
using Microsoft.Extensions.DependencyInjection;
using PostsUsers.Repository;

namespace PostsUsers
{
    class Program
    {
        static IUserBusiness _userBusiness;
        static void Main(string[] args)
        {
            ConfigureStartup();

            if (args.Length > 0)
            {
                var posts = _userBusiness.GetPosts(args[0]).Result;
                Presentation.ShowPosts(posts, args[0]);
            }
            else
            {
                Console.WriteLine("No username provided!");
            }
            
        }

        private static void ConfigureStartup()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IUserBusiness, UserBusiness>()
                .AddSingleton<IRepository, JPHRepository>()
                .BuildServiceProvider();

            _userBusiness = serviceProvider.GetService<IUserBusiness>();
        }
    }
}
