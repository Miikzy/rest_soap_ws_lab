using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IWS_Soap
{
    [DataContract]
    public class Contract
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string country_code { get; set; }
    }
}
