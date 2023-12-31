﻿using Microsoft.Extensions.Logging;
using Proyecto.Datos;
using Proyecto.Paginas;

namespace Proyecto;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<Pedidos>();
        builder.Services.AddTransient<Comprar>();
        builder.Services.AddSingleton<Data>();
        return builder.Build();
	}
}