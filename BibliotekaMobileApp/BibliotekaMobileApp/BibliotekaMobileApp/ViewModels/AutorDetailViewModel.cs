using System.Threading.Tasks;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.Services;
using Xamarin.Forms;

namespace BibliotekaMobileApp.ViewModels
{
    public class AutorDetailViewModel : BaseViewModel
    {
        private ApiService _apiService;
        public Autor Autor { get; set; }

        public AutorDetailViewModel(Autor autor)
        {
            _apiService = new ApiService();
            Autor = autor;
        }

        public async Task SaveAutor()
        {
            if (Autor.AutorId == 0)
            {
                await _apiService.AddAutorAsync(Autor);
            }
            else
            {
                await _apiService.UpdateAutorAsync(Autor);
            }
        }

        public async Task DeleteAutor()
        {
            await _apiService.DeleteAutorAsync(Autor.AutorId);
        }
    }
}
