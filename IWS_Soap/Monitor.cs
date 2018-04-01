using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWS_Soap
{
    class Monitor : IMonitor
    {
        public string[] GetCacheContent()
        {
            string[] cache_content = new String[Service1.cache.GetCount()];
            int i = 0;
            foreach (KeyValuePair<string, object> item in Service1.cache.AsEnumerable())
            {
                cache_content[i++] = item.Key;
            }

            return cache_content;
        }

        public int GetCacheRequestNumber()
        {
            return Service1.numb_cache_request;
        }

        public int GetRequestNumber()
        {
            return Service1.numb_request;
        }
    }
}
