using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IWS_Soap.Events
{
    // Changement sur les velo, one way
    [ServiceContract]
    interface IVelibEvents
    {
        [OperationContract(IsOneWay = true)]
        void StationChanged(string info, String data, String state);

    }
}
