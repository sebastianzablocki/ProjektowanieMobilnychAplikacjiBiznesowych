using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class KsiazkaDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public Ksiazka Ksiazka { get; set; }

        public KsiazkaDetailViewModel(Ksiazka ksiazka)
        {
            _apiService = new ApiService();
            Ksiazka = ksiazka;
        }

        public async Task SaveKsiazka()
        {
            if (Ksiazka.KsiazkaId == 0)
            {
                await _apiService.AddKsiazkaAsync(Ksiazka);
            }
            else
            {
                await _apiService.UpdateKsiazkaAsync(Ksiazka);
            }
        }

        public async Task DeleteKsiazka()
        {
            await _apiService.DeleteKsiazkaAsync(Ksiazka.KsiazkaId);
        }
    }
}
