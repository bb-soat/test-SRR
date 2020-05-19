using PostsUsers.Model;
using PostsUsers.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostsUsers
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IRepository _repository;

        public UserBusiness(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Post>> GetPosts(string username)
        {
            var users = await _repository.GetAllUsers();
            var user = users.FirstOrDefault(u => u.UserName == username);
            var posts = await _repository.GetPosts(user.Id);
            return posts;
        }
    }
}