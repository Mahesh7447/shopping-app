using MyShoppingApp.Models;

namespace MyShoppingApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Role AddRole(Role role)
        {
            if (role != null)
            {
                dbContext.Roles.Add(role);
                dbContext.SaveChanges();
                return role;
            }
            return null;
        }

        public bool AssignRoleToUser(UserRole userRole)
        {
            bool IsAssigned = false;
            if (userRole != null)
            {
                dbContext.UserRoles.Add(userRole);
                dbContext.SaveChanges();
                IsAssigned=true;
            }
            return IsAssigned;
            
        }

        public User GetUser(int id)
        {
            return dbContext.Users.FirstOrDefault(user => user.UserId == id);
        }

        public User SaveUser(User user)
        {
            if (user != null)
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return user;
            }
            return null;
        }
    }
}
