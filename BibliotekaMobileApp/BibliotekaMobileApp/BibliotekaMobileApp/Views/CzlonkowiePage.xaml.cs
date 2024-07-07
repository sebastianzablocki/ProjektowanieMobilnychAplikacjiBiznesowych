using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;
using System;
using System.Linq;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CzłonkowiePage : ContentPage
    {
        private CzłonkowieViewModel viewModel;

        public CzłonkowiePage()
        {
            InitializeComponent();
            viewModel = new CzłonkowieViewModel();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadCzłonkowieCommand.Execute(null);
        }

        private async void OnCzłonekSelected(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Członek selectedCzłonek)
            {
                await Navigation.PushAsync(new CzłonekDetailPage(selectedCzłonek));
                // Resetowanie zaznaczenia
                CzłonkowieListView.SelectedItem = null;
            }
        }

        private async void OnAddCzłonekClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CzłonekDetailPage(new Członek()));
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBar = sender as SearchBar;
            var searchText = searchBar.Text.ToLower();

            // Zakładając, że Członkowie jest ObservableCollection<Członek>
            var filteredList = viewModel.Członkowie
                .Where(c => c.ImieNazwisko.ToLower().Contains(searchText))
                .ToList();
            CzłonkowieListView.ItemsSource = filteredList;
        }
    }
}
