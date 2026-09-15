using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MiPrimeraApp.Models;
 
namespace MiPrimeraApp.ViewModels;
 
public partial class FrutaViewModel : ObservableObject
{
    public ObservableCollection<Fruta> Frutas { get; } = new()
    {
        new Fruta { Nombre = "Manzana", Descripcion = "Fruta roja o verde, crujiente y dulce." },
        new Fruta { Nombre = "Banano",  Descripcion = "Fruta amarilla, rica en potasio." },
        new Fruta { Nombre = "Naranja", Descripcion = "Cítrico jugoso, alto en vitamina C." },
    };
 
    [ObservableProperty]
    private Fruta frutaSeleccionada;
 
    [RelayCommand]
    async Task IrADetalle(Fruta fruta)
    {
        if (fruta is null)
            return;
 
        var parametros = new Dictionary<string, object>
        {
            { "NombreFruta", fruta.Nombre },
            { "DescripcionFruta", fruta.Descripcion }
        };
 
        await Shell.Current.GoToAsync(nameof(DetalleFrutaPage), parametros);
    }
}
