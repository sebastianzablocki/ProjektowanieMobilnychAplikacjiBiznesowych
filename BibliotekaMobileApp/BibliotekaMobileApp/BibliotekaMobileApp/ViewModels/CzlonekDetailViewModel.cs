using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class CzłonekDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public Członek Członek { get; set; }

        public CzłonekDetailViewModel(Członek członek)
        {
            _apiService = new ApiService();
            Członek = członek;
        }

        public async Task SaveCzłonek()
        {
            if (Członek.CzłonekId == 0)
            {
                await _apiService.AddCzłonekAsync(Członek);
            }
            else
            {
                await _apiService.UpdateCzłonekAsync(Członek);
            }
        }

        public async Task DeleteCzłonek()
        {
            await _apiService.DeleteCzłonekAsync(Członek.CzłonekId);
        }
    }
}
