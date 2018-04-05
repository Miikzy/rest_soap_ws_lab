using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClientEvent.ServiceEventRef;

namespace ClientEvent
{
    class Program
    {
        static void Main(string[] args)
        {
 
            CallBackSink objsink = new CallBackSink();
            InstanceContext instanceContext = new InstanceContext(objsink);
            VelibServiceClient serviceEventClient = new VelibServiceClient(instanceContext);
            serviceEventClient.Subscribe();

            string city_name = AskCity();
            string station_name = AskStation();
            Console.WriteLine();

            while (true)
            {
                serviceEventClient.CheckIfChange(city_name, station_name);
                System.Threading.Thread.Sleep(3000);
            }

        }

        public static string AskCity()
        {
            Console.Write("Quelle ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ville");
            Console.ResetColor();
            Console.Write(" souhaitez-vous consulter? ");
            return Console.ReadLine();
        }

        public static string AskStation()
        {
            Console.Write("Quelle ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("station");
            Console.ResetColor();
            Console.Write(" souhaitez-vous consulter? ");
            return Console.ReadLine().ToUpper();
        }

    }
    
}
