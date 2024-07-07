using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class CzłonkowieViewModel : BaseViewModel
    {
        public ObservableCollection<Członek> Członkowie { get; set; }
        private ApiService _apiService;

        public CzłonkowieViewModel()
        {
            _apiService = new ApiService();
            Członkowie = new ObservableCollection<Członek>();
            LoadCzłonkowieCommand = new Command(async () => await LoadCzłonkowie());
            AddCommand = new Command(async () => await AddCzłonek());
            SelectCommand = new Command<Członek>(async (członek) => await SelectCzłonek(członek));
        }

        public ICommand LoadCzłonkowieCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SelectCommand { get; }

        private async Task LoadCzłonkowie()
        {
            var członkowieList = await _apiService.GetCzłonkowieAsync();
            Członkowie.Clear();
            foreach (var członek in członkowieList)
            {
                Członkowie.Add(członek);
            }
        }

        private async Task AddCzłonek()
        {
            // Logika dodawania członka
        }

        private async Task SelectCzłonek(Członek członek)
        {
            // Logika wyboru członka
        }
    }
}
