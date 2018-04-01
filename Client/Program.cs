using IWS_Soap;
using System;
using System.Net;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 interService = new Service1();
            DisplayWelcomingMessage();
            while (true)
            {
                Console.Write("\nSaisissez votre commande ('");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("help");
                Console.ResetColor();
                Console.Write("' permet de connaître les options disponibles) - ");
                var input = Console.ReadLine();
                if (input.Equals("help"))
                {
                    Console.Write("\t - Pour quitter l'application entrez: '");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("exit");
                    Console.ResetColor();
                    Console.Write("' \n\t - Pour consulter les informations relatives à une station entrez: '");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("consult");
                    Console.ResetColor();
                    Console.Write("' \n\n");
                    continue;
                }
                else if (input.Equals("exit"))
                {
                    break;
                }
                else if (input.Equals("consult"))
                {
                    bool city_correct = false;
                    string city = "";
                    while (city_correct == false)
                    {
                        city = AskCity();
                        try
                        {
                            interService.GetStationsByCity(city);
                            city_correct = true;
                        }
                        catch (WebException e)
                        {
                            Console.WriteLine(city + " n'est pas désservie par nos services.\n");
                            city_correct = false;
                        }
                    }
                    string station_name = AskStation();
                    Station station_info = interService.GetInfoByStation(station_name, city);
                    DisplayStationInfo(station_info, station_name);
                    Console.Write("Voulez-vous consulter une autre station? O/N - ");
                    if (!Console.ReadLine().ToUpper().Equals("O"))
                    {
                        break;
                    }
                    Console.WriteLine();
                }
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

        public static void DisplayStationInfo(Station station_info, string station_name)
        {
            if (station_info.name != "null")
            {
                Console.Write("\nLa station ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(station_info.name);
                Console.ResetColor();
                Console.Write(" situé au ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(station_info.address);
                Console.ResetColor();
                Console.Write("Stand à vélo disponible : ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(station_info.available_bike_stands);
                Console.ResetColor();
                Console.Write("Vélo disponible : ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(station_info.available_bikes + "\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("La station " + station_name + " est introuvable...");
            }
        }

        public static void DisplayWelcomingMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("PolyBike");
            Console.ResetColor();
            Console.WriteLine(" - Consultez les informations sur les stations velib' du monde entier !");
        }
    }
}

