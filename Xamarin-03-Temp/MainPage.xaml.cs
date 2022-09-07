using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_03_Temp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = listeTemp;
            listeTemp.Add("test - test");
        }
        ObservableCollection<String> listeTemp = new ObservableCollection<string>();

        private void inputCelsius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(inputCelsius.Text))
            {
                inputFarhenheit.Text = FahrenheitFromCelcius(Convert.ToDouble(inputCelsius.Text));
            }
        }

        private void inputFarhenheit_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!String.IsNullOrEmpty(inputFarhenheit.Text))
            {
                inputCelsius.Text = CelciusFromFahrenheit(Math.Round(Convert.ToDouble(inputFarhenheit.Text), 2));
            }
        }
        private void sauvegarder_Clicked(object sender, EventArgs e)
        {
            listeTemp.Add($"{inputCelsius.Text}°C = {inputFarhenheit.Text}°F");
        }
        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            listeTemp.RemoveAt(e.ItemIndex);
        }

        public static String FahrenheitFromCelcius(Double celsius)
        {
            double fahrenheit = Math.Round(((9.0 / 5.0) * celsius + 32.0), 2);
            return fahrenheit.ToString();
        }
        public static String CelciusFromFahrenheit(Double fahrenheit)
        {
            double celsius = Math.Round((5.0 / 9.0) * (fahrenheit - 32.0), 2);
            return celsius.ToString();
        }

    }
}
