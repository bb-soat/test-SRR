using PostsUsers.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostsUsers
{
    public interface IUserBusiness
    {
        public Task<IEnumerable<Post>> GetPosts(string username);
    }
}