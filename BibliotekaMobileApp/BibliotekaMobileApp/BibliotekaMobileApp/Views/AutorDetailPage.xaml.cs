using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotekaMobileApp.Models;
using BibliotekaMobileApp.ViewModels;
using System;

namespace BibliotekaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutorDetailPage : ContentPage
    {
        private AutorDetailViewModel viewModel;

        public AutorDetailPage(Autor autor)
        {
            InitializeComponent();
            viewModel = new AutorDetailViewModel(autor);
            BindingContext = viewModel;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await viewModel.SaveAutor();
            await Navigation.PopAsync();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            await viewModel.DeleteAutor();
            await Navigation.PopAsync();
        }
    }
}
