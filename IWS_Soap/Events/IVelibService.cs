using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IWS_Soap.Events
{
    // Methodes exposées, subscribe
    // implémente des actions données au client
    [ServiceContract(CallbackContract = typeof(IVelibEvents))]
    interface IVelibService
    {
        [OperationContract]
        void Subscribe(string city, string station);

        [OperationContract]
        void CheckIfChange(string city, string station);

    }
}
