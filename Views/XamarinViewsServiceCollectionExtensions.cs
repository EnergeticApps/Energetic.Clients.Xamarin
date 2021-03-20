using Energetic.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class XamarinViewsServiceCollectionExtensions
    {
        public static IServiceCollection AddViews(this IServiceCollection services, params Type[] assemblyMarkers)
        {
            var assemblies = assemblyMarkers.GetContainingAssemblies().ToArray();
            return services.AddViews(assemblies);
        }

        public static IServiceCollection AddViews(this IServiceCollection services, params Assembly[] assemblies)
        {
            if (assemblies.IsNullOrEmpty())
                throw new EnumerableArgumentEmptyException(nameof(assemblies));

            return services.Scan(scan => scan
            .FromAssemblies(assemblies)
            .AddClasses(classes => classes.AssignableTo<Page>())
            .AsSelf()
            .WithTransientLifetime());
        }
    }
}