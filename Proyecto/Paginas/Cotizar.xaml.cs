using Microsoft.Identity.Client;

namespace Proyecto.Paginas;

public partial class Cotizar : ContentPage
{
    public Efectuar cotizar;

    public Cotizar(Efectuar cotizar, double total)
	{
		InitializeComponent();
        this.cotizar = cotizar;
        string totalfinal = total.ToString("0.00");
        LabelTotal.Text = Convert.ToString("El total de su orden es: $ " + totalfinal);
    }

    private void RegresarClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        cotizar.Borrar();
        cotizar.Limpiar();
    }
}