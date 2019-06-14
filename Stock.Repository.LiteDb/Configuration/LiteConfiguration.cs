using LiteDB;
using Stock.Repository.LiteDb.Interface;

namespace Stock.Repository.LiteDb.Configuration
{
    public class LiteConfiguration : IConfigurationProvider
    {
        public LiteDatabase GetDatabase(ConfigurationProvider provider)
        {
            var db = new LiteDatabase(provider.LiteUrl);
            return db;
        }
    }
}