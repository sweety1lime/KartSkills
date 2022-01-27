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
    /// Логика взаимодействия для Sponsorship.xaml
    /// </summary>
    public partial class Sponsorship : Window
    {
        public Sponsorship()
        {
            InitializeComponent();
        }

        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);

        private void BackClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void PayClick(object sender, RoutedEventArgs e)
        {
            CompleteSponsor completeSponsor = new CompleteSponsor();
            completeSponsor.Show();
            this.Close();
        }
    }
}
