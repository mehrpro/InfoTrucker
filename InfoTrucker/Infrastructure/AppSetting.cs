using System.Configuration;
using InfoTrucker.UI.Admin;

namespace InfoTrucker.Infrastructure
{
    public class AppSetting
    {

        private System.Configuration.Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }


        /// <summary>
        /// دریافت رشته اتصال از App.config با استفاده     
        /// </summary>
        /// <param name="key">کدی که با آن رشته اتصال رمز شده است</param>
        /// <returns></returns>
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
            EnCoding.Encryption();
        }
    }
}