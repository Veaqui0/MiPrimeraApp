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

 
    /* private void OnSaludarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nombreEntry.Text))
        {
            saludoLabel.Text = "Por favor escribe un nombre";
            return;
        }
 
        saludoLabel.Text = $"¡Hola, {nombreEntry.Text}!";
    }

    private void OnColorClicked(object sender, EventArgs e)
    {
        var random = new Random();
        var colores = new[] { Colors.LightBlue, Colors.LightGreen, Colors.LightPink, Colors.LightYellow };
        this.BackgroundColor = colores[random.Next(colores.Length)];
    }

    private void OnModoToggled(object sender, ToggledEventArgs e)
    {
        this.BackgroundColor = e.Value ? Colors.Black : Colors.White;
        saludoLabel.TextColor = e.Value ? Colors.White : Colors.Black;
    }

    private void OnTamanoChanged(object sender, ValueChangedEventArgs e)
    {
        saludoLabel.FontSize = e.NewValue;
    } */


}
