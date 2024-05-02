using StackExchange.Redis;
using ConfigurationManager = Repository.Util.ConfigurationManager;

namespace Repository.Service
{
    public class RedisConnectionHelper
    {
        static RedisConnectionHelper()
        {
            Console.WriteLine("ConfigurationManager.AppSetting[\"CacheSettings:RedisURL\"]" + ConfigurationManager.AppSetting["CacheSettings:RedisURL"]);
            RedisConnectionHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() => {
                return ConnectionMultiplexer.Connect(ConfigurationManager.AppSetting["CacheSettings:RedisURL"]);

            });
        }
        private static Lazy<ConnectionMultiplexer> lazyConnection;
        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }
}
