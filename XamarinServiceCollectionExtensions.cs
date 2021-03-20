using Energetic.Clients.Cookies;
using Energetic.Clients.LocalStorage;
using Energetic.Clients.Navigation;
using Energetic.Clients.ViewModels;
using Energetic.Clients.Xamarin.Cookies;
using Energetic.Clients.Xamarin.LocalStorage;
using Energetic.Clients.Xamarin.Navigation;
using Energetic.Clients.Xamarin.ViewModels;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class XamarinServiceCollectionExtensions
    {
        public static IServiceCollection AddXamarinClientServices(this IServiceCollection services)
        {
            return services
                .AddScoped<ICookieManager, CookieManager>()
                .AddScoped<ILocalStorageManager, LocalStorageManager>()
                .AddScoped<INavigationManager, NavigationManager>()
                .AddScoped<ICommandFactory, CommandFactory>();
        }
    }
}