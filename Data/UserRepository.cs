using System.Collections.Generic;
using TigerTix.Web.Data.Entities;
using System.Linq;

namespace TigerTix.Web.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly TigerTixContext _context;

        public UserRepository(TigerTixContext context)
        {
            _context = context;
        }

        //Save a user
        public void SaveUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        //Returns all users
        public IEnumerable<User> GetAllUsers()
        {
            var users = from u in _context.Users
                        select u;
            return users.ToList();
        }

        //Return a single user by ID
        public User GetUsersByID(int userID)
        {
            var user = (from u in _context.Users
                        where u.ID == userID
                        select u).FirstOrDefault();
            return user;
        }

        //Update a User
        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        //Delete a User
        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }

        //Save All
        public bool SaveAll()
        {
            //Save changes returns the number of rows affected
            return _context.SaveChanges() > 0;
        }

    }
}
