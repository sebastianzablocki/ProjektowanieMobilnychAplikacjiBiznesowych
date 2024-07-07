using Xamarin.Forms;

namespace BibliotekaMobileApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AutorzyButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AutorzyPage());
        }

        private async void KategorieButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KategoriePage());
        }

        private async void CzlonkowieButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CzłonkowiePage());
        }

        private async void KsiazkiButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KsiazkiPage());
        }

        private async void OddzialyButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OddzialyPage());
        }

        private async void PracownicyButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PracownicyPage());
        }

        private async void WydawcyButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new WydawcyPage());
        }

        private async void WypozyczeniaButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new WypozyczeniaPage());
        }
    }
}
