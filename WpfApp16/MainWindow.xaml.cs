using System.Reflection.Emit;
using System.Security.RightsManagement;
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
        public static string duze = "QWERTYUIOPASDFGHJKLZXCVBNM";
        public static string male = "qwertyuiopasdfghjklzxcvbnm";
        public static string cyfryy = "0123456789";
        public static string specjalnee = "!@#$%^&*()_+-=";
        public static string MaleDuze = duze.Concat(male).ToString();
        public static int znaczki;
        string[] haslo = new string[znaczki];
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cos = ((ComboBoxItem)stanowisko.SelectedItem).Content.ToString();
            MessageBox.Show($"Dane pracownika: {imie.Text}, {nazwisko.Text}, {cos}, haslo: {string.Join("", haslo)}");
        }
        private void generuj_Click(object sender, RoutedEventArgs e)
        {
            znaczki = int.Parse(iloscznakow.Text);
            int licznik = 0;
            haslo = new string[znaczki];
            Random random = new Random();
            if (cyfry.IsChecked == true && maleiduze.IsChecked == true && specjalne.IsChecked == true)
            {
                while(licznik < znaczki)
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
                while (licznik < znaczki)
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
                while (licznik < znaczki)
                {
                    haslo[licznik] = specjalnee[random.Next(specjalnee.Length)].ToString();
                    licznik++;
                    haslo[licznik] = cyfryy[random.Next(cyfryy.Length)].ToString();
                    licznik++;
                }
            }
            else if (maleiduze.IsChecked == true && specjalne.IsChecked == true)
            {
                while (licznik < znaczki)
                {
                    haslo[licznik] = specjalnee[random.Next(specjalnee.Length)].ToString();
                    licznik++;
                    haslo[licznik] = male[random.Next(male.Length)].ToString();
                    licznik++;
                    haslo[licznik] = duze[random.Next(duze.Length)].ToString();
                    licznik++;
                }
            }
            else if (maleiduze.IsChecked == true && specjalne.IsChecked == false && cyfry.IsChecked == false)
            {
                licznik = 0;
                int dlugosc = MaleDuze.Length;
                for(int i = 0; i < znaczki; i++)
                {
                    haslo[i] = MaleDuze[random.Next(0, dlugosc)].ToString();
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
