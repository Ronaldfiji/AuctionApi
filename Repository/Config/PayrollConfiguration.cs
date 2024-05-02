using Microsoft.Extensions.Configuration;

namespace Repository.Config
{
    public class PayrollConfiguration : IPayrollConfiguration
    {
        private readonly IConfiguration _configuration;

        public PayrollConfiguration(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string PayrollDBConnection
        {
            get
            {
                return this._configuration["ConnectionStrings:MSSQLPayrollDBConnProd"];
            }
        }

        /*To Access value call method ->  configuration.GetConnectionString("SQLLiteDBConnLocal"));*/
        public string GetConnectionString(string connectionName)
        {
            return this._configuration.GetConnectionString(connectionName);
        }
        public string App_Settings_Secret
        {
            get
            {
                return this._configuration["App_Settings:Secret"];
            }
        }

        public string AccountKey
        {
            get
            {
                return this._configuration["AppSeettings:AccountKey"];
            }
        }
        // To acess values from 'section' use DI and GetSection() method. Example  - configuration.GetConfigurationSection("App_Settings")
        // .GetSection("AccessTokenExpirationMinutes").Value);
        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }
    }
}
