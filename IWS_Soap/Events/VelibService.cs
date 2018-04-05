using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel;

namespace IWS_Soap.Events
{
    class VelibService : IVelibService
    {
        static Action<string, string, string> m_event = delegate { };
        private static int number_bike_available;
        private static int number_stand_available;
   

        public void Subscribe()
        {
            IVelibEvents subscriber = OperationContext.Current.GetCallbackChannel<IVelibEvents>();
            m_event += subscriber.StationChanged;
        }

        public void CheckIfChange(string city, string station_name)
        {
            WebRequest request = WebRequest.Create(
                     "https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=133d203b9097bbbd95dd05214669a8219913166f");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

            Station[] stations = JsonConvert.DeserializeObject<Station[]>(responseFromServer);
            Station station = new Station();
            string state = "";

            foreach (Station s in stations)
            {
                if (s.name.Contains(station_name))
                {
                    station = s;
                }
            }

            if(station.available_bikes != number_bike_available 
                || station.available_bike_stands != number_stand_available)
            {
                number_bike_available = station.available_bikes;
                number_stand_available = station.available_bike_stands;
                state = "updated";
            } else
            {
                state = "unupdated";
            }
            string info = "City : " + city + "\n" + "Station : " + station.name + "\n";
            string data = "Number of bike available : " + number_bike_available.ToString()
                + "\nNumber of stands available : " + number_stand_available.ToString() + "\n";

            m_event(info, data, state);
        }

    }
}
