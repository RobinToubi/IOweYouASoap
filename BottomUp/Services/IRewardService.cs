using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BottomUp.Services
{
    [ServiceContract]
    public interface IRewardService
    {
        [OperationContract]
        Reward GetReward(string id, int value, string comparator);
    }
}
    