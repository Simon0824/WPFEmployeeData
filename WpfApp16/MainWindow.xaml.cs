using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string duze = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string male = "qwertyuiopasdfghjklzxcvbnm";
        string cyfryy = "0123456789";
        string specjalnee = "!@#$%^&*()_+-=";
        string[] haslo = new string[4];
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {imie.Text}, {nazwisko.Text}, {stanowisko.SelectedItem as ComboBoxItem}, Hasło: {haslo.ToString()}");
        }
        private void generuj_Click(object sender, RoutedEventArgs e)
        {
            int licznik = 0;
            Random random = new Random();
            if (cyfry.IsChecked == true && maleiduze.IsChecked == true && specjalne.IsChecked == true)
            {
                while(licznik < 4 )
                {
                    haslo[licznik] = duze[random.Next(duze.Length)].ToString();
                    licznik++;
                    haslo[licznik] = male[random.Next(male.Length)].ToString();
                    licznik++;
                    haslo[licznik] = cyfryy[random.Next(cyfryy.Length)].ToString();
                    licznik++;
                    haslo[licznik] = specjalnee[random.Next(specjalnee.Length)].ToString();
                    licznik++;
                }
            } 
            else if (cyfry.IsChecked == true && maleiduze.IsChecked == true)
            {
                while (licznik < 4)
                {
                    haslo[licznik] = duze[random.Next(duze.Length)].ToString();
                    licznik++;
                    haslo[licznik] = male[random.Next(male.Length)].ToString();
                    licznik++;
                    haslo[licznik] = cyfryy[random.Next(cyfryy.Length)].ToString();
                    licznik++;
                }
            }
            else if (cyfry.IsChecked == true && specjalne.IsChecked == true)
            {
                while (licznik < 4)
                {
                    haslo[licznik] = specjalnee[random.Next(specjalnee.Length)].ToString();
                    licznik++;
                    haslo[licznik] = cyfryy[random.Next(cyfryy.Length)].ToString();
                    licznik++;
                }
            }
            else if (maleiduze.IsChecked == true && specjalne.IsChecked == true)
            {
                while (licznik < 4)
                {
                    haslo[licznik] = specjalnee[random.Next(specjalnee.Length)].ToString();
                    licznik++;
                    haslo[licznik] = male[random.Next(male.Length)].ToString();
                    licznik++;
                    haslo[licznik] = duze[random.Next(duze.Length)].ToString();
                    licznik++;
                }
            }
            else if (maleiduze.IsChecked == true)
            {
                while (licznik < 4)
                {
                    haslo[licznik] = male[random.Next(male.Length)].ToString();
                    licznik++;
                    haslo[licznik] = duze[random.Next(duze.Length)].ToString();
                    licznik++;
                }
            }
            else if (specjalne.IsChecked == true)
            {
                while (licznik < 4)
                {
                    haslo[licznik] = specjalnee[random.Next(specjalnee.Length)].ToString();
                    licznik++;
                }
            }
            else if (cyfry.IsChecked == true)
            {
                while (licznik < 4)
                {
                    haslo[licznik] = cyfryy[random.Next(cyfryy.Length)].ToString();
                    licznik++;
                }
            }
        }

        }
    }
