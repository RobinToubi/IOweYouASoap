using System.Collections.Generic;

namespace ManageUser.Services
{
    public class User
    {
        public int id;
        public string login;
        public string password;
        public static List<User> listUser = new List<User>();
        public static int lastId = 0;

        public User(string log, string password)
        {
            this.id = ++lastId;
            this.login = log;
            this.password = password;
            listUser.Add(this);
        }
    }
}