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
    /// Логика взаимодействия для CompleteSponsor.xaml
    /// </summary>
    public partial class CompleteSponsor : Window
    {
        public CompleteSponsor()
        {
            InitializeComponent();
        }
        private void CloseApplication(object sender, MouseButtonEventArgs e) => Environment.Exit(0);
    }
}
