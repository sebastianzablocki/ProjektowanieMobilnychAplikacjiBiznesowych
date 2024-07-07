using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;
using System;
using System.Linq;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategoriePage : ContentPage
    {
        private KategorieViewModel viewModel;

        public KategoriePage()
        {
            InitializeComponent();
            viewModel = new KategorieViewModel();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadKategorieCommand.Execute(null);
        }

        private async void OnKategoriaSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Kategoria selectedKategoria)
            {
                await Navigation.PushAsync(new KategoriaDetailPage(selectedKategoria));
                // Resetowanie zaznaczenia
                KategorieListView.SelectedItem = null;
            }
        }

        private async void OnAddKategoriaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KategoriaDetailPage(new Kategoria()));
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBar = sender as SearchBar;
            var searchText = searchBar.Text.ToLower();

            // Zakładając, że Kategorie jest ObservableCollection<Kategoria>
            var filteredList = viewModel.Kategorie
                .Where(k => k.Nazwa.ToLower().Contains(searchText))
                .ToList();
            KategorieListView.ItemsSource = filteredList;
        }
    }
}
