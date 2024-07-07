using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategoriaDetailPage : ContentPage
    {
        public KategoriaDetailPage(Kategoria kategoria)
        {
            InitializeComponent();
            BindingContext = new KategoriaDetailViewModel(kategoria);
        }
    }
}
