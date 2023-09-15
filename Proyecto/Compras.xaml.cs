using Microsoft.Maui.Controls;

namespace Proyecto;

public partial class Compras : ContentPage
{
	public Compras()
	{
		InitializeComponent();
	}

    double quesoduroblando = 3.80;
    double quesoduroviejo = 6.00;
    double quesorayado = 3.80;
    double quesillo = 2.60;
    double quesomozzarella = 2.95;
    double quesocapita = 4.00;
    double quesokraft = 2.50;
    double quesoparmesano = 5.50;
    double quesofresco = 2.75;
    double quesocrema = 1.62;
    double quesocremaconloroco = 1.62;
    double quesocremacontocino = 1.62;
    double quesocremachilechipotle = 1.62;
    double crema95g = 0.30;
    double crema190g = 1.00;
    double botelladecrema = 3.00;
    double leche473ml = 0.90;
    double leche750ml = 1.33;
    double leche900ml = 1.55;
    double lechemediogalon = 3.25;
    double lechegalon = 6.10;
    double total = 0;
    double orden1;
    double orden2;
    double orden3;
    double orden4;
    double orden5;
    double orden6;
    double orden7;
    double orden8;
    double orden9;
    double orden10;
    double orden11;
    double orden12;
    double orden13;
    double orden14;
    double orden15;
    double orden16;
    double orden17;
    double orden18;
    double orden19;
    double orden20;
    double orden21;

    private void PrimeraFlechaClicked (object sender, EventArgs e)
    {
        QuesoDuroBlando.IsVisible = true;
        QuesoDuroViejo.IsVisible = true;
        QuesoRayado.IsVisible = true;
        Quesillo.IsVisible = true;
        QuesoMozzarella.IsVisible = true;
        QuesoCapita.IsVisible = true;
        QuesoKraft.IsVisible = true;
        QuesoParmesano.IsVisible = true;
        QuesoFresco.IsVisible = true;

    }

    private void SegundaFlechaClicked(object sender, EventArgs e)
    {

    }

    private void TerceraFlechaClicked(object sender, EventArgs e)
    {

    }

    private void CuartaFlechaClicked(object sender, EventArgs e)
    {

    }

    private void QuesoDuroBlandoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden1 = cantidad * quesoduroblando;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoDuroViejoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden2 = cantidad * quesoduroviejo;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoRayadoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden3 = cantidad * quesorayado;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesilloClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden4 = cantidad * quesillo;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoMozzarellaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden5 = cantidad * quesomozzarella;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoCapitaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden6 = cantidad * quesocapita;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoKraftClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden7 = cantidad * quesokraft;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoParmesanoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden8 = cantidad * quesoparmesano;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoFrescoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden9 = cantidad * quesofresco;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoCremaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden10 = cantidad * quesocrema;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoCremaConLorocoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden11 = cantidad * quesocremaconloroco;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoCremaConTocinoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden12 = cantidad * quesocremacontocino;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void QuesoCremaConChileChipotleClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden13 = cantidad * quesocremachilechipotle;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void Crema95GClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden14 = cantidad * crema95g;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void Crema190GClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden15 = cantidad * crema190g;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void BotellaDeCremaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden16 = cantidad * botelladecrema;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void Leche473Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden17 = cantidad * leche473ml;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void Leche750Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden18 = cantidad * leche750ml;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void Leche900Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden19 = cantidad * leche900ml;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void MedioGalonClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden20 = cantidad * lechemediogalon;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    private void GalonClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden21 = cantidad * lechegalon;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    public void Limpiar()
    {
        Cantidad.Text = string.Empty;
    }

    public void Borrar()
    {
        total = 0;
        orden1 = 0;
        orden2 = 0;
        orden3 = 0;
        orden4 = 0;
        orden5 = 0;
        orden6 = 0;
        orden7 = 0;
        orden8 = 0;
        orden9 = 0;
        orden10 = 0;
        orden11 = 0;
        orden12 = 0;
        orden13 = 0;
        orden14 = 0;
        orden15 = 0;
        orden16 = 0;
        orden17 = 0;
        orden18 = 0;
        orden19 = 0;
        orden20 = 0;
        orden21 = 0;
        Nuevo.IsVisible = false;
    }

    private void AgregarClicked(object sender, EventArgs e)
    {
        Limpiar();
        Nuevo.Text = "Ahora puedes ingresar otra cantidad y seleccionar otro producto";
        Nuevo.IsVisible = true;
    }

    private void RegistrarCompraClicked(object sender, EventArgs e)
    {
        total += orden1 += orden2 += orden3 += orden4 += orden5 += orden6
              += orden7 += orden8 += orden9 += orden10 += orden11 += orden12
              += orden13 += orden14 += orden15 += orden16 += orden17 += orden18
              += orden19 += orden20 += orden21;

        if (total > 0)
        {
            Navigation.PushAsync(new Registrar(this, total));
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
        }
    }
}