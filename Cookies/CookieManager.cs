using Energetic.Clients.Cookies;
using System;
using System.Threading.Tasks;

namespace Energetic.Clients.Xamarin.Cookies
{
    /// <summary>
    /// A cookie manager for Xamarin. 
    /// </summary>
    /// <remarks>Although cookies are not used frequently in mobile apps, and are not much use from a tracking perspective because they are limited to
    /// the app, but they do still exist. So, for completeness, we have an implementation of ICookieService that we can fix up and use if needed.</remarks>
    public class CookieManager : ICookieManager
    {
        /// <summary>
        /// Clears all our app's cookies for this user.
        /// </summary>
        public ValueTask ClearAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks to see if this user has any cookie identifiable by the name passed in the parameter <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The name of the cookie</param>
        /// <returns>True if a cookie exists by that name, otherwise false.</returns>
        public ValueTask<bool> ContainsKeyAsync(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value of the named cookie as a string.
        /// </summary>
        /// <param name="key">The name of the cookie.</param>
        /// <returns>The value of the cookie.</returns>
        public ValueTask<string?> GetItemAsStringAsync(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value of the named cookie cast to a type of <typeparamref name="T"/>.
        /// </summary>
        /// <param name="key">The name of the cookie.</param>
        /// <typeparam name="T">The type to which the cookies should be cast before it is returned.</typeparam>
        /// <returns>The value of the cookie.</returns>
        public ValueTask<T?> GetItemAsync<T>(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the cookie identified by the name passed in the argument <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The name of the cookie</param>
        /// <returns></returns>
        public ValueTask RemoveItemAsync(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a cookie of type <typeparamref name="T"/> with the name of <paramref name="key"/> and a value of
        /// <paramref name="data"/>, which will expire if it is still there after <paramref name="expiryDays"/> days.
        /// </summary>
        /// <typeparam name="T">The type of data to be stored in the cookie.</typeparam>
        /// <param name="key">The name of the cookie.</param>
        /// <param name="data">The value to be stored in the cookie.</param>
        /// <param name="expiryDays">The number of days after which the cookie will expire.</param>
        /// <returns></returns>
        public ValueTask SetItemAsync<T>(string key, T data, int expiryDays)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a cookie of type <typeparamref name="T"/> with the name of <paramref name="key"/> and a value of
        /// <paramref name="data"/>, which will expire if it is still there at <paramref name="expires"/>.
        /// </summary>
        /// <typeparam name="T">The type of data to be stored in the cookie.</typeparam>
        /// <param name="key">The name of the cookie.</param>
        /// <param name="data">The value to be stored in the cookie.</param>
        /// <param name="expires">The date and time at which the cookie should expire.</param>
        public ValueTask SetItemAsync<T>(string key, T data, DateTimeOffset? expires = null)
        {
            throw new NotImplementedException();
        }
    }
}