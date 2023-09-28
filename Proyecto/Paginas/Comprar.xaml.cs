using Proyecto.Models;
using Proyecto.Datos;

namespace Proyecto.Paginas;

[QueryProperty("Item", "Item")]

public partial class Comprar : ContentPage
{
    public Variables Item
    {
        get => BindingContext as Variables;
        set => BindingContext = value;
    }

    Data basededatos;

    public Comprar(Data data)
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
        QuesoKraft.IsVisible = !QuesoKraft.IsVisible;
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
            Item.orden1 = cantidad * quesoduroblando;

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
            Item.DetallesProducto1 = cantidad + " Libras de Queso Duro Blando";
            string subtotal1 = Item.orden1.ToString("0.00");
            Item.SubTotalProducto1 = "$ " + subtotal1;
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
            Item.orden2 = cantidad * quesoduroviejo;

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
            Item.DetallesProducto2 = cantidad + " Libras de Queso Duro Viejo";
            string subtotal2 = Item.orden2.ToString("0.00");
            Item.SubTotalProducto2 = "$ " + subtotal2;
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
            Item.orden3 = cantidad * quesorayado;

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
            Item.DetallesProducto3 = cantidad + " Libras de Queso Rayado";
            string subtotal3 = Item.orden3.ToString("0.00");
            Item.SubTotalProducto3 = "$ " + subtotal3;
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
            Item.orden4 = cantidad * quesillo;

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
            Item.DetallesProducto4 = cantidad + " Libras de Quesillo";
            string subtotal4 = Item.orden4.ToString("0.00");
            Item.SubTotalProducto4 = "$ " + subtotal4;
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
            Item.orden5 = cantidad * quesomozzarella;

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
            Item.DetallesProducto5 = cantidad + " Libras de Queso Mozarella";
            string subtotal5 = Item.orden5.ToString("0.00");
            Item.SubTotalProducto5 = "$ " + subtotal5;
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
            Item.orden6 = cantidad * quesocapita;

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
            Item.DetallesProducto6 = cantidad + " Libras de Queso Capita";
            string subtotal6 = Item.orden6.ToString("0.00");
            Item.SubTotalProducto6 = "$ " + subtotal6;

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
            Item.orden7 = cantidad * quesokraft;

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
            Item.DetallesProducto7 = cantidad + " Libras de Queso Kraft";
            string subtotal7 = Item.orden7.ToString("0.00");
            Item.SubTotalProducto7 = "$ " + subtotal7;
            if (Item.orden7 > 0)
            {
                LabelProducto7.IsVisible = true;
                LabelSubtotal7.IsVisible = true;
            }
            else
            {
                LabelProducto7.IsVisible = false;
                LabelSubtotal7.IsVisible = false;
            }
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
            Item.orden8 = cantidad * quesoparmesano;

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
            Item.DetallesProducto8 = cantidad + " Libras de Queso Parmesano";
            string subtotal8 = Item.orden8.ToString("0.00");
            Item.SubTotalProducto8 = "$ " + subtotal8;
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
            Item.orden9 = cantidad * quesofresco;

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
            Item.DetallesProducto9 = cantidad + " Libras de Queso Fresco";
            string subtotal9 = Item.orden9.ToString("0.00");
            Item.SubTotalProducto9 = "$ " + subtotal9;
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
            Item.orden10 = cantidad * quesocrema;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema", "Ok");
            Item.DetallesProducto10 = cantidad + " Unidades de Queso Crema";
            string subtotal10 = Item.orden10.ToString("0.00");
            Item.SubTotalProducto10 = "$ " + subtotal10;
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
            Item.orden11 = cantidad * quesocremaconloroco;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;

            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Loroco", "Ok");
            Item.DetallesProducto11 = cantidad + " Unidades de Queso Crema Con Loroco";
            string subtotal11 = Item.orden10.ToString("0.00");
            Item.SubTotalProducto11 = "$ " + subtotal11;
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
            Item.orden12 = cantidad * quesocremacontocino;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Tocino", "Ok");
            Item.DetallesProducto12 = cantidad + " Unidades de Queso Crema Con Tocino";
            string subtotal12 = Item.orden12.ToString("0.00");
            Item.SubTotalProducto12 = "$ " + subtotal12;
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
            Item.orden13 = cantidad * quesocremachilechipotle;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Chile Chipotle", "Ok");
            Item.DetallesProducto13 = cantidad + " Unidades de Queso Crema Con Chile Chipotle";
            string subtotal13 = Item.orden13.ToString("0.00");
            Item.SubTotalProducto13 = "$ " + subtotal13;
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
            Item.orden14 = cantidad * crema95g;

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Crema de 95G", "Ok");
            Item.DetallesProducto14 = cantidad + " Unidades de Crema de 95G";
            string subtotal14 = Item.orden14.ToString("0.00");
            Item.SubTotalProducto14 = "$ " + subtotal14;
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
            Item.orden15 = cantidad * crema190g;

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Crema de 190G", "Ok");
            Item.DetallesProducto15 = cantidad + " Unidades de Crema de 190G";
            string subtotal15 = Item.orden15.ToString("0.00");
            Item.SubTotalProducto15 = "$ " + subtotal15;
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
            Item.orden16 = cantidad * botelladecrema;

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Botellla de crema", "Ok");
            Item.DetallesProducto16 = cantidad + " Unidades de Botellla de crema";
            string subtotal16 = Item.orden16.ToString("0.00");
            Item.SubTotalProducto16 = "$ " + subtotal16;
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
            Item.orden17 = cantidad * leche473ml;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 473ML", "Ok");
            Item.DetallesProducto17 = cantidad + " Unidades de Leche Entera de 473ML";
            string subtotal17 = Item.orden17.ToString("0.00");
            Item.SubTotalProducto17 = "$ " + subtotal17;
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
            Item.orden18 = cantidad * leche750ml;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 750ML", "Ok");
            Item.DetallesProducto18 = cantidad + " Unidades de Leche Entera de 750ML";
            string subtotal18 = Item.orden18.ToString("0.00");
            Item.SubTotalProducto18 = "$ " + subtotal18;
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
            Item.orden19 = cantidad * leche900ml;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 900ML", "Ok");
            Item.DetallesProducto19 = cantidad + " Unidades de Leche Entera de 900ML";
            string subtotal19 = Item.orden19.ToString("0.00");
            Item.SubTotalProducto19 = "$ " + subtotal19;
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
            Item.orden20 = cantidad * lechemediogalon;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera Medio Galón", "Ok");
            Item.DetallesProducto20 = cantidad + " Unidades de Leche Entera Medio Galón";
            string subtotal20 = Item.orden20.ToString("0.00");
            Item.SubTotalProducto20 = "$ " + subtotal20;
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
            Item.orden21 = cantidad * lechegalon;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera Galón", "Ok");
            Item.DetallesProducto21 = cantidad + " Unidades de de Leche Entera Galón";
            string subtotal21 = Item.orden21.ToString("0.00");
            Item.SubTotalProducto21 = "$ " + subtotal21;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }


    private void AgregarClicked(object sender, EventArgs e)
    {
        Limpiar();
        DisplayAlert("Listo", "Ahora puedes agregar mas productos a tu compra", "Continuar");
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        string fecha;
        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // Asignar la fecha actual al Label
        fecha = fechaActual.ToString("dd/MM/yyyy");

        Item.total += Item.orden1 += Item.orden2 += Item.orden3 += Item.orden4 += Item.orden5 += Item.orden6
              += Item.orden7 += Item.orden8 += Item.orden9 += Item.orden10 += Item.orden11 += Item.orden12
              += Item.orden13 += Item.orden14 += Item.orden15 += Item.orden16 += Item.orden17 += Item.orden18
              += Item.orden19 += Item.orden20 += Item.orden21;

        string totalfinal = Item.total.ToString("0.00");
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
        Item.total = 0;
        Item.orden1 = 0;
        Item.orden2 = 0;
        Item.orden3 = 0;
        Item.orden4 = 0;
        Item.orden5 = 0;
        Item.orden6 = 0;
        Item.orden7 = 0;
        Item.orden8 = 0;
        Item.orden9 = 0;
        Item.orden10 = 0;
        Item.orden11 = 0;
        Item.orden12 = 0;
        Item.orden13 = 0;
        Item.orden14 = 0;
        Item.orden15 = 0;
        Item.orden16 = 0;
        Item.orden17 = 0;
        Item.orden18 = 0;
        Item.orden19 = 0;
        Item.orden20 = 0;
        Item.orden21 = 0;
    }

    async void OnBorrarClicked(object sender, EventArgs e)
    {
        if (Item.ID == 0)
            return;
        await basededatos.DeleteItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }
}