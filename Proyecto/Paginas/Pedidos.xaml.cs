using Proyecto.Models;
using Proyecto.Datos;
using System.Collections.ObjectModel;

namespace Proyecto.Paginas;

public partial class Pedidos : ContentPage
{
    Data basededatos;

    public ObservableCollection<Variables> Items { get; set; } = new();

    public Pedidos(Data data)
	{
		InitializeComponent();
        basededatos = data;
        BindingContext = this;
    }

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

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Efectuar), true, new Dictionary<string, object>
        {
            ["Item"] = new Variables()
        });
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Variables item)
            return;

        await Shell.Current.GoToAsync(nameof(Efectuar), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });
    }


}