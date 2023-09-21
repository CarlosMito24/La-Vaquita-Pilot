using Proyecto.Models;

namespace Proyecto.Paginas;

public partial class Productos : ContentPage
{
	public Productos()
	{
		InitializeComponent();

        List<Imagenes> imagenes1 = new List<Imagenes>
    {
        new Imagenes {NombreProducto ="Queso Duro Blando", CostoProducto ="Costo Libra: $ 3,80", ImagenProducto = "quesoduroblando.png"},
        new Imagenes {NombreProducto ="Queso Duro Viejo", CostoProducto ="Costo Libra: $ 6,00", ImagenProducto = "quesoduroviejo.png"},
        new Imagenes {NombreProducto ="Queso Rayado", CostoProducto ="Costo Libra: $ 3,80", ImagenProducto = "quesorayado.png"},
        new Imagenes {NombreProducto ="Quesillo", CostoProducto="Costo Libra: $ 2,60", ImagenProducto = "quesillo1.png" },
        new Imagenes {NombreProducto ="Queso Mozzarella", CostoProducto="Costo Libra: $ 2,95", ImagenProducto = "quesomozzarella.png" },
        new Imagenes {NombreProducto ="Queso Capita", CostoProducto="Costo Libra: $ 4,00",  ImagenProducto = "quesocapita.png" },
        new Imagenes {NombreProducto ="Queso Kraft",  CostoProducto="Costo Libra: $ 2,50",ImagenProducto = "quesokraft.png" },
        new Imagenes {NombreProducto ="Queso Parmesano", CostoProducto="Costo Libra: $ 5,50",  ImagenProducto = "quesoparmesano.png" },
        new Imagenes {NombreProducto ="Queso Fresco", CostoProducto="Costo Libra: $ 2,75", ImagenProducto = "quesofresco.png" },
    };

        List<Imagenes> imagenes2 = new List<Imagenes>
    {
        new Imagenes {NombreProducto="Queso Crema", CostoProducto="Costo: $ 1,62", ImagenProducto="quesocrema.png"},
        new Imagenes {NombreProducto="Queso Crema Con Loroco", CostoProducto="Costo: $ 1,62", ImagenProducto="quesocremaloroco.png"},
        new Imagenes {NombreProducto="Queso Crema Con Tocino", CostoProducto="Costo: $ 1,62", ImagenProducto="quesocrematocino.png"},
        new Imagenes {NombreProducto="Queso Crema Con Chile Chipotle", CostoProducto="Costo: $ 1,62", ImagenProducto="quesocremachilechipotle.png"},
    };

        List<Imagenes> imagenes3 = new List<Imagenes>
    {
        new Imagenes {NombreProducto="Crema de 95 G - 1/8 De Botella De Crema", CostoProducto="Costo: $ 0.30", ImagenProducto="cremacentavos.png"},
        new Imagenes {NombreProducto="Crema de 190 G - 1/4 De Botella De Crema", CostoProducto="Costo: $ 1,00", ImagenProducto="cuartodecrema.png"},
        new Imagenes {NombreProducto="Botella De Crema", CostoProducto="Costo: $ 3,00", ImagenProducto="botelladecrema.png"},
    };

        List<Imagenes> imagenes4 = new List<Imagenes>
    {
        new Imagenes {NombreProducto="Leche Entera De 473 ML", CostoProducto="Costo: $ 0,90", ImagenProducto="leche473ml.png"},
        new Imagenes {NombreProducto="Leche Entera De 750 ML", CostoProducto="Costo: $ 1.33", ImagenProducto="leche750ml.png"},
        new Imagenes {NombreProducto="Leche Entera De 900 ML", CostoProducto="Costo: $ 1,55", ImagenProducto="leche900ml.png"},
        new Imagenes {NombreProducto="Leche Entera Medio Galón", CostoProducto="Costo: $ 3.25", ImagenProducto="mediogalondeleche.png"},
        new Imagenes {NombreProducto="Leche Entera 1 Galón", CostoProducto="Costo: $ 6.10", ImagenProducto="galondeleche.png"},
    };

        CarouselView1.ItemsSource = imagenes1;
        CarouselView2.ItemsSource = imagenes2;
        CarouselView3.ItemsSource = imagenes3;
        CarouselView4.ItemsSource = imagenes4;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                myLabel.IsVisible = !myLabel.IsVisible; // Cambia la visibilidad del Label
            });

            return true; // Continúa el bucle
        });
    }
}