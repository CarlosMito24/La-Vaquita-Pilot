﻿using Proyecto.Paginas;

namespace Proyecto;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Efectuar), typeof(Efectuar));
    }
}
