using Client_GUI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client_GUI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReference1.Service1Client service;
        public static Contract[] cities;
        string city;

        public MainWindow()
        {
            InitializeComponent();
            service = new ServiceReference1.Service1Client();
            cities = service.GetCities();
            DisplayCities(cities);
        }

        public void DisplayCities(Contract[] cities)
        {
            for (int i = 0; i < cities.Length; i++)
            {
                city_list.Items.Add(cities[i].name + ", " + cities[i].country_code);
            }
        }

        private void station_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0)
            {
                return;
            }
            Station station = service.GetInfoByStation(e.AddedItems[0].ToString(), city);

            if (station == null)
            {
                station_address.Content = "introuvable";
            }
            else
            {
                station_address.Content = station.address;
                station_bike.Content = station.available_bikes;
                station_stand.Content = station.available_bike_stands;
            }
        }

        private void city_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count >= 65536)
            {
                return;
            }
            station_list.Items.Clear();
            city = e.AddedItems[0].ToString().Split(',')[0];
           

            foreach(Station s in service.GetStationsByCity(e.AddedItems[0].ToString().Split(',')[0]))
            {
                station_list.Items.Add(s.name);
            }
        }
    }
}
