using Microsoft.Extensions.Logging;

namespace MauiAppAnimeFast
{
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
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("LuckiestGuy-Regular.ttf", "LuckiestGuyRegular");
                    fonts.AddFont("Playfair_144pt-BoldItalic.ttf", "PlayfairItalic");
                    fonts.AddFont("RubikMoonrocks-Regular.ttf", "RubikMoonrocks.ttf");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
