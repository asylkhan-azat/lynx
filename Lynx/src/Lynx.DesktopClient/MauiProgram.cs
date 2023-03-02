﻿using Microsoft.Extensions.Logging;
using Lynx.Infrastructure.Extensions;
using Lynx.DesktopClient.ViewModels;
using Lynx.DesktopClient.Views;

namespace Lynx.DesktopClient;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        var services = builder.Services;

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        services.AddLibGit2SharpAdapters();
        services.AddSingleton<MainPageViewModel>();
        services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
