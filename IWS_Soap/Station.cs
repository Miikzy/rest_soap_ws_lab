using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IWS_Soap
{
    [DataContract]
    public class Station
    {
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string contact_name { get; set; }
        [DataMember]
        public int bike_stands { get; set; }
        [DataMember]
        public int available_bike_stands { get; set; }
        [DataMember]
        public int available_bikes { get; set; }
    }
}
