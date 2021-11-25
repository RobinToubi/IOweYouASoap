using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManageUser.Services
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int id;
        [DataMember]
        public string login;
        [DataMember]
        public string password;
        public static List<User> listUser = new List<User>();
        public static int lastId = 0;

        public User(string log, string password)
        {
            lastId++;
            this.id = lastId;
            this.login = log;
            this.password = password;
            listUser.Add(this);
        }
    }
}