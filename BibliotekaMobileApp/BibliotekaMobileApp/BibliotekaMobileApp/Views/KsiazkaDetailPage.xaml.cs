using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KsiazkaDetailPage : ContentPage
    {
        public KsiazkaDetailPage(Ksiazka ksiazka)
        {
            InitializeComponent();
            BindingContext = new KsiazkaDetailViewModel(ksiazka);
        }
    }
}
