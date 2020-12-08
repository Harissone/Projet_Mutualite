using Mutualite.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutualite.DAL
{
    public class UserDAO
    {
        public static List<User> users;
        private const string FILE_NAME = @"user.json";
        private readonly string dbFolder;
        private FileInfo file;
        public UserDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    users = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }
            if (users == null)
            {
                users = new List<User>();
            }
        }
        public void Set(User oldUser, User newUser)
        {
            var oldIndex = users.IndexOf(oldUser);
            var newIndex = users.IndexOf(newUser);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The user doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This user name already exists !");
            users[oldIndex] = newUser;
            Save();
        }
        public void Add(User user)
        {
            var index = users.IndexOf(user);
            if (index >= 0)
                throw new DuplicateNameException("This user name already exists !");
            users.Add(user);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(users);
                sw.WriteLine(json);
            }
        }
        public void Remove(User user)
        {
            users.Remove(user);//base sur User.Equals redefini
            Save();
        }
        public IEnumerable<User> Find()
        {
            return new List<User>(users);
        }
        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return new List<User>(users.Where(predicate).ToArray());
        }
    }
}
