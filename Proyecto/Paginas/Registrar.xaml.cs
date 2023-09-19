using Microsoft.VisualBasic;
using System.Text;
using System.Text.RegularExpressions;

namespace Proyecto.Paginas;

public partial class Registrar : ContentPage
{
    public Comprar comprar;
    public Registrar(Comprar comprar, double total)
	{
		InitializeComponent();
        this.comprar = comprar;
        string totalfinal = total.ToString("0.00");
        LabelTotal.Text = Convert.ToString("El total de su orden es: $ " + totalfinal);
        MostrarFechaActual();
    }

    private void RegresarClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        comprar.Borrar();
        comprar.Limpiar();
    }

    private void MostrarFechaActual()
    {
        string fecha;
        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // Asignar la fecha actual al Label
        fecha = fechaActual.ToString("dd/MM/yyyy");
        LabelFecha.Text = Convert.ToString("Fecha de la orden: " + fecha);
    }

    private void EfectuarCompraClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(NombreCliente.Text) && !string.IsNullOrEmpty(ApellidoCliente.Text) && !string.IsNullOrEmpty(NumeroCliente.Text))
        {
            string nombredelcliente = Convert.ToString(NombreCliente.Text);
            string apellidodelcliente = Convert.ToString(ApellidoCliente.Text);
            LabelNombre.Text = ("Cliente: " + nombredelcliente + " " + apellidodelcliente);
            LabelNombre.IsVisible = true;
            LabelNumeroOrden.Text = "Su número de orden es: 01";
            LabelNumeroOrden.IsVisible = true;
            LabelFecha.IsVisible = true;
            LabelTotal.IsVisible = true;
        }
        else
        {
            DisplayAlert("Error", "Debe rellenar todos los campos antes de que su compra sea realizada", "Ok");
        }
    }
}