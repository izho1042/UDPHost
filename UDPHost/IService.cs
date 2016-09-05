using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UDPHost
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        String SayFaq(String input);
    }
}
