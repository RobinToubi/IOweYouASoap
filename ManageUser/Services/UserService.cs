using System;
using System.Collections.Generic;

namespace ManageUser.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public User CreateUser(string login, string password)
        {
            new User(login, password);
            return User.listUser[User.lastId];
        }

        public void DeleteUser(int id)
        {
            foreach (User user in User.listUser)
            {
                if (user.id == id)
                {
                    User.listUser.Remove(user);
                }
            }
        }

        public IList<User> GetAllUsers()
        {
            return User.listUser;
        }

        public User GetUserById(int id)
        {
            User userGet = null;
            foreach (User user in User.listUser)
            {
                if (user.id == id)
                {
                    userGet = user;
                }
            }
            return userGet;
        }

        public User UpdateUser(int id, string log, string pwd)
        {
            User userToUpdate = null;
            foreach (User user in User.listUser)
            {
                if (user.id == id)
                {
                    userToUpdate = user;
                }
            }
            if (userToUpdate != null)
            {
                userToUpdate.login = log;
                userToUpdate.password = pwd;
            }
            return userToUpdate;
        }
    }
}
