using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class WypozyczeniaViewModel
    {
        public ObservableCollection<Wypozyczenie> Wypozyczenia { get; set; }
        private ApiService _apiService;

        public WypozyczeniaViewModel()
        {
            _apiService = new ApiService();
            Wypozyczenia = new ObservableCollection<Wypozyczenie>();
            LoadWypozyczenia();
        }

        private async void LoadWypozyczenia()
        {
            var wypozyczeniaList = await _apiService.GetWypozyczeniaAsync();
            foreach (var wypozyczenie in wypozyczeniaList)
            {
                Wypozyczenia.Add(wypozyczenie);
            }
        }
    }
}
