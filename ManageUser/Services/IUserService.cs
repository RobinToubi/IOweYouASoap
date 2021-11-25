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
        [OperationContract]
        User GetUserById(int id);
        [OperationContract]
        User UpdateUser(int id, string log, string pwd);
        [OperationContract]
        User CreateUser(string login, string password);
        [OperationContract]
        void DeleteUser(int id);
    }
}
