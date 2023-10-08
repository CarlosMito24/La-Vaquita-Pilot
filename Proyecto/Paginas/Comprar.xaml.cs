using Proyecto.Models;
using Proyecto.Datos;

namespace Proyecto.Paginas;

[QueryProperty("Item", "Item")]

public partial class Comprar : ContentPage
{
    /// <summary>
    /// conexion a clase de variables para guardar items 
    /// </summary>
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

    /// <summary>
    /// Declaracion de variables a usar 
    /// </summary>
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

    /// <summary>
    /// configuacion del primer boton para que aparezcan los botones de seleccionar productos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// configuracion del segundo boton para que aparezcan los botones de seleccionar productos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// configuracion del tercer boton para que aparezcan los botones de seleccionar productos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// configuracion del cuarto boton para que aparezcan los botones de seleccionar productos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// configuracion del boton para elegir queso duro blando
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoDuroBlandoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden1 = cantidad * quesoduroblando;

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
            string subtotal1 = Item.Orden1.ToString("0.00");
            Item.SubTotalProducto1 = "$ " + subtotal1;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// congiguracion del boton para elegir queso duro viejo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void QuesoDuroViejoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden2 = cantidad * quesoduroviejo;

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
            string subtotal2 = Item.Orden2.ToString("0.00");
            Item.SubTotalProducto2 = "$ " + subtotal2;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }


    /// <summary>
    /// configuracion del boton para elegir queso rayado
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoRayadoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden3 = cantidad * quesorayado;

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
            string subtotal3 = Item.Orden3.ToString("0.00");
            Item.SubTotalProducto3 = "$ " + subtotal3;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir quesillo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesilloClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden4 = cantidad * quesillo;

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
            string subtotal4 = Item.Orden4.ToString("0.00");
            Item.SubTotalProducto4 = "$ " + subtotal4;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso Mozzarella
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void QuesoMozzarellaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden5 = cantidad * quesomozzarella;

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
            string subtotal5 = Item.Orden5.ToString("0.00");
            Item.SubTotalProducto5 = "$ " + subtotal5;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso capita
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoCapitaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden6 = cantidad * quesocapita;

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
            string subtotal6 = Item.Orden6.ToString("0.00");
            Item.SubTotalProducto6 = "$ " + subtotal6;

        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso kraft
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoKraftClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden7 = cantidad * quesokraft;

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
            string subtotal7 = Item.Orden7.ToString("0.00");
            Item.SubTotalProducto7 = "$ " + subtotal7;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }
    /// <summary>
    /// configuracion del boton para elegir queso parmesano
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void QuesoParmesanoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden8 = cantidad * quesoparmesano;

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
            string subtotal8 = Item.Orden8.ToString("0.00");
            Item.SubTotalProducto8 = "$ " + subtotal8;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso fresco
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoFrescoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden9 = cantidad * quesofresco;

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
            string subtotal9 = Item.Orden9.ToString("0.00");
            Item.SubTotalProducto9 = "$ " + subtotal9;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso crema
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoCremaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden10 = cantidad * quesocrema;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema", "Ok");
            Item.DetallesProducto10 = cantidad + " Unidades de Queso Crema";
            string subtotal10 = Item.Orden10.ToString("0.00");
            Item.SubTotalProducto10 = "$ " + subtotal10;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso crema con loroco
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoCremaConLorocoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden11 = cantidad * quesocremaconloroco;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;

            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Loroco", "Ok");
            Item.DetallesProducto11 = cantidad + " Unidades de Queso Crema Con Loroco";
            string subtotal11 = Item.Orden11.ToString("0.00");
            Item.SubTotalProducto11 = "$ " + subtotal11;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso crema con tocino
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void QuesoCremaConTocinoClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden12 = cantidad * quesocremacontocino;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Tocino", "Ok");
            Item.DetallesProducto12 = cantidad + " Unidades de Queso Crema Con Tocino";
            string subtotal12 = Item.Orden12.ToString("0.00");
            Item.SubTotalProducto12 = "$ " + subtotal12;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir queso crema con chipotle 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuesoCremaConChileChipotleClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden13 = cantidad * quesocremachilechipotle;

            QuesoCrema.IsVisible = false;
            QuesoCremaLoroco.IsVisible = false;
            QuesoCremaTocino.IsVisible = false;
            QuesoCremaConChileChipotle.IsVisible = false;
            SegundaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Queso Crema Con Chile Chipotle", "Ok");
            Item.DetallesProducto13 = cantidad + " Unidades de Queso Crema Con Chile Chipotle";
            string subtotal13 = Item.Orden13.ToString("0.00");
            Item.SubTotalProducto13 = "$ " + subtotal13;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir crema 95 G
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Crema95GClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden14 = cantidad * crema95g;

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Crema de 95G", "Ok");
            Item.DetallesProducto14 = cantidad + " Unidades de Crema de 95G";
            string subtotal14 = Item.Orden14.ToString("0.00");
            Item.SubTotalProducto14 = "$ " + subtotal14;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir crema 190 G
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Crema190GClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden15 = cantidad * crema190g;

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Crema de 190G", "Ok");
            Item.DetallesProducto15 = cantidad + " Unidades de Crema de 190G";
            string subtotal15 = Item.Orden15.ToString("0.00");
            Item.SubTotalProducto15 = "$ " + subtotal15;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir botella de crema
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BotellaDeCremaClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden16 = cantidad * botelladecrema;

            Crema95G.IsVisible = false;
            Crema190G.IsVisible = false;
            BotellaDeCrema.IsVisible = false;
            TerceraFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Botellla de crema", "Ok");
            Item.DetallesProducto16 = cantidad + " Unidades de Botellla de crema";
            string subtotal16 = Item.Orden16.ToString("0.00");
            Item.SubTotalProducto16 = "$ " + subtotal16;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir leche 473 ML
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Leche473Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden17 = cantidad * leche473ml;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 473ML", "Ok");
            Item.DetallesProducto17 = cantidad + " Unidades de Leche Entera de 473ML";
            string subtotal17 = Item.Orden17.ToString("0.00");
            Item.SubTotalProducto17 = "$ " + subtotal17;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }
    /// <summary>
    /// configuracion del boton para elegir leche 750 ML
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void Leche750Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden18 = cantidad * leche750ml;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 750ML", "Ok");
            Item.DetallesProducto18 = cantidad + " Unidades de Leche Entera de 750ML";
            string subtotal18 = Item.Orden18.ToString("0.00");
            Item.SubTotalProducto18 = "$ " + subtotal18;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir leche 900 ML
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Leche900Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden19 = cantidad * leche900ml;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera de 900ML", "Ok");
            Item.DetallesProducto19 = cantidad + " Unidades de Leche Entera de 900ML";
            string subtotal19 = Item.Orden19.ToString("0.00");
            Item.SubTotalProducto19 = "$ " + subtotal19;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir Leche entera de medio galon
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MedioGalonClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden20 = cantidad * lechemediogalon;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera Medio Galón", "Ok");
            Item.DetallesProducto20 = cantidad + " Unidades de Leche Entera Medio Galón";
            string subtotal20 = Item.Orden20.ToString("0.00");
            Item.SubTotalProducto20 = "$ " + subtotal20;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para elegir leche entera galon
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GalonClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Cantidad.Text, out double cantidad) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            Item.Orden21 = cantidad * lechegalon;

            LecheEntera473ML.IsVisible = false;
            LecheEntera750ML.IsVisible = false;
            LecheEntera900ML.IsVisible = false;
            LecheEnteraMedioGalon.IsVisible = false;
            LecheEnteraGalon.IsVisible = false;
            CuartaFlecha.Source = "flechaabajo.png";

            DisplayAlert("Producto Agregado", "Se Agregó " + cantidad + " Unidades de Leche Entera Galón", "Ok");
            Item.DetallesProducto21 = cantidad + " Unidades de de Leche Entera Galón";
            string subtotal21 = Item.Orden21.ToString("0.00");
            Item.SubTotalProducto21 = "$ " + subtotal21;
        }
        else
        {
            DisplayAlert("Error", "Primero indica una cantidad", "Ok");
        }
    }

    /// <summary>
    /// configuracion del boton para agregar productos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AgregarClicked(object sender, EventArgs e)
    {
        Limpiar();
        DisplayAlert("Listo", "Ahora puedes agregar mas productos a tu compra", "Continuar");
    }


    /// <summary>
    /// Configuración del botón que guarda la compra en la base de datos local
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void OnSaveClicked(object sender, EventArgs e)
    {
        string fecha;
        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // Asignar la fecha actual al Label
        fecha = fechaActual.ToString("dd/MM/yyyy");

        Item.Total1 = (Item.Orden1) + (Item.Orden2) + (Item.Orden3) + (Item.Orden4) + (Item.Orden5) + (Item.Orden6)
              + (Item.Orden7) + (Item.Orden8) + (Item.Orden9) + (Item.Orden10) + (Item.Orden11) + (Item.Orden12)
              + (Item.Orden13) + (Item.Orden14) + (Item.Orden15) + (Item.Orden16) + (Item.Orden17) + (Item.Orden18)
              + (Item.Orden19) + (Item.Orden20) + (Item.Orden21);

        string totalfinal = Item.Total1.ToString("0.00");
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

        if (Item.Total1 == 0)
        {
            await DisplayAlert("Advertencia", "No ha ingresado ningún producto, primero ingrese al menos un producto para poder guardar su pedido", "Continuar");
            return;
        }

        await basededatos.SaveItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    /// <summary>
    /// Configuración del botón Cancelar o ir atrás 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
        Borrar();
    }

    /// <summary>
    /// Se declara un método limpiar
    /// </summary>
    public void Limpiar()
    {
        Cantidad.Text = string.Empty;
    }

    /// <summary>
    /// Se declara un método Borrar
    /// </summary>
    public void Borrar()
    {
        Item.Total1 = 0;
        Item.Orden1 = 0;
        Item.Orden2 = 0;
        Item.Orden3 = 0;
        Item.Orden4 = 0;
        Item.Orden5 = 0;
        Item.Orden6 = 0;
        Item.Orden7 = 0;
        Item.Orden8 = 0;
        Item.Orden9 = 0;
        Item.Orden10 = 0;
        Item.Orden11 = 0;
        Item.Orden12 = 0;
        Item.Orden13 = 0;
        Item.Orden14 = 0;
        Item.Orden15 = 0;
        Item.Orden16 = 0;
        Item.Orden17 = 0;
        Item.Orden18 = 0;
        Item.Orden19 = 0;
        Item.Orden20 = 0;
        Item.Orden21 = 0;
    }

    /// <summary>
    /// Configuración del botón Borrar
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void OnBorrarClicked(object sender, EventArgs e)
    {
        if (Item.ID == 0)
            return;
        await basededatos.DeleteItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    /// <summary>
    /// Configuración del botón que sirve para mostrar los detalles de la orden 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MostrarDetallesClicked (object sender, EventArgs e)
    {
        if (Item.Orden1 == 0)
        {
            LabelProducto1.IsVisible = false;
            LabelSubtotal1.IsVisible = false;
            QuitarProducto1.IsVisible = false;
        }
        else
        {
            LabelProducto1.IsVisible = true;
            LabelSubtotal1.IsVisible = true;
            QuitarProducto1.IsVisible = true;
        }

        if (Item.Orden2 == 0)
        {
            LabelProducto2.IsVisible = false;
            LabelSubtotal2.IsVisible = false;
            QuitarProducto2.IsVisible = false;
        }
        else
        {
            LabelProducto2.IsVisible = true;
            LabelSubtotal2.IsVisible = true;
            QuitarProducto2.IsVisible = true;
        }

        if (Item.Orden3 == 0)
        {
            LabelProducto3.IsVisible = false;
            LabelSubtotal3.IsVisible = false;
            QuitarProducto3.IsVisible = false;
        }
        else
        {
            LabelProducto3.IsVisible = true;
            LabelSubtotal3.IsVisible = true;
            QuitarProducto3.IsVisible = true;
        }

        if (Item.Orden4 == 0)
        {
            LabelProducto4.IsVisible = false;
            LabelSubtotal4.IsVisible = false;
            QuitarProducto4.IsVisible = false;
        }
        else
        {
            LabelProducto4.IsVisible = true;
            LabelSubtotal4.IsVisible = true;
            QuitarProducto4.IsVisible = true;
        }

        if (Item.Orden5 == 0)
        {
            LabelProducto5.IsVisible = false;
            LabelSubtotal5.IsVisible = false;
            QuitarProducto5.IsVisible = false;
        }
        else
        {
            LabelProducto5.IsVisible = true;
            LabelSubtotal5.IsVisible = true;
            QuitarProducto5.IsVisible = true;
        }

        if (Item.Orden6 == 0)
        {
            LabelProducto6.IsVisible = false;
            LabelSubtotal6.IsVisible = false;
            QuitarProducto6.IsVisible = false;
        }
        else
        {
            LabelProducto6.IsVisible = true;
            LabelSubtotal6.IsVisible = true;
            QuitarProducto6.IsVisible = true;
        }

        if (Item.Orden7 == 0)
        {
            LabelProducto7.IsVisible = false;
            LabelSubtotal7.IsVisible = false;
            QuitarProducto7.IsVisible = false;
        }
        else
        {
            LabelProducto7.IsVisible = true;
            LabelSubtotal7.IsVisible = true;
            QuitarProducto7.IsVisible = true;
        }

        if (Item.Orden8 == 0)
        {
            LabelProducto8.IsVisible = false;
            LabelSubtotal8.IsVisible = false;
            QuitarProducto8.IsVisible = false;
        }
        else
        {
            LabelProducto8.IsVisible = true;
            LabelSubtotal8.IsVisible = true;
            QuitarProducto8.IsVisible = true;
        }

        if (Item.Orden9 == 0)
        {
            LabelProducto9.IsVisible = false;
            LabelSubtotal9.IsVisible = false;
            QuitarProducto9.IsVisible = false;
        }
        else
        {
            LabelProducto9.IsVisible = true;
            LabelSubtotal9.IsVisible = true;
            QuitarProducto9.IsVisible = true;
        }

        if (Item.Orden10 == 0)
        {
            LabelProducto10.IsVisible = false;
            LabelSubtotal10.IsVisible = false;
            QuitarProducto10.IsVisible = false;
        }
        else
        {
            LabelProducto10.IsVisible = true;
            LabelSubtotal10.IsVisible = true;
            QuitarProducto10.IsVisible = true;
        }

        if (Item.Orden11 == 0)
        {
            LabelProducto11.IsVisible = false;
            LabelSubtotal11.IsVisible = false;
            QuitarProducto11.IsVisible = false;
        }
        else
        {
            LabelProducto11.IsVisible = true;
            LabelSubtotal11.IsVisible = true;
            QuitarProducto11.IsVisible = true;
        }

        if (Item.Orden12 == 0)
        {
            LabelProducto12.IsVisible = false;
            LabelSubtotal12.IsVisible = false;
            QuitarProducto12.IsVisible = false;
        }
        else
        {
            LabelProducto12.IsVisible = true;
            LabelSubtotal12.IsVisible = true;
            QuitarProducto12.IsVisible = true;
        }

        if (Item.Orden13 == 0)
        {
            LabelProducto13.IsVisible = false;
            LabelSubtotal13.IsVisible = false;
            QuitarProducto13.IsVisible = false;
        }
        else
        {
            LabelProducto13.IsVisible = true;
            LabelSubtotal13.IsVisible = true;
            QuitarProducto13.IsVisible = true;
        }

        if (Item.Orden14 == 0)
        {
            LabelProducto14.IsVisible = false;
            LabelSubtotal14.IsVisible = false;
            QuitarProducto14.IsVisible = false;
        }
        else
        {
            LabelProducto14.IsVisible = true;
            LabelSubtotal14.IsVisible = true;
            QuitarProducto14.IsVisible = true;
        }

        if (Item.Orden15 == 0)
        {
            LabelProducto15.IsVisible = false;
            LabelSubtotal15.IsVisible = false;
            QuitarProducto15.IsVisible = false;
        }
        else
        {
            LabelProducto15.IsVisible = true;
            LabelSubtotal15.IsVisible = true;
            QuitarProducto15.IsVisible = true;
        }

        if (Item.Orden16 == 0)
        {
            LabelProducto16.IsVisible = false;
            LabelSubtotal16.IsVisible = false;
            QuitarProducto16.IsVisible = false;
        }
        else
        {
            LabelProducto16.IsVisible = true;
            LabelSubtotal16.IsVisible = true;
            QuitarProducto16.IsVisible = true;
        }

        if (Item.Orden17 == 0)
        {
            LabelProducto17.IsVisible = false;
            LabelSubtotal17.IsVisible = false;
            QuitarProducto17.IsVisible = false;
        }
        else
        {
            LabelProducto17.IsVisible = true;
            LabelSubtotal17.IsVisible = true;
            QuitarProducto17.IsVisible= true;
        }

        if (Item.Orden18 == 0)
        {
            LabelProducto18.IsVisible = false;
            LabelSubtotal18.IsVisible = false;
            QuitarProducto18.IsVisible = false;
        }
        else
        {
            LabelProducto18.IsVisible = true;
            LabelSubtotal18.IsVisible = true;
            QuitarProducto18.IsVisible = true;
        }

        if (Item.Orden19 == 0)
        {
            LabelProducto19.IsVisible = false;
            LabelSubtotal19.IsVisible = false;
            QuitarProducto19.IsVisible = false;
        }
        else
        {
            LabelProducto19.IsVisible = true;
            LabelSubtotal19.IsVisible = true;
            QuitarProducto19.IsVisible = true;
        }

        if (Item.Orden20 == 0)
        {
            LabelProducto20.IsVisible = false;
            LabelSubtotal20.IsVisible = false;
            QuitarProducto20.IsVisible = false;
        }
        else
        {
            LabelProducto20.IsVisible = true;
            LabelSubtotal20.IsVisible = true;
            QuitarProducto20.IsVisible = true;
        }

        if (Item.Orden21 == 0)
        {
            LabelProducto21.IsVisible = false;
            LabelSubtotal21.IsVisible = false;
            QuitarProducto21.IsVisible = false;
        }
        else
        {
            LabelProducto21.IsVisible = true;
            LabelSubtotal21.IsVisible = true;
            QuitarProducto21.IsVisible = true;
        }

        LabelMostrarTotalDetalles.Text = "$ " + Item.Total;
        LabelMostrarTotalDetalles.IsVisible = true;
        LabelTotalDetalles.IsVisible = true;
    }

    /// <summary>
    /// Elimina el producto 1 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto1Clicked (object sender, EventArgs e)
    {
        LabelProducto1.IsVisible = false;
        LabelSubtotal1.IsVisible = false;
        QuitarProducto1.IsVisible = false;
        Item.Orden1 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 2 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto2Clicked (Object sender, EventArgs e)
    {
        LabelProducto2.IsVisible = false;
        LabelSubtotal2.IsVisible = false;
        QuitarProducto2.IsVisible = false;
        Item.Orden2 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 3 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto3Clicked(Object sender, EventArgs e)
    {
        LabelProducto3.IsVisible = false;
        LabelSubtotal3.IsVisible = false;
        QuitarProducto3.IsVisible = false;
        Item.Orden3 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 4 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto4Clicked(Object sender, EventArgs e)
    {
        LabelProducto4.IsVisible = false;
        LabelSubtotal4.IsVisible = false;
        QuitarProducto4.IsVisible = false;
        Item.Orden4 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 5 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto5Clicked(Object sender, EventArgs e)
    {
        LabelProducto5.IsVisible = false;
        LabelSubtotal5.IsVisible = false;
        QuitarProducto5.IsVisible = false;
        Item.Orden5 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 6 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto6Clicked(Object sender, EventArgs e)
    {
        LabelProducto6.IsVisible = false;
        LabelSubtotal6.IsVisible = false;
        QuitarProducto6.IsVisible = false;
        Item.Orden6 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 7 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto7Clicked(object sender, EventArgs e)
    {
        LabelProducto7.IsVisible = false;
        LabelSubtotal7.IsVisible = false;
        QuitarProducto7.IsVisible = false;
        Item.Orden7 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 8 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto8Clicked(object sender, EventArgs e)
    {
        LabelProducto8.IsVisible = false;
        LabelSubtotal8.IsVisible = false;
        QuitarProducto8.IsVisible = false;
        Item.Orden8 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 9 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto9Clicked (object sender, EventArgs e)
    {
        LabelProducto9.IsVisible = false;
        LabelSubtotal9.IsVisible = false;
        QuitarProducto9.IsVisible = false;
        Item.Orden9 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 10 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto10Clicked(object sender, EventArgs e)
    {
        LabelProducto10.IsVisible = false;
        LabelSubtotal10.IsVisible = false;
        QuitarProducto10.IsVisible = false;
        Item.Orden10 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 11 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto11Clicked(object sender, EventArgs e)
    {
        LabelProducto11.IsVisible = false;
        LabelSubtotal11.IsVisible = false;
        QuitarProducto11.IsVisible = false;
        Item.Orden11 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 12 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto12Clicked(object sender, EventArgs e)
    {
        LabelProducto12.IsVisible = false;
        LabelSubtotal12.IsVisible = false;
        QuitarProducto12.IsVisible = false;
        Item.Orden12 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 13 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto13Clicked(object sender, EventArgs e)
    {
        LabelProducto13.IsVisible = false;
        LabelSubtotal13.IsVisible = false;
        QuitarProducto13.IsVisible = false;
        Item.Orden13 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 14 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto14Clicked(object sender, EventArgs e)
    {
        LabelProducto14.IsVisible = false;
        LabelSubtotal14.IsVisible = false;
        QuitarProducto14.IsVisible = false;
        Item.Orden14 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 15 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto15Clicked(object sender, EventArgs e)
    {
        LabelProducto15.IsVisible = false;
        LabelSubtotal15.IsVisible = false;
        QuitarProducto15.IsVisible = false;
        Item.Orden15 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 16 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto16Clicked(object sender, EventArgs e)
    {
        LabelProducto16.IsVisible = false;
        LabelSubtotal16.IsVisible = false;
        QuitarProducto16.IsVisible = false;
        Item.Orden16 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 17 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto17Clicked(object sender, EventArgs e)
    {
        LabelProducto17.IsVisible = false;
        LabelSubtotal17.IsVisible = false;
        QuitarProducto17.IsVisible = false;
        Item.Orden17 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 18 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto18Clicked(object sender, EventArgs e)
    {
        LabelProducto18.IsVisible = false;
        LabelSubtotal18.IsVisible = false;
        QuitarProducto18.IsVisible = false;
        Item.Orden18 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 19 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto19Clicked(object sender, EventArgs e)
    {
        LabelProducto19.IsVisible = false;
        LabelSubtotal19.IsVisible = false;
        QuitarProducto19.IsVisible = false;
        Item.Orden19 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 20 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto20Clicked(object sender, EventArgs e)
    {
        LabelProducto20.IsVisible = false;
        LabelSubtotal20.IsVisible = false;
        QuitarProducto20.IsVisible = false;
        Item.Orden20 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }

    /// <summary>
    /// Elimina el producto 21 de la orden
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void QuitarProducto21Clicked(object sender, EventArgs e)
    {
        LabelProducto21.IsVisible = false;
        LabelSubtotal21.IsVisible = false;
        QuitarProducto21.IsVisible = false;
        Item.Orden21 = 0;
        DisplayAlert("Producto eliminado", "Se eliminó el producto", "Continuar");
    }
}