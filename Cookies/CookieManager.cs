using Energetic.Clients.Cookies;
using System;
using System.Threading.Tasks;

namespace Energetic.Clients.Xamarin.Cookies
{
    /// <summary>
    /// I know cookies are not used frequently in mobile apps, and are not much use from a tracking perspective because they are limited to
    /// the app, but they do still exist. So, for completeness, we have an implementation of ICookieService that we can fix up and use if needed.
    /// </summary>
    public class CookieManager : ICookieManager
    {
        public string CrmTrackingCookieName => throw new NotImplementedException();

        public ValueTask ClearAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> ContainsKeyAsync(string key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetItemAsStringAsync(string key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> GetItemAsync<T>(string key)
        {
            throw new NotImplementedException();
        }

        public ValueTask RemoveItemAsync(string key)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetItemAsync<T>(string key, T data, int expiryDays)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetItemAsync<T>(string key, T data, DateTimeOffset? expires = null)
        {
            throw new NotImplementedException();
        }
    }
}