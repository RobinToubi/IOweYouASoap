using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace IOweYouASoap.Models
{
    [ServiceContract]
    public interface IRandomizerService
    {
        [OperationContract]
        IList<string> getRandomElement(IList<string> elements, int number);

        IList<string> elements { get; set; }
        int number { get; set; }
    }
}
