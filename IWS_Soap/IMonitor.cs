using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IWS_Soap
{
    [ServiceContract]
    interface IMonitor
    {
        [OperationContract]
        int GetRequestNumber();

        [OperationContract]
        int GetCacheRequestNumber();

        [OperationContract]
        string[] GetCacheContent();
    }
}
