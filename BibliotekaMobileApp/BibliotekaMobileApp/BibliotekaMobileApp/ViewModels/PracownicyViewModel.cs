using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;

namespace BibliotekaMobileApp.ViewModels
{
    public class PracownicyViewModel
    {
        public ObservableCollection<PracownikBiblioteki> Pracownicy { get; set; }
        private ApiService _apiService;

        public PracownicyViewModel()
        {
            _apiService = new ApiService();
            Pracownicy = new ObservableCollection<PracownikBiblioteki>();
            LoadPracownicy();
        }

        private async void LoadPracownicy()
        {
            var pracownicyList = await _apiService.GetPracownicyAsync();
            foreach (var pracownik in pracownicyList)
            {
                Pracownicy.Add(pracownik);
            }
        }
    }
}
