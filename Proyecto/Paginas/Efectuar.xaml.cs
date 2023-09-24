using Proyecto.Models;
using Proyecto.Datos;

namespace Proyecto.Paginas;

[QueryProperty("Item", "Item")]

public partial class Efectuar : ContentPage
{
    

    public Variables Item
    {
        get => BindingContext as Variables;
        set => BindingContext = value;
    }

    Data basededatos;

    public Efectuar(Data data)
    {
        InitializeComponent();
        basededatos = data;
    }

    private bool IsImage1 = true;
    private bool IsImage2 = true;
    private bool IsImage3 = true;
    private bool IsImage4 = true;
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

    private void PrimeraFlechaClicked(object sender, EventArgs e)
    {
        if (IsImage1)
        {
            PrimeraFlecha.Source = "flechaarriba.png";
        }
        else
        {
            PrimeraFlecha.Source = "flechaabajo.png";
        }
        IsImage1 = !IsImage1;

        QuesoDuroBlando.IsVisible = !QuesoDuroBlando.IsVisible;
        QuesoDuroViejo.IsVisible = !QuesoDuroViejo.IsVisible;
        QuesoRayado.IsVisible = !QuesoRayado.IsVisible;
        Quesillo.IsVisible = !Quesillo.IsVisible;
        QuesoMozzarella.IsVisible = !QuesoMozzarella.IsVisible;
        QuesoCapita.IsVisible = !QuesoCapita.IsVisible;
        QuesoKraft.IsVisible = QuesoKraft.IsVisible;
        QuesoParmesano.IsVisible = !QuesoParmesano.IsVisible;
        QuesoFresco.IsVisible = !QuesoFresco.IsVisible;
    }

    private void SegundaFlechaClicked(object sender, EventArgs e)
    {
        if (IsImage2)
        {
            SegundaFlecha.Source = "flechaarriba.png";
        }
        else
        {
            SegundaFlecha.Source = "flechaabajo.png";
        }
        IsImage2 = !IsImage2;

        QuesoCrema.IsVisible = !QuesoCrema.IsVisible;
        QuesoCremaLoroco.IsVisible = !QuesoCremaLoroco.IsVisible;
        QuesoCremaTocino.IsVisible = !QuesoCremaTocino.IsVisible;
        QuesoCremaConChileChipotle.IsVisible = !QuesoCremaConChileChipotle.IsVisible;
    }

    private void TerceraFlechaClicked(object sender, EventArgs e)
    {
        if (IsImage3)
        {
            TerceraFlecha.Source = "flechaarriba.png";
        }
        else
        {
            TerceraFlecha.Source = "flechaabajo.png";
        }
        IsImage3 = !IsImage3;

        Crema95G.IsVisible = !Crema95G.IsVisible;
        Crema190G.IsVisible = !Crema190G.IsVisible;
        BotellaDeCrema.IsVisible = !BotellaDeCrema.IsVisible;
    }

    private void CuartaFlechaClicked(object sender, EventArgs e)
    {
        if (IsImage4)
        {
            CuartaFlecha.Source = "flechaarriba.png";
        }
        else
        {
            CuartaFlecha.Source = "flechaabajo.png";
        }
        IsImage4 = !IsImage4;

        LecheEntera473ML.IsVisible = !LecheEntera473ML.IsVisible;
        LecheEntera750ML.IsVisible = !LecheEntera750ML.IsVisible;
        LecheEntera900ML.IsVisible = !LecheEntera900ML.IsVisible;
        LecheEnteraMedioGalon.IsVisible = !LecheEnteraMedioGalon.IsVisible;
        LecheEnteraGalon.IsVisible = !LecheEnteraGalon.IsVisible;
    }

    private void QuesoDuroBlandoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            orden1 = cantidad * quesoduroblando;

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Duro Blando", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Duro Viejo", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Rayado", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Quesillo", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Mozzarella", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Capita", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Kraft", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Parmesano", "Ok");
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

            QuesoDuroBlando.IsVisible = false;
            QuesoDuroViejo.IsVisible = false;
            QuesoRayado.IsVisible = false;
            Quesillo.IsVisible = false;
            QuesoMozzarella.IsVisible = false;
            QuesoCapita.IsVisible = false;
            QuesoKraft.IsVisible = false;
            QuesoParmesano.IsVisible = false;
            QuesoFresco.IsVisible = false;
            PrimeraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Libras de Queso Fresco", "Ok");
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

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema", "Ok");
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

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;

            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Loroco", "Ok");
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

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Tocino", "Ok");
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

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Chile Chipotle", "Ok");
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

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Crema de 95G", "Ok");
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

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Crema de 190G", "Ok");
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

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Botellla de crema", "Ok");
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

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 473ML", "Ok");
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

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 750ML", "Ok");
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

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 900ML", "Ok");
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

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera Medio Galón", "Ok");
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

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera Galón", "Ok");
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }


    private void AgregarClicked(object sender, EventArgs e)
    {
        Limpiar();
        Nuevo.Text = "Ahora puedes ingresar otra cantidad y seleccionar otro producto";
        Nuevo.IsVisible = true;
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        string fecha;
        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // Asignar la fecha actual al Label
        fecha = fechaActual.ToString("dd/MM/yyyy");

        total += orden1 += orden2 += orden3 += orden4 += orden5 += orden6
              += orden7 += orden8 += orden9 += orden10 += orden11 += orden12
              += orden13 += orden14 += orden15 += orden16 += orden17 += orden18
              += orden19 += orden20 += orden21;

        string totalfinal = total.ToString("0.00");
        Item.Total = totalfinal;
        Item.Fecha = fecha;

        if (string.IsNullOrWhiteSpace(Item.Nombre))
        {
            await DisplayAlert("Falta el del nombre del cliente", "Ingrese el nombre del cliente", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(Item.Apellido))
        {
            await DisplayAlert("Falta el del apellido del cliente", "Ingrese el apellido del cliente", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(Item.Teléfono))
        {
            await DisplayAlert("Falta el del teléfono del cliente", "Ingrese el teléfono del cliente", "OK");
            return;
        }

        await basededatos.SaveItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }
    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
        Borrar();
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
}