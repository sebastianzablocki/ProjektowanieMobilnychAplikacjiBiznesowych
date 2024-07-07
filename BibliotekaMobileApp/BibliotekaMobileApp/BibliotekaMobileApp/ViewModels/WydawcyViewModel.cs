using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class WydawcyViewModel
    {
        public ObservableCollection<Wydawca> Wydawcy { get; set; }
        private ApiService _apiService;

        public WydawcyViewModel()
        {
            _apiService = new ApiService();
            Wydawcy = new ObservableCollection<Wydawca>();
            LoadWydawcy();
        }

        private async void LoadWydawcy()
        {
            var wydawcyList = await _apiService.GetWydawcyAsync();
            foreach (var wydawca in wydawcyList)
            {
                Wydawcy.Add(wydawca);
            }
        }
    }
}
