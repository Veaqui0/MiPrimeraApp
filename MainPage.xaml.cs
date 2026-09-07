namespace MiPrimeraApp;
 
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
 
    private void OnSaludarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nombreEntry.Text))
        {
            saludoLabel.Text = "Por favor escribe un nombre";
            return;
        }
 
        saludoLabel.Text = $"¡Hola, {nombreEntry.Text}!";
    }
}
