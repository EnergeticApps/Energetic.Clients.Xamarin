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
        private readonly Shell _shell;

        public NavigationManager(Shell shell, IOptions<OidcProviderOptions> optionsAccessor) :
            base(optionsAccessor)
        {
            _shell = shell ?? throw new ArgumentNullException(nameof(shell));
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
            await NavigateToPageAsync(MakeAuthUrl(pattern, returnUrl));
        }

        public override async Task NavigateToLogOutAsync()
        {
            await NavigateToPageAsync(MakeAuthUrl("{0}/account/logout"));
        }

        public override async Task NavigateToManageAccountAsync()
        {
            await NavigateToPageAsync(MakeAuthUrl("{0}/connect/userinfo"));
        }

        public override async Task NavigateToPageAsync(string url)
        {
            await _shell.GoToAsync(url);
        }

        public override async Task NavigateToPageAsync(string url, string parameterKey, string parameterValue)
        {
            await _shell.GoToAsync($"{url}?{parameterKey}={parameterValue}");
        }

        public override async Task NavigateToRegisterAsync()
        {
            await NavigateToLogInAsync(); // I think IdentityServer UI uses the same page for registering and logging in
        }
    }
}