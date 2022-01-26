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
    /// Логика взаимодействия для FullInfo.xaml
    /// </summary>
    public partial class FullInfo : Window
    {
        public FullInfo()
        {
            InitializeComponent();
        }
        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);
    }
}
