using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class OddzialyViewModel
    {
        public ObservableCollection<OddzialBiblioteki> Oddzialy { get; set; }
        private ApiService _apiService;

        public OddzialyViewModel()
        {
            _apiService = new ApiService();
            Oddzialy = new ObservableCollection<OddzialBiblioteki>();
            LoadOddzialy();
        }

        private async void LoadOddzialy()
        {
            var oddzialyList = await _apiService.GetOddzialyAsync();
            foreach (var oddzial in oddzialyList)
            {
                Oddzialy.Add(oddzial);
            }
        }
    }
}
