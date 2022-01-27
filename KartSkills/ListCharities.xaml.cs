using System;
using System.Windows;
using System.Windows.Input;

namespace KartSkills
{
    /// <summary>
    /// Логика взаимодействия для ListCharities.xaml
    /// </summary>
    public partial class ListCharities : Window
    {
        public ListCharities()
        {
            InitializeComponent();
        }

        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);

        private void BackClick(object sender, RoutedEventArgs e)
        {
            FullInfo fullInfo = new FullInfo();
            fullInfo.Show();
            this.Close();
        }

        

        public void InputCards()
        {
            for (int i = 0; i < 5; i++)
                ListCards.Items.Add(new CharityCard());
        }

        private void PageLoad(object sender, RoutedEventArgs e)
        {
            InputCards();
        }
    }
}
