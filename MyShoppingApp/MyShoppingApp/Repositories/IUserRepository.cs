using MyShoppingApp.Models;

namespace MyShoppingApp.Repositories
{
    public interface IUserRepository
    {
        User SaveUser(User user);
        User GetUser(int id);   
        Role AddRole(Role role);
        bool AssignRoleToUser(UserRole userRole);
    }
}
