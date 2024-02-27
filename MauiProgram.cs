using Microsoft.Extensions.Logging;
using Gerocery.ViewModels;
using Gerocery.Services;
using Gerocery.data;
using Firebase.Auth;
using Firebase.Auth.Providers;

namespace Gerocery
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
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "fontawsome");
                });

#if DEBUG
		builder.Logging.AddDebug();

#endif
            builder.Services.AddSingleton<SelectedPage>();
            builder.Services.AddSingleton<Login>();
            builder.Services.AddScoped<LoginViewModel>();

            builder.Services.AddScoped<SelectPageViewModel>();
            builder.Services.AddScoped < IGeneric<Category2>,ItemServices>() ;
            builder.Services.AddScoped<IGeneric<OrderData>, OrderService>();

            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyBw86lHro7leNjNCY4PNfZLEEDiuwWHKms",
                AuthDomain= "gerocery-890c3.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            }

                )) ;

            return builder.Build();
        }

    }
}