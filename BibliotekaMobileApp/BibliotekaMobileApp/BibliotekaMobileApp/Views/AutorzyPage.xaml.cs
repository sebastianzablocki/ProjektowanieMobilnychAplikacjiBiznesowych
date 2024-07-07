using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;
using System;
using System.Linq;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutorzyPage : ContentPage
    {
        private AutorzyViewModel viewModel;

        public AutorzyPage()
        {
            InitializeComponent();
            viewModel = new AutorzyViewModel();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadAutorzyCommand.Execute(null);
        }

        private async void OnAutorTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Autor selectedAutor)
            {
                await Navigation.PushAsync(new AutorDetailPage(selectedAutor));
                // Resetowanie zaznaczenia
                AutorzyListView.SelectedItem = null;
            }
        }

        private async void OnAddAutorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AutorDetailPage(new Autor()));
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBar = sender as SearchBar;
            var searchText = searchBar.Text.ToLower();

            // Zakładając, że Autorzy jest ObservableCollection<Autor>
            var filteredList = viewModel.Autorzy
                .Where(a => a.ImieNazwisko.ToLower().Contains(searchText))
                .ToList();
            AutorzyListView.ItemsSource = filteredList;
        }
    }
}
