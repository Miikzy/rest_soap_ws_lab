using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Runtime.Caching;
using System.ServiceModel;

namespace IWS_Soap
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        public static ObjectCache cache = MemoryCache.Default;
        public static int cache_timer = 10;
        public static int numb_request = 0;
        public static int numb_cache_request = 0;
        private static Station[] stations;

        public Contract[] GetCities()
        {
            WebRequest request = WebRequest.Create(
                "https://api.jcdecaux.com/vls/v1/contracts?apiKey=133d203b9097bbbd95dd05214669a8219913166f");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            numb_request++;

            Contract[] contracts = JsonConvert.DeserializeObject<Contract[]>(responseFromServer);

            return contracts;
        }

        public Station[] GetStationsByCity(string city)
        {
            RefreshCache(city);
            return stations;
        }

        public Station GetInfoByStation(string name, string city)
        {
            RefreshCache(city);
            Station station = new Station();
            station.name = "null";

            foreach (Station s in stations)
            {
                if (s.name.Contains(name))
                {
                    station = s;
                }
            }

            return station;
        }

        public void RefreshCache(string city)
        {
            if (!cache.Contains(city))
            {
                WebRequest request = WebRequest.Create(
                    "https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=133d203b9097bbbd95dd05214669a8219913166f");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                stations = JsonConvert.DeserializeObject<Station[]>(responseFromServer);

                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(cache_timer);
                CacheItem item = new CacheItem(city, stations);
                cache.Add(item, policy);

                numb_request++;
            }
            else
            {
                stations = (Station[])cache.Get(city);
                numb_cache_request++;
            }
        }

    }
}
