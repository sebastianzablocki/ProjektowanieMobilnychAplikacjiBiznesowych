using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.ViewModels;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OddzialyPage : ContentPage
    {
        public OddzialyPage()
        {
            InitializeComponent();
            BindingContext = new OddzialyViewModel();
        }
    }
}
