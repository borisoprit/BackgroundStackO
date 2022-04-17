using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BackgroundStackO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            App.Current.Resources["defaultButtonBackgroundColor"] = Preferences.Get("defaultButtonBackgroundColor", "Blue");
            App.Current.Resources["PrincipalColor"] = Preferences.Get("PrincipalColor", "#181818");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("BackgroundColor", "Green");
            App.Current.Resources["defaultBackgroundColor"] = Preferences.Get("BackgroundColor", "Blue");
            Preferences.Set("PrincipalColor", "White");
            App.Current.Resources["PrincipalColor"] = Preferences.Get("PrincipalColor", "#181818");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Preferences.Set("BackgroundColor", "Red");
            App.Current.Resources["defaultBackgroundColor"] = Preferences.Get("BackgroundColor", "Blue");
            Preferences.Set("PrincipalColor", "Black");
            App.Current.Resources["PrincipalColor"] = Preferences.Get("PrincipalColor", "#181818");
        }
    }
}
