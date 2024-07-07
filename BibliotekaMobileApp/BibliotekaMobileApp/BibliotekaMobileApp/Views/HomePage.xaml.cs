using System;
using Xamarin.Forms;

namespace BibliotekaMobileApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnAutorzyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AutorzyPage());
        }

        private async void OnCzlonkowieClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CzłonkowiePage());
        }

        private async void OnKategorieClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KategoriePage());
        }

        private async void OnKsiazkiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KsiazkiPage());
        }

        private async void OnOddzialyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OddzialyPage());
        }

        private async void OnPracownicyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PracownicyPage());
        }

        private async void OnWydawcyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WydawcyPage());
        }

        private async void OnWypozyczeniaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WypozyczeniaPage());
        }
    }
}
