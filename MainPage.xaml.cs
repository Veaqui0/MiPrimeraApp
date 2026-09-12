/**
* Programación orientada a objetos 2, App Movil, Victor Alvarez
*/

using MiPrimeraApp.Models;

namespace MiPrimeraApp;
 
public partial class MainPage : ContentPage
{
    
    private List<Fruta> frutas = new()
    {
        new Fruta { Nombre = "Manzana", Descripcion = "Fruta roja o verde, crujiente y dulce." },
        new Fruta { Nombre = "Banano",  Descripcion = "Fruta amarilla, rica en potasio." },
        new Fruta { Nombre = "Naranja", Descripcion = "Cítrico jugoso, alto en vitamina C." },
    };


    public MainPage()
    {
        InitializeComponent();
        frutasCollectionView.ItemsSource = frutas;
    }

    private async void OnFrutaSeleccionada(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Fruta frutaSeleccionada)
            return;
 
        var parametros = new Dictionary<string, object>
        {
            { "NombreFruta", frutaSeleccionada.Nombre },
            { "DescripcionFruta", frutaSeleccionada.Descripcion }
        };
 
        await Shell.Current.GoToAsync(nameof(DetalleFrutaPage), parametros);
 
        // Deseleccionar para permitir volver a elegir la misma fruta más adelante
        frutasCollectionView.SelectedItem = null;
    }

}
