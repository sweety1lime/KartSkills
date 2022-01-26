using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KartSkills
{
    /// <summary>
    /// Логика взаимодействия для RacerCheck.xaml
    /// </summary>
    public partial class RacerCheck : Window
    {
        public RacerCheck()
        {
            InitializeComponent();
        }

        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);

        private void YesClick(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
