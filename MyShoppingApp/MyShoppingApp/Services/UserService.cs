using MyShoppingApp.Models;
using MyShoppingApp.Repositories;

namespace MyShoppingApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Role AddRole(Role role)
        {
            return userRepository.AddRole(role);
        }

        public bool AssignRoleToUser(UserRole userRole)
        {
           return userRepository.AssignRoleToUser(userRole);
        }

        public User GetUser(int id)
        {
            return userRepository.GetUser(id);
        }

        public User SaveUser(User user)
        {
            return userRepository.SaveUser(user);
        }
    }
}
