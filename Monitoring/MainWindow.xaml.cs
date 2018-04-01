using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Monitoring
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MonitorRef.MonitorClient monitorClient;
        bool isPlaying = false;

        public MainWindow()
        {
            InitializeComponent();
            monitorClient = new MonitorRef.MonitorClient();
            RefreshAll();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshAll();
            RickRoll();
        }

        private void RefreshAll()
        {
            nb_request.Content = monitorClient.GetRequestNumber().ToString();
            nb_cache_request.Content = monitorClient.GetCacheRequestNumber().ToString();
            cache_content.Items.Clear();
            foreach (var i in monitorClient.GetCacheContent())
            {
                cache_content.Items.Add(i);
            }           
        }

        private void RickRoll()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"assets/monitoring_theme.wav");
            if (!isPlaying)
            {    
                player.Play();
                isPlaying = true;
            }
        }
    }
}
