using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.BO
{
    public class Membre : User
    {   
        public string Email { get; set; }
        public int Telephone { get; set; }
        public Membre(string username, string password, string confirmPassword,  string email, int telephone)
           : base(username, password, confirmPassword)
        {
            Username = username;
            Password = password;
            Email = email;
            Telephone = telephone;
        }
    
        public override bool Equals(object obj)
        {
            return obj is Membre membre &&
                   Username.Equals(membre.Username, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Username);
        }
    }
}
