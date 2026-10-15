using HouyarRealState.Application.Services;
using Microsoft.Extensions.Caching.Memory;

namespace HouyarRealState.Infrastructure.Services
{
    public class CacheManagerService : ICacheManagerService
    {
        private readonly IMemoryCache _memoryChache;
        public CacheManagerService(IMemoryCache memoryChache)
        {
            _memoryChache = memoryChache;
        }

        public async Task<T> GetAsync<T>(string key, Func<Task<T>> func, int cacheTime)
        {
            if (_memoryChache.TryGetValue(key, out T value))
            {
                return value;
            }

            var result = await func();
            Set(key, result, cacheTime);
            return result;
        }

        public void Remove(string key)
        {
            _memoryChache.Remove(key);
        }

        public void Set(string key, object data, int cacheTime)
        {
            if (data != null)
            {
                _memoryChache.Set(key, data, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(cacheTime)
                });
            }
        }
    }
}
