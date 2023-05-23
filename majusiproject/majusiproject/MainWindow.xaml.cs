using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.IO;

namespace majusiproject
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> users = new Dictionary<string, string>(); // Felhasználók tárolása (felhasználónév és titkosított jelszó hash)
        private string[] imageNames = { "film1.jpg", "film2.jpg", "film3.jpg", "film4.jpg", "film5.jpg" };
        private int currentIndex = 0;
        private DispatcherTimer timer;
        private string userDataFilePath = "userdata.txt";

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();

            LoadUserData();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowNextImage();
        }

        private void ShowNextImage()
        {
            string imageName = imageNames[currentIndex];
            string imagePath = $"Assets/{imageName}";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            newsImage.Source = bitmap;
            currentIndex = (currentIndex + 1) % imageNames.Length;
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
            string inputEmail = emailTextBox.Text;
            string confirmPassword = confirmPasswordBox.Password;

            if (!string.IsNullOrEmpty(inputUsername) && !string.IsNullOrEmpty(inputPassword) && !string.IsNullOrEmpty(inputEmail) && !string.IsNullOrEmpty(confirmPassword))
            {
                if (!inputEmail.Contains("@"))
                {
                    MessageBox.Show("Hibás e-mail formátum!");
                    return;
                }

                if (inputPassword != confirmPassword)
                {
                    MessageBox.Show("A jelszavak nem egyeznek meg!");
                    return;
                }

                // Felhasználó regisztráció
                if (!users.ContainsKey(inputUsername))
                {
                    users.Add(inputUsername, CalculateMD5Hash(inputPassword));
                    SaveUserData(inputUsername, inputPassword, inputEmail);
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

        private void LoadUserData()
        {
            try
            {
                if (File.Exists(userDataFilePath))
                {
                    using (StreamReader reader = new StreamReader(userDataFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(':');
                            if (parts.Length == 3)
                            {
                                string username = parts[0];
                                string passwordHash = parts[1];
                                string email = parts[2];
                                users.Add(username, passwordHash);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltése közben: " + ex.Message);
            }
        }

        private void SaveUserData(string username, string password, string email)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(userDataFilePath, true))
                {
                    string hashedPassword = CalculateMD5Hash(password);
                    writer.WriteLine($"{username}:{hashedPassword}:{email}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok mentése közben: " + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
