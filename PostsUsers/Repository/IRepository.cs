using PostsUsers.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostsUsers.Repository
{
    public interface IRepository
    {
        Task<List<User>> GetAllUsers();
        Task<List<Post>> GetPosts(int userId);
    }
}