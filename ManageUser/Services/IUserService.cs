using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ManageUser.Services
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        IList<User> GetAllUsers();
        User GetUserById(int id);
        User UpdateUser(int id, string log, string pwd);
        User CreateUser(string login, string password);
        void DeleteUser(int id);
    }
}
