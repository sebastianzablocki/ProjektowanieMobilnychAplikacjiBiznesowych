using System.Windows.Input;
using Xamarin.Forms;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using System.Threading.Tasks;

namespace BibliotekaMobileApp.ViewModels
{
    public class KategoriaDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;

        public Kategoria Kategoria { get; set; }

        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        public KategoriaDetailViewModel(Kategoria kategoria)
        {
            _apiService = new ApiService();
            Kategoria = kategoria;

            SaveCommand = new Command(async () => await SaveKategoria());
            DeleteCommand = new Command(async () => await DeleteKategoria());
        }

        private async Task SaveKategoria()
        {
            await _apiService.UpdateKategoriaAsync(Kategoria);
            // Navigacja do poprzedniej strony lub inna logika po zapisaniu
        }

        private async Task DeleteKategoria()
        {
            await _apiService.DeleteKategoriaAsync(Kategoria.KategoriaId);
            // Navigacja do poprzedniej strony lub inna logika po usunięciu
        }
    }
}
