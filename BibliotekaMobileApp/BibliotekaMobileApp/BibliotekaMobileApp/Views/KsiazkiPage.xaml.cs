using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;
using System;
using System.Linq;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KsiazkiPage : ContentPage
    {
        private KsiazkiViewModel viewModel;

        public KsiazkiPage()
        {
            InitializeComponent();
            viewModel = new KsiazkiViewModel();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadKsiazkiCommand.Execute(null);
        }

        private async void OnKsiazkaSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Ksiazka selectedKsiazka)
            {
                await Navigation.PushAsync(new KsiazkaDetailPage(selectedKsiazka));
                // Resetowanie zaznaczenia
                KsiazkiListView.SelectedItem = null;
            }
        }

        private async void OnAddKsiazkaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KsiazkaDetailPage(new Ksiazka()));
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBar = sender as SearchBar;
            var searchText = searchBar.Text.ToLower();

            // Zakładając, że Ksiazki jest ObservableCollection<Ksiazka>
            var filteredList = viewModel.Ksiazki
                .Where(k => k.Tytul.ToLower().Contains(searchText))
                .ToList();
            KsiazkiListView.ItemsSource = filteredList;
        }
    }
}
