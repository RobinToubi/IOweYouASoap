using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BottomUp.Services
{
    [ServiceContract]
    public interface IRandomizerService
    {
        [OperationContract]
        IList<string> GetRandomElement(IList<string> list, int number = 1);
    }
}
