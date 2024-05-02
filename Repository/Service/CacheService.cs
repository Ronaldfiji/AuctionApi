using Repository.Contracts;
using System.Text.Json;



namespace Repository.Service
{
    public class CacheService : ICacheService
    {
        private StackExchange.Redis.IDatabase _cacheDb;

        public CacheService()
        {
            ConfigureRedis();
        }
        private void ConfigureRedis()
        {
            _cacheDb = RedisConnectionHelper.Connection.GetDatabase();
        }
        public T GetData<T>(string key)
        {
            var value = _cacheDb.StringGet(key);

            if (!string.IsNullOrEmpty(value))
            {
                return JsonSerializer.Deserialize<T>(value);
            }
            return default;
        }
        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var isSet = _cacheDb.StringSet(key, JsonSerializer.Serialize(value), expiryTime);
            return isSet;
        }
        public object RemoveData(string key)
        {
            bool _isKeyExist = _cacheDb.KeyExists(key);
            if (_isKeyExist == true)
            {
                return _cacheDb.KeyDelete(key);
            }
            return false;
        }

    }
}

//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);