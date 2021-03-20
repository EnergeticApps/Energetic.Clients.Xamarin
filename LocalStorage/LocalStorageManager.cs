using Energetic.Clients.LocalStorage;
using System;
using System.Threading.Tasks;

namespace Energetic.Clients.Xamarin.LocalStorage
{
    ///TODO: Implement this
    public class LocalStorageManager :ILocalStorageManager
    {
        public LocalStorageManager() { }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ValueTask ClearAsync()
        {
            throw new NotImplementedException();
        }

        public bool ContainKey(string key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> ContainKeyAsync(string key)
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(string key)
        {
            throw new NotImplementedException();
        }

        public string GetItemAsString(string key)
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

        public string Key(int index)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> KeyAsync(int index)
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> LengthAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(string key)
        {
            throw new NotImplementedException();
        }

        public ValueTask RemoveItemAsync(string key)
        {
            throw new NotImplementedException();
        }

        public void SetItem<T>(string key, T data)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetItemAsync<T>(string key, T data)
        {
            throw new NotImplementedException();
        }
    }
}
