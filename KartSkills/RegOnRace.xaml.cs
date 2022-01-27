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
    /// Логика взаимодействия для RegOnRace.xaml
    /// </summary>
    public partial class RegOnRace : Window
    {
        public RegOnRace()
        {
            InitializeComponent();
        }
        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);

        private void BackClick(object sender, RoutedEventArgs e)
        {
            RacerMenu racerMenu = new RacerMenu();
            racerMenu.Show();
            this.Close();
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ConfirmClick(object sender, RoutedEventArgs e)
        {
            ConfirmRegRace confirmRegRace = new ConfirmRegRace();
            confirmRegRace.Show();
            this.Close();
        }
    }
}
