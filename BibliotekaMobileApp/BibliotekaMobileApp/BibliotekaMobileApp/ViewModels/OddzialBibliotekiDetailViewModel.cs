using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class OddzialBibliotekiDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public OddzialBiblioteki OddzialBiblioteki { get; set; }

        public OddzialBibliotekiDetailViewModel(OddzialBiblioteki oddzialBiblioteki)
        {
            _apiService = new ApiService();
            OddzialBiblioteki = oddzialBiblioteki;
        }

        public async Task SaveOddzialBiblioteki()
        {
            if (OddzialBiblioteki.OddzialBibliotekiId == 0)
            {
                await _apiService.AddOddzialBibliotekiAsync(OddzialBiblioteki);
            }
            else
            {
                await _apiService.UpdateOddzialBibliotekiAsync(OddzialBiblioteki);
            }
        }

        public async Task DeleteOddzialBiblioteki()
        {
            await _apiService.DeleteOddzialBibliotekiAsync(OddzialBiblioteki.OddzialBibliotekiId);
        }
    }
}
