using MapboxMaui;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public static class MauiProgram
{
    public static string ACCESS_TOKEN = "pk.eyJ1IjoiYndpbmtsZXNreSIsImEiOiJjanlveGg0M2gwMnN1M21xdHVrcDMxeHluIn0.v7h89PF-OFLLQxD_sRling";
    
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMapbox(ACCESS_TOKEN)
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}