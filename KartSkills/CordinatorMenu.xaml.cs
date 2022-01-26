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
    /// Логика взаимодействия для CordinatorMenu.xaml
    /// </summary>
    public partial class CordinatorMenu : Window
    {
        public CordinatorMenu()
        {
            InitializeComponent();
        }
        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);
    }
}
