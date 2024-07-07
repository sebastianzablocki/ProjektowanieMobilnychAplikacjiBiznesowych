using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WypozyczeniaPage : ContentPage
    {
        public WypozyczeniaPage()
        {
            InitializeComponent();
            BindingContext = new WypozyczeniaViewModel();
        }
    }
}
