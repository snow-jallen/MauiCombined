using MauiCombined.Data;
using Microsoft.Extensions.Logging;
using RazorClassLib;

namespace MauiCombined;

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
            });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddSingleton<IDataService, MauiCombinedDataService>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}

public class MauiCombinedDataService : IDataService
{
    public Task<IEnumerable<string>> GetDataAsync()
    {
        return Task.FromResult<IEnumerable<string>>("This is from the MauiCombined app.".Split(" "));
    }
}
