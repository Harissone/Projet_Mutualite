using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BLL
{
    public class UserBLO
    {
        UserDAO userRepo;
        public UserBLO(string dbFolder)
        {
            userRepo = new UserDAO(dbFolder);
        }
        public void CreateUser(User user)
        {
            userRepo.Add(user);
        }
        public void DeleteUser(User user)
        {
            userRepo.Remove(user);
        }
        public IEnumerable<User> GetAllUser()
        {
            return userRepo.Find();
        }
        public IEnumerable<User> GetByUsername(string username)
        {
            return userRepo.Find(x => x.Username == username);
        }
        public IEnumerable<User> GetBy(Func<User, bool> predicate)
        {
            return userRepo.Find(predicate);
        }
        public void EditUser(User oldUser, User newUser)
        {
            userRepo.Set(oldUser, newUser);
        }
    }
}
