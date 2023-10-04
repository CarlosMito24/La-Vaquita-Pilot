using Proyecto.Models;
using Proyecto.Datos;
using System.Collections.ObjectModel;

namespace Proyecto.Paginas;

public partial class Pedidos : ContentPage
{
    /// <summary>
    /// Variable que se conectará a la clase Data
    /// </summary>
    Data basededatos;


    /// <summary>
    /// Revisa si hay una base de datos creada, sino crea una
    /// </summary>
    public ObservableCollection<Variables> Items { get; set; } = new();

    public Pedidos(Data data)
	{
		InitializeComponent();
        basededatos = data;
        BindingContext = this;
    }

    /// <summary>
    /// Guarda los items en la base de datos
    /// </summary>
    /// <param name="args"></param>
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var items = await basededatos.GetItemsAsync();
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Items.Clear();
            foreach (var item in items)
                Items.Add(item);
        });
    }

    /// <summary>
    /// SE  configura el botón para añadir pedidos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Comprar), true, new Dictionary<string, object>
        {
            ["Item"] = new Variables()
        });
    }

    /// <summary>
    /// Se configura la opción de poder seleccionar un pedido ya creado
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Variables item)
            return;

        await Shell.Current.GoToAsync(nameof(Comprar), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });
    }
}