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
    /// <summary>
    /// Interaction logic for KisteremJegyfoglalasWindow.xaml
    /// </summary>
    public partial class KisteremJegyfoglalasWindow : Window
    {
        List<string> lefoglalthelyek = new List<string>(); 
        string[,] balhelyek = new string[5,5]
        {
                { "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"}
        };
        string[,] jobbhelyek = new string[5, 5]
        {
                { "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"},{ "1", "2", "3", "4", "5"}
        };

        public KisteremJegyfoglalasWindow()
        {
            InitializeComponent();
        }

        private void lff_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[1,1]="lff";
            lefoglalthelyek.Add("lff");
            if (lff.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!","Hiba!");
            }
            else
            {
               lff.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
               lff.Foreground = Brushes.Black;
            }
        }

        private void lftw_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[1, 2] = int.Parse("x");
            if (lftw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lftw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lftw.Foreground = Brushes.Black;
            }

        }

        private void lfth_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[1, 3] = int.Parse("x");
            if (lfth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfth.Foreground = Brushes.Black;
            }

        }

        private void lffr_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[1, 4] = int.Parse("x");
            if (lffr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lffr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lffr.Foreground = Brushes.Black;
            }

        }

        private void lffv_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[1, 5] = int.Parse("x");
            if (lffv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lffv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lffv.Foreground = Brushes.Black;
            }
        }

        private void ltwf_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[2, 1] = int.Parse("x");
            if (ltwf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                ltwf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                ltwf.Foreground = Brushes.Black;
            }

        }

        private void ltwtw_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[2, 2] = int.Parse("x");
            if (ltwtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                ltwtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                ltwtw.Foreground = Brushes.Black;
            }

        }

        private void ltwth_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[2, 3] = int.Parse("x");
            if (ltwth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                ltwth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                ltwth.Foreground = Brushes.Black;
            }

        }

        private void ltwfr_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[2, 4] = int.Parse("x");
            if (ltwfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                ltwfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                ltwfr.Foreground = Brushes.Black;
            }

        }

        private void ltwfv_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[2, 5] = int.Parse("x");
            if (ltwfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                ltwfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                ltwfv.Foreground = Brushes.Black;
            }

        }

        private void lthf_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[3, 1] = int.Parse("x");
            if (lthf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lthf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lthf.Foreground = Brushes.Black;
            }

        }

        private void lthtw_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[3, 2] = int.Parse("x");
            if (lthtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lthtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lthtw.Foreground = Brushes.Black;
            }

        }

        private void lthth_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[3, 3] = int.Parse("x");
            if (lthth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lthth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lthth.Foreground = Brushes.Black;
            }

        }

        private void lthfr_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[3, 4] = int.Parse("x");
            if (lthfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lthfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lthfr.Foreground = Brushes.Black;
            }

        }

        private void lthfv_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[3, 5] = int.Parse("x");
            if (lthfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lthfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lthfv.Foreground = Brushes.Black;
            }

        }

        private void lfrf_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[4, 1] = int.Parse("x");
            if (lfrf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfrf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfrf.Foreground = Brushes.Black;
            }

        }

        private void lfrtw_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[4, 2] = int.Parse("x");
            if (lfrtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfrtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfrtw.Foreground = Brushes.Black;
            }

        }

        private void lfrth_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[4, 3] = int.Parse("x");
            if (lfrth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfrth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfrth.Foreground = Brushes.Black;
            }

        }

        private void lfrfr_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[4, 4] = int.Parse("x");
            if (lfrfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfrfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfrfr.Foreground = Brushes.Black;
            }

        }

        private void lfrfv_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[4, 5] = int.Parse("x");
            if (lfrfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfrfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfrfv.Foreground = Brushes.Black;
            }

        }

        private void lfvf_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[5, 1] = int.Parse("x");
            if (lfvf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfvf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfvf.Foreground = Brushes.Black;
            }

        }

        private void lfvtw_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[5, 2] = int.Parse("x");
            if (lfvtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfvtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfvtw.Foreground = Brushes.Black;
            }

        }

        private void lfvth_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[5, 3] = int.Parse("x");
            if (lfvth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfvth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfvth.Foreground = Brushes.Black;
            }

        }

        private void lfvfr_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[5, 4] = int.Parse("x");
            if (lfvfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfvfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfvfr.Foreground = Brushes.Black;
            }

        }

        private void lfvfv_Click(object sender, RoutedEventArgs e)
        {
            balhelyek[5, 5] = int.Parse("x");
            if (lfvfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                lfvfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                lfvfv.Foreground = Brushes.Black;
            }

        }

        private void rff_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[1, 5] = int.Parse("x");
            if (rff.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rff.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rff.Foreground = Brushes.Black;
            }

        }

        private void rftw_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[1, 4] = int.Parse("x");
            if (rftw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rftw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rftw.Foreground = Brushes.Black;
            }

        }

        private void rfth_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[1, 3] = int.Parse("x");
            if (rfth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfth.Foreground = Brushes.Black;
            }

        }

        private void rffr_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[1, 2] = int.Parse("x");
            if (rffr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rffr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rffr.Foreground = Brushes.Black;
            }

        }

        private void rffv_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[1, 1] = int.Parse("x");
            if (rffv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rffv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rffv.Foreground = Brushes.Black;
            }

        }

        private void rtwf_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[2, 5] = int.Parse("x");
            if (rtwf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rtwf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rtwf.Foreground = Brushes.Black;
            }

        }

        private void rtwtw_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[2, 4] = int.Parse("x");
            if (rtwtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rtwtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rtwtw.Foreground = Brushes.Black;
            }
        }

        private void rtwth_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[2, 3] = int.Parse("x");
            if (rtwth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rtwth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rtwth.Foreground = Brushes.Black;
            }

        }

        private void rtwfr_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[2, 2] = int.Parse("x");
            if (rtwfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rtwfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rtwfr.Foreground = Brushes.Black;
            }

        }

        private void rtwfv_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[2, 1] = int.Parse("x");
            if (rtwfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rtwfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rtwfv.Foreground = Brushes.Black;
            }

        }

        private void rthf_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[3, 5] = int.Parse("x");
            if (rthf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rthf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rthf.Foreground = Brushes.Black;
            }

        }

        private void rthtw_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[3, 4] = int.Parse("x");
            if (rthtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rthtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rthtw.Foreground = Brushes.Black;
            }

        }

        private void rthth_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[3, 3] = int.Parse("x");
            if (rthth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rthth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rthth.Foreground = Brushes.Black;
            }

        }

        private void rthfr_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[3, 2] = int.Parse("x");
            if (rthfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rthfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rthfr.Foreground = Brushes.Black;
            }

        }

        private void rthfv_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[3, 1] = int.Parse("x");
            if (rthfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rthfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rthfv.Foreground = Brushes.Black;
            }

        }

        private void rfrf_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[4, 5] = int.Parse("x");
            if (rfrf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfrf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfrf.Foreground = Brushes.Black;
            }

        }

        private void rfrtw_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[4, 4] = int.Parse("x");
            if (rfrtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfrtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfrtw.Foreground = Brushes.Black;
            }

        }

        private void rfrth_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[4, 3] = int.Parse("x");
            if (rfrth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfrth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfrth.Foreground = Brushes.Black;
            }
        }

        private void rfrfr_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[4, 2] = int.Parse("x");
            if (rfrfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfrfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfrfr.Foreground = Brushes.Black;
            }

        }

        private void rfrfv_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[4, 1] = int.Parse("x");
            if (rfrfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfrfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfrfv.Foreground = Brushes.Black;
            }

        }

        private void rfvf_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[5, 5] = int.Parse("x");
            if (rfvf.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfvf.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfvf.Foreground = Brushes.Black;
            }

        }

        private void rfvtw_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[5, 4] = int.Parse("x");
            if (rfvtw.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfvtw.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfvtw.Foreground = Brushes.Black;
            }

        }

        private void rfvth_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[5, 3] = int.Parse("x");
            if (rfvth.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfvth.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfvth.Foreground = Brushes.Black;
            }

        }

        private void rfvfr_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[5, 2] = int.Parse("x");
            if (rfvfr.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfvfr.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfvfr.Foreground = Brushes.Black;
            }

        }

        private void rfvfv_Click(object sender, RoutedEventArgs e)
        {
            jobbhelyek[5, 1] = int.Parse("x");
            if (rfvfv.Background == Brushes.Red)
            {
                MessageBox.Show("Ez a hely már levan foglalva!", "Hiba!");
            }
            else
            {
                rfvfv.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f5d21f"));
                rfvfv.Foreground = Brushes.Black;
            }

        }
        private void lbutton_Click(object sender, RoutedEventArgs e)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (balhelyek[x, y] == lefoglalthelyek.Contains)()
                    {
                        balhelyek[x, y] = 9;
                    }
                }
            }
        }
    }
}
