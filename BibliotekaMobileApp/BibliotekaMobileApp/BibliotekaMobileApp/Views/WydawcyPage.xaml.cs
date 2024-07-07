using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WydawcyPage : ContentPage
    {
        public WydawcyPage()
        {
            InitializeComponent();
            BindingContext = new WydawcyViewModel();
        }
    }
}
