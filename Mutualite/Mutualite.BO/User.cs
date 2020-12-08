using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    public class User: Login
    {
        public string ConfirmPassword { get; set; }
        public User(string username, string password, string confirmPassword)
            :base(username, password)
        {
            ConfirmPassword = confirmPassword;
        }
        public override bool Equals(object obj)
        {
            return obj is User product &&
                   Username.Equals(product.Username, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Username);
        }




    }
}
