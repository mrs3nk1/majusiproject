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
            KisteremJegyfoglalasWindow kisteremWindow = new KisteremJegyfoglalasWindow();
            kisteremWindow.Show();
        }

        private void FoteremJegyfoglalas_Click(object sender, RoutedEventArgs e)
        {
            // Üzenet megjelenítése a főterem jegyfoglalás alatt
            MessageBox.Show("A főterem felújítás alatt", "Jegyfoglalás", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
    
}
