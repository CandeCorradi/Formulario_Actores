using AppNetMaui.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace AppNetMaui.Views;

public partial class PeliculasView : ContentPage
{
    HttpClient clientHttp = new HttpClient();
    string url = "https://practprof2023-2855.restdb.io/rest/movies?apikey=5ef3666c6a76415a50ddab26a474d3a68c6b4";
    ObservableCollection<Pelicula> peliculas;

    public PeliculasView()
	{
		InitializeComponent();
		TituloLabel.Text = "Peliculas - NET MAUI";
        ObtenemosPeliculas();
    }

    private async void ObtenemosPeliculas()
    {
        var response = await clientHttp.GetAsync(url);
        if (response != null)
        {
            peliculas = await response.Content.ReadFromJsonAsync<ObservableCollection<Pelicula>>();
            PeliculasListView.ItemsSource = peliculas;
        }
    }
}