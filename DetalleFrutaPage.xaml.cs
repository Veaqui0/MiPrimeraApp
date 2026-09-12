namespace MiPrimeraApp;
 
[QueryProperty(nameof(NombreFruta), "NombreFruta")]
[QueryProperty(nameof(DescripcionFruta), "DescripcionFruta")]
public partial class DetalleFrutaPage : ContentPage
{
    public string NombreFruta
    {
        set => nombreLabel.Text = value;
    }
 
    public string DescripcionFruta
    {
        set => descripcionLabel.Text = value;
    }
 
    public DetalleFrutaPage()
    {
        InitializeComponent();
    }
 
    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
