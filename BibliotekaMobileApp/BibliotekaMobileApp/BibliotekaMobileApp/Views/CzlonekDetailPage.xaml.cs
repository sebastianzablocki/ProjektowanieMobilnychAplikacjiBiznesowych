using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CzłonekDetailPage : ContentPage
    {
        public CzłonekDetailPage(Członek członek)
        {
            InitializeComponent();
            BindingContext = new CzłonekDetailViewModel(członek);
        }
    }
}
