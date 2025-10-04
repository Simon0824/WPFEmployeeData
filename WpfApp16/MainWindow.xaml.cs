using Microsoft.VisualBasic;
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
        public static string duzeimale = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        public static string cyfryy = "0123456789";
        public static string specjalnee = "!@#$%^&*()_+-=";
        public static string MaleDuzeSpecjalneCyfry = duzeimale.Concat(cyfryy).Concat(specjalnee).ToString();
        public static string MaleDuzeSpecjalne = duzeimale.Concat(specjalnee).ToString();
        public static string MaleDuzeCyfry = duzeimale.Concat(cyfryy).ToString();
        public static string SpecjalneCyfry = cyfryy.Concat(specjalnee).ToString();
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
            haslo = new string[znaczki];
            Random random = new Random();
            if (cyfry.IsChecked == true && maleiduze.IsChecked == true && specjalne.IsChecked == true)
            {
                for(int i = 0; i < znaczki; i++)
                {
                    int dlugosc = MaleDuzeSpecjalneCyfry.Length;
                    haslo[i] = MaleDuzeSpecjalneCyfry[random.Next(0, dlugosc)].ToString();
                }
            } 
            else if (cyfry.IsChecked == true && maleiduze.IsChecked == true && specjalne.IsChecked == false)
            {
                for (int i = 0; i < znaczki; i++)
                {
                    int dlugosc = MaleDuzeCyfry.Length;
                    haslo[i] = MaleDuzeCyfry[random.Next(0, dlugosc)].ToString();
                }
            }
            else if (cyfry.IsChecked == true && specjalne.IsChecked == true && maleiduze.IsChecked == false)
            {
                for (int i = 0; i < znaczki; i++)
                {
                    int dlugosc = SpecjalneCyfry.Length;
                    haslo[i] = SpecjalneCyfry[random.Next(0, dlugosc)].ToString();
                }
            }
            else if (maleiduze.IsChecked == true && specjalne.IsChecked == true && cyfry.IsChecked == false)
            {
                for (int i = 0; i < znaczki; i++)
                {
                    int dlugosc = MaleDuzeSpecjalne.Length;
                    haslo[i] = MaleDuzeSpecjalne[random.Next(0, dlugosc)].ToString();
                }
            }
            else if (maleiduze.IsChecked == true && specjalne.IsChecked == false && cyfry.IsChecked == false)
            {
                int dlugosc = duzeimale.Length;
                for(int i = 0; i < znaczki; i++)
                {
                    haslo[i] = duzeimale[random.Next(0, dlugosc)].ToString();
                }
            }
            else if (specjalne.IsChecked == true && maleiduze.IsChecked == false && cyfry.IsChecked == false)
            {
                for (int i = 0; i < znaczki; i++)
                {
                    int dlugosc = specjalnee.Length;
                    haslo[i] = specjalnee[random.Next(0, dlugosc)].ToString();
                }
            }
            else if (cyfry.IsChecked == true && maleiduze.IsChecked == false && specjalne.IsChecked == false)
            {
                for (int i = 0; i < znaczki; i++)
                {
                    int dlugosc = cyfryy.Length;
                    haslo[i] = cyfryy[random.Next(0, dlugosc)].ToString();
                }
            }
        }

        }
    }
