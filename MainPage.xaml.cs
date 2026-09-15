/**
* Programación orientada a objetos 2, App Movil, Victor Alvarez
*/

using MiPrimeraApp.Models;
using MiPrimeraApp.ViewModels;
 
namespace MiPrimeraApp;
 
public partial class MainPage : ContentPage
{
    private readonly FrutaViewModel viewModel;
 
    public MainPage()
    {
        InitializeComponent();
        viewModel = new FrutaViewModel();
        BindingContext = viewModel;
    }
 
    private async void OnFrutaSeleccionada(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Fruta frutaSeleccionada)
            return;
 
        await viewModel.IrADetalleCommand.ExecuteAsync(frutaSeleccionada);
 
        frutasCollectionView.SelectedItem = null;
    }
}

