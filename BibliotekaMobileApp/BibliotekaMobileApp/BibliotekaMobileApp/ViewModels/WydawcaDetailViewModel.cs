using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class WydawcaDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public Wydawca Wydawca { get; set; }

        public WydawcaDetailViewModel(Wydawca wydawca)
        {
            _apiService = new ApiService();
            Wydawca = wydawca;
        }

        public async Task SaveWydawca()
        {
            if (Wydawca.WydawcaId == 0)
            {
                await _apiService.AddWydawcaAsync(Wydawca);
            }
            else
            {
                await _apiService.UpdateWydawcaAsync(Wydawca);
            }
        }

        public async Task DeleteWydawca()
        {
            await _apiService.DeleteWydawcaAsync(Wydawca.WydawcaId);
        }
    }
}
