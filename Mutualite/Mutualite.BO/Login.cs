using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    [Serializable]
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login()
        {

        }

        public Login(string username, string password)
            
        {
            Username = username;
            Password = password;
        }

        public override bool Equals(object obj)
        {
            return obj is Login login &&
                   Username == login.Username;
        }

        public override int GetHashCode()
        {
            return -182246463 + EqualityComparer<string>.Default.GetHashCode(Username);
        }
    }
}
