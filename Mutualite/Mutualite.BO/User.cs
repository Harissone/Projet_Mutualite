using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    [Serializable]
    public class User: Login
    {
        public string ConfirmPassword { get; set; }

        public User()
        {

        }

        public User(string username, string password, string confirmPassword)
            :base(username, password)
        {
            ConfirmPassword = confirmPassword;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   base.Equals(obj) &&
                   ConfirmPassword == user.ConfirmPassword;
        }

        public override int GetHashCode()
        {
            int hashCode = 99842204;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ConfirmPassword);
            return hashCode;
        }
    }
}
