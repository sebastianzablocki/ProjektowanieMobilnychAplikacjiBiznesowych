using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class AutorzyViewModel : BaseViewModel
    {
        public ObservableCollection<Autor> Autorzy { get; set; }
        private ApiService _apiService;

        public AutorzyViewModel()
        {
            _apiService = new ApiService();
            Autorzy = new ObservableCollection<Autor>();
            LoadAutorzyCommand = new Command(async () => await LoadAutorzy());
            AddCommand = new Command(async () => await AddAutor());
            SelectCommand = new Command<Autor>(async (autor) => await SelectAutor(autor));
        }

        public ICommand LoadAutorzyCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SelectCommand { get; }

        private async Task LoadAutorzy()
        {
            var autorzyList = await _apiService.GetAutorzyAsync();
            Autorzy.Clear();
            foreach (var autor in autorzyList)
            {
                Autorzy.Add(autor);
            }
        }

        private async Task AddAutor()
        {
            // Logika dodawania autora
        }

        private async Task SelectAutor(Autor autor)
        {
            // Logika wyboru autora
        }
    }
}
