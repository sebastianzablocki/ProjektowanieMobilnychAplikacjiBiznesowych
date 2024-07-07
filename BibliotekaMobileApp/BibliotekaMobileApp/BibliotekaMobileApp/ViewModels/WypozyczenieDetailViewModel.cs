using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class WypozyczenieDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public Wypozyczenie Wypozyczenie { get; set; }

        public WypozyczenieDetailViewModel(Wypozyczenie wypozyczenie)
        {
            _apiService = new ApiService();
            Wypozyczenie = wypozyczenie;
        }

        public async Task SaveWypozyczenie()
        {
            if (Wypozyczenie.WypozyczenieId == 0)
            {
                await _apiService.AddWypozyczenieAsync(Wypozyczenie);
            }
            else
            {
                await _apiService.UpdateWypozyczenieAsync(Wypozyczenie);
            }
        }

        public async Task DeleteWypozyczenie()
        {
            await _apiService.DeleteWypozyczenieAsync(Wypozyczenie.WypozyczenieId);
        }
    }
}
