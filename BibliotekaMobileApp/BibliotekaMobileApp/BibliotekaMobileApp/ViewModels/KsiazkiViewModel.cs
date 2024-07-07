using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class KsiazkiViewModel : BaseViewModel
    {
        public ObservableCollection<Ksiazka> Ksiazki { get; set; }
        private ApiService _apiService;

        public KsiazkiViewModel()
        {
            _apiService = new ApiService();
            Ksiazki = new ObservableCollection<Ksiazka>();
            LoadKsiazkiCommand = new Command(async () => await LoadKsiazki());
            AddCommand = new Command(async () => await AddKsiazka());
            SelectCommand = new Command<Ksiazka>(async (ksiazka) => await SelectKsiazka(ksiazka));
        }

        public ICommand LoadKsiazkiCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SelectCommand { get; }

        private async Task LoadKsiazki()
        {
            var ksiazkiList = await _apiService.GetKsiazkiAsync();
            Ksiazki.Clear();
            foreach (var ksiazka in ksiazkiList)
            {
                Ksiazki.Add(ksiazka);
            }
        }

        private async Task AddKsiazka()
        {
            // Logika dodawania książki
        }

        private async Task SelectKsiazka(Ksiazka ksiazka)
        {
            // Logika wyboru książki
        }
    }
}
