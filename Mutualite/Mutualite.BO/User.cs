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

       

       
    }
}
