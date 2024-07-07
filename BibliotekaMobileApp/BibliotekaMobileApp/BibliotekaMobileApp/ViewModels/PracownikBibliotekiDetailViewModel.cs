using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class PracownikBibliotekiDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public PracownikBiblioteki PracownikBiblioteki { get; set; }

        public PracownikBibliotekiDetailViewModel(PracownikBiblioteki pracownikBiblioteki)
        {
            _apiService = new ApiService();
            PracownikBiblioteki = pracownikBiblioteki;
        }

        public async Task SavePracownikBiblioteki()
        {
            if (PracownikBiblioteki.PracownikBibliotekiId == 0)
            {
                await _apiService.AddPracownikBibliotekiAsync(PracownikBiblioteki);
            }
            else
            {
                await _apiService.UpdatePracownikBibliotekiAsync(PracownikBiblioteki);
            }
        }

        public async Task DeletePracownikBiblioteki()
        {
            await _apiService.DeletePracownikBibliotekiAsync(PracownikBiblioteki.PracownikBibliotekiId);
        }
    }
}
