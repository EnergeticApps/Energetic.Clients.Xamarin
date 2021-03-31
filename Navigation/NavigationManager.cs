using Energetic.Clients.Navigation;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Energetic.Clients.Xamarin.Navigation
{
    /// <summary>
    /// TODO: Lots of methods to implement here to make this class work for Xamarin
    /// </summary>
    public class NavigationManager : NavigationManagerBase
    {

        public NavigationManager(IOptions<OidcProviderOptions> optionsAccessor) :
            base(optionsAccessor)
        {
        }

        public override string Location => throw new NotImplementedException();

        public override Task<bool> IsLoggedInAsync()
        {
            //TODO: implement this
            throw new NotImplementedException();
        }

        public override async Task NavigateExternalAsync(string url)
        {
            await Browser.OpenAsync(url);
        }

        public override async Task NavigateToLogInAsync()
        {
            string pattern = "{0}/account/login?returnUrl={1}";
            string returnUrl = Uri.EscapeDataString(Location);
            await NavigateExternalAsync(MakeAuthUrl(pattern, returnUrl));
        }

        public override async Task NavigateToLogOutAsync()
        {
            await NavigateExternalAsync(MakeAuthUrl("{0}/account/logout"));
        }

        public override async Task NavigateToManageAccountAsync()
        {
            await NavigateExternalAsync(MakeAuthUrl("{0}/connect/userinfo"));
        }


        /// <summary>
        /// Navigates to the page in the <paramref name="url"/>.
        /// </summary>
        /// <param name="url">A URL (relative or absolute) to the page you want the user to go to.</param>
        /// <remarks>
        /// To go to the root of the app, use double forward slash "//".
        /// To go up a level, use "../"
        /// </remarks>
        public override async Task NavigateToPageAsync(string url)
        {
            await Shell.Current.GoToAsync(url);
        }

        /// <summary>
        /// Navigates to the page in the <paramref name="url"/> passing the parameter <paramref name="parameterKey"/> with a
        /// value of <paramref name="parameterValue"/>.
        /// </summary>
        /// <param name="url">A URL (relative or absolute) to the page you want the user to go to.</param>
        /// <param name="parameterKey">The name of the parameter to pass in the URL query string.</param>
        /// <param name="parameterValue">The value of the parameter passed in the URL query string.</param>
        /// <remarks>
        /// To go to the root of the app, use double forward slash "//".
        /// To go up a level, use "../"
        /// </remarks>
        public override async Task NavigateToPageAsync(string url, string parameterKey, string parameterValue)
        {
            await Shell.Current.GoToAsync($"{url}?{parameterKey}={parameterValue}");
        }

        public override async Task NavigateToRegisterAsync()
        {
            await NavigateToLogInAsync(); // I think IdentityServer UI uses the same page for registering and logging in
        }
    }
}