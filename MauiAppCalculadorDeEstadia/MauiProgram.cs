﻿using Microsoft.Extensions.Logging;

namespace MauiAppCalculadorDeEstadia
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
                    fonts.AddFont("DancingScript-Regular.ttf", "DancingScriptRegular");
                    fonts.AddFont("DancingScript-Medium.ttf", "DancingScriptMedium");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
