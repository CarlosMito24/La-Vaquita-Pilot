using Proyecto.Paginas;

namespace Proyecto;

public partial class AppShell : Shell
{
	/// <summary>
	/// Indica a que página se dirigirá 
	/// </summary>
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Comprar), typeof(Comprar));
    }
}
