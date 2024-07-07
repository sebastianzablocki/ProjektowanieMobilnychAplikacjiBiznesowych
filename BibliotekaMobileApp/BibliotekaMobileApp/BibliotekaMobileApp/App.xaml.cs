using Xamarin.Forms;
using BibliotekaMobileApp.Views;

namespace BibliotekaMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
           
        }
    }
}
