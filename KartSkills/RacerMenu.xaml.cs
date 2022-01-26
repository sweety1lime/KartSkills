﻿using System;
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
    /// Логика взаимодействия для RacerMenu.xaml
    /// </summary>
    public partial class RacerMenu : Window
    {
        public RacerMenu()
        {
            InitializeComponent();
        }

        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);

        private void Logout(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ShowContact(object sender, RoutedEventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.Show();
        }
    }
}
