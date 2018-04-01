using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IWS_Soap
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Contract[] GetCities();

        [OperationContract]
        Station[] GetStationsByCity(string city);

        [OperationContract]
        Station GetInfoByStation(string name, string city);

        [OperationContract]
        void RefreshCache(string city);


    }

}
