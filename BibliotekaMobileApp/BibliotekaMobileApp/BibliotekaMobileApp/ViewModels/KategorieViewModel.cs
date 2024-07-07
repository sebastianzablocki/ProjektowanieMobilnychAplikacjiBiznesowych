using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class KategorieViewModel : BaseViewModel
    {
        public ObservableCollection<Kategoria> Kategorie { get; set; }
        private ApiService _apiService;

        public KategorieViewModel()
        {
            _apiService = new ApiService();
            Kategorie = new ObservableCollection<Kategoria>();
            LoadKategorieCommand = new Command(async () => await LoadKategorie());
            AddCommand = new Command(async () => await AddKategoria());
            SelectCommand = new Command<Kategoria>(async (kategoria) => await SelectKategoria(kategoria));
        }

        public ICommand LoadKategorieCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SelectCommand { get; }

        private async Task LoadKategorie()
        {
            var kategorieList = await _apiService.GetKategorieAsync();
            Kategorie.Clear();
            foreach (var kategoria in kategorieList)
            {
                Kategorie.Add(kategoria);
            }
        }

        private async Task AddKategoria()
        {
            // Logika dodawania kategorii
        }

        private async Task SelectKategoria(Kategoria kategoria)
        {
            // Logika wyboru kategorii
        }
    }
}
