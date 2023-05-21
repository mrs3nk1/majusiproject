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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace majusiproject
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> users = new Dictionary<string, string>(); // Felhasználók tárolása (felhasználónév és titkosított jelszó hash)

        public MainWindow()
        {
            InitializeComponent();

            // Itt adhatsz hozzá alapértelmezett felhasználókat a regisztrációhoz (opcionális)
            users.Add("admin", "4F3BF6ECA1270E9D"); // Példa alapértelmezett felhasználó
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordBox.Password;

            if (users.ContainsKey(inputUsername) && CalculateMD5Hash(inputPassword) == users[inputUsername])
            {
                // Sikeres bejelentkezés
                MessageBox.Show("Sikeres bejelentkezés!");

                // Új ablak megnyitása
                NewWindow newWindow = new NewWindow();
                newWindow.Show();

                // Az aktuális ablak bezárása
                Close();
            }
            else
            {
                // Sikertelen bejelentkezés
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordBox.Password;

            if (!string.IsNullOrEmpty(inputUsername) && !string.IsNullOrEmpty(inputPassword))
            {
                // Felhasználó regisztráció
                if (!users.ContainsKey(inputUsername))
                {
                    users.Add(inputUsername, CalculateMD5Hash(inputPassword));
                    MessageBox.Show("Sikeres regisztráció!");
                }
                else
                {
                    MessageBox.Show("A felhasználónév már foglalt!");
                }
            }
            else
            {
                MessageBox.Show("Kérlek töltsd ki az összes mezőt!");
            }
        }

        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
