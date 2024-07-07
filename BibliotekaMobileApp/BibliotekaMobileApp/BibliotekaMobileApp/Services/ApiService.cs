using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BibliotekaMobileApp.Models;
using System.Text;

namespace BibliotekaMobileApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://10.0.2.2:7168/")
            };
        }

        public async Task<List<Ksiazka>> GetKsiazkiAsync()
        {
            var response = await _httpClient.GetStringAsync("api/ksiazki");
            return JsonConvert.DeserializeObject<List<Ksiazka>>(response);
        }

        public async Task<List<Autor>> GetAutorzyAsync()
        {
            var response = await _httpClient.GetStringAsync("api/autorzy");
            return JsonConvert.DeserializeObject<List<Autor>>(response);
        }

        public async Task<List<Kategoria>> GetKategorieAsync()
        {
            var response = await _httpClient.GetStringAsync("api/kategorie");
            return JsonConvert.DeserializeObject<List<Kategoria>>(response);
        }

        public async Task<List<Członek>> GetCzłonkowieAsync()
        {
            var response = await _httpClient.GetStringAsync("api/członkowie");
            return JsonConvert.DeserializeObject<List<Członek>>(response);
        }

        public async Task<List<Wydawca>> GetWydawcyAsync()
        {
            var response = await _httpClient.GetStringAsync("api/wydawcy");
            return JsonConvert.DeserializeObject<List<Wydawca>>(response);
        }

        public async Task<List<Wypozyczenie>> GetWypozyczeniaAsync()
        {
            var response = await _httpClient.GetStringAsync("api/wypozyczenia");
            return JsonConvert.DeserializeObject<List<Wypozyczenie>>(response);
        }

        public async Task<List<OddzialBiblioteki>> GetOddzialyAsync()
        {
            var response = await _httpClient.GetStringAsync("api/oddzialybiblioteki");
            return JsonConvert.DeserializeObject<List<OddzialBiblioteki>>(response);
        }

        public async Task<List<PracownikBiblioteki>> GetPracownicyAsync()
        {
            var response = await _httpClient.GetStringAsync("api/pracownicybiblioteki");
            return JsonConvert.DeserializeObject<List<PracownikBiblioteki>>(response);
        }

        public async Task AddKsiazkaAsync(Ksiazka ksiazka)
        {
            var json = JsonConvert.SerializeObject(ksiazka);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/ksiazki", content);
        }

        public async Task UpdateKsiazkaAsync(Ksiazka ksiazka)
        {
            var json = JsonConvert.SerializeObject(ksiazka);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/ksiazki/{ksiazka.KsiazkaId}", content);
        }

        public async Task DeleteKsiazkaAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/ksiazki/{id}");
        }

        public async Task AddAutorAsync(Autor autor)
        {
            var json = JsonConvert.SerializeObject(autor);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/autorzy", content);
        }

        public async Task UpdateAutorAsync(Autor autor)
        {
            var json = JsonConvert.SerializeObject(autor);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/autorzy/{autor.AutorId}", content);
        }

        public async Task DeleteAutorAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/autorzy/{id}");
        }

        public async Task AddKategoriaAsync(Kategoria kategoria)
        {
            var json = JsonConvert.SerializeObject(kategoria);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/kategorie", content);
        }

        public async Task UpdateKategoriaAsync(Kategoria kategoria)
        {
            var json = JsonConvert.SerializeObject(kategoria);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/kategorie/{kategoria.KategoriaId}", content);
        }

        public async Task DeleteKategoriaAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/kategorie/{id}");
        }

        // Metody POST, PUT, DELETE dla Członek
        public async Task AddCzłonekAsync(Członek członek)
        {
            var json = JsonConvert.SerializeObject(członek);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/członkowie", content);
        }

        public async Task UpdateCzłonekAsync(Członek członek)
        {
            var json = JsonConvert.SerializeObject(członek);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/członkowie/{członek.CzłonekId}", content);
        }

        public async Task DeleteCzłonekAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/członkowie/{id}");
        }

        // Metody POST, PUT, DELETE dla Wydawca
        public async Task AddWydawcaAsync(Wydawca wydawca)
        {
            var json = JsonConvert.SerializeObject(wydawca);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/wydawcy", content);
        }

        public async Task UpdateWydawcaAsync(Wydawca wydawca)
        {
            var json = JsonConvert.SerializeObject(wydawca);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/wydawcy/{wydawca.WydawcaId}", content);
        }

        public async Task DeleteWydawcaAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/wydawcy/{id}");
        }

        // Metody POST, PUT, DELETE dla Wypozyczenie
        public async Task AddWypozyczenieAsync(Wypozyczenie wypozyczenie)
        {
            var json = JsonConvert.SerializeObject(wypozyczenie);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/wypozyczenia", content);
        }

        public async Task UpdateWypozyczenieAsync(Wypozyczenie wypozyczenie)
        {
            var json = JsonConvert.SerializeObject(wypozyczenie);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/wypozyczenia/{wypozyczenie.WypozyczenieId}", content);
        }

        public async Task DeleteWypozyczenieAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/wypozyczenia/{id}");
        }

        // Metody POST, PUT, DELETE dla OddzialBiblioteki
        public async Task AddOddzialBibliotekiAsync(OddzialBiblioteki oddzialBiblioteki)
        {
            var json = JsonConvert.SerializeObject(oddzialBiblioteki);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/oddzialybiblioteki", content);
        }

        public async Task UpdateOddzialBibliotekiAsync(OddzialBiblioteki oddzialBiblioteki)
        {
            var json = JsonConvert.SerializeObject(oddzialBiblioteki);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/oddzialybiblioteki/{oddzialBiblioteki.OddzialBibliotekiId}", content);
        }

        public async Task DeleteOddzialBibliotekiAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/oddzialybiblioteki/{id}");
        }

        // Metody POST, PUT, DELETE dla PracownikBiblioteki
        public async Task AddPracownikBibliotekiAsync(PracownikBiblioteki pracownikBiblioteki)
        {
            var json = JsonConvert.SerializeObject(pracownikBiblioteki);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/pracownicybiblioteki", content);
        }

        public async Task UpdatePracownikBibliotekiAsync(PracownikBiblioteki pracownikBiblioteki)
        {
            var json = JsonConvert.SerializeObject(pracownikBiblioteki);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/pracownicybiblioteki/{pracownikBiblioteki.PracownikBibliotekiId}", content);
        }

        public async Task DeletePracownikBibliotekiAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/pracownicybiblioteki/{id}");
        }
    }
}
