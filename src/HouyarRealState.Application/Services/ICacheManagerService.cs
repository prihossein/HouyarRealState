namespace HouyarRealState.Application.Services
{
    public interface ICacheManagerService
    {
        Task<T> GetAsync<T>(string key,Func<Task<T>> func,int cacheTime);
        void Set(string key, object data, int cacheTime);
        void Remove(string key);

    }
}
