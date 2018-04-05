using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEvent
{
    class CallBackSink : ServiceEventRef.IVelibServiceCallback
    {
        public void StationChanged(string info, string data, string state)
        {
            if (state.Equals("updated"))
            {
                Console.WriteLine(info + data);
            } else
            {
                Console.WriteLine("Aucun changement détecté");
            }
        }
    }
}
