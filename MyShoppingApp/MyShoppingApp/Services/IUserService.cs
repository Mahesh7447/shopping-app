using MyShoppingApp.Models;

namespace MyShoppingApp.Services
{
    public interface IUserService
    {
        User SaveUser(User user);
        User GetUser(int id);
        Role AddRole(Role role);
        bool AssignRoleToUser(UserRole userRole);
    }
}
