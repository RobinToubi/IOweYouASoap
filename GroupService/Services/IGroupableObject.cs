using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace GroupService.Services
{
    [ServiceContract]
    public interface IGroupableObject
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
        public List<int> Members { get; set; }

        [OperationContract]
        public Group GetGroup(int id);
    }
}
