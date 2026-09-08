namespace MiPrimeraApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetalleFrutaPage), typeof(DetalleFrutaPage));
	}
}
