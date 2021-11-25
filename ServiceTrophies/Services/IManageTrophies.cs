using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceTrophies.Services
{
    [ServiceContract]
    interface IManageTrophies
    {
        [OperationContract]
        IList<string> GetAllTrophiesNamesAsc(List<Trophy> trophies);
    }
}
