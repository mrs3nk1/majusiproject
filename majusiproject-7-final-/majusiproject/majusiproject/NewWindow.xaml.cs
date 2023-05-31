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
using System.Windows.Shapes;

namespace majusiproject
{
    public partial class NewWindow : Window
    {
        KisteremJegyfoglalasWindow kisteremWindow = new KisteremJegyfoglalasWindow();
        public NewWindow()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void KisteremJegyfoglalas_Click(object sender, RoutedEventArgs e)
        {
            // Új ablak megjelenítése a kisterem jegyfoglaláshoz
            
            kisteremWindow.Show();
        }

        private void FoteremJegyfoglalas_Click(object sender, RoutedEventArgs e)
        {
            // Üzenet megjelenítése a főterem jegyfoglalás alatt
            MessageBox.Show("A főterem felújítás alatt!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kisteremWindow.Show();
        }

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            kisteremWindow.Show();
        }

        private void Label_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            kisteremWindow.Show();
        }

        private void Label_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            kisteremWindow.Show();
        }

        private void Label_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            kisteremWindow.Show();
        }
    }
    
}
