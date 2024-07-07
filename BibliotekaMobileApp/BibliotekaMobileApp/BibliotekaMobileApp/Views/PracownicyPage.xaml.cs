using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracownicyPage : ContentPage
    {
        public PracownicyPage()
        {
            InitializeComponent();
            BindingContext = new PracownicyViewModel();
        }
    }
}
