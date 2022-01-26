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

namespace KartSkills
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);

        private void CheckRacer(object sender, RoutedEventArgs e)
        {
            RacerCheck racerCheck = new RacerCheck();
            racerCheck.Show();
            this.Close();
        }

        private void Auth(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            FullInfo fullInfo = new FullInfo();
            fullInfo.Show();
            this.Close();
        }

        private void Sponsor(object sender, RoutedEventArgs e)
        {
            Sponsorship sponsorship = new Sponsorship();
            sponsorship.Show();
            this.Close();
        }
    }
}
