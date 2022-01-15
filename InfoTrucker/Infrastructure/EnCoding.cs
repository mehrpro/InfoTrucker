using System.Configuration;
using System.Reflection;

namespace InfoTrucker.Infrastructure
{
    public static class EnCoding
    {
        /// <summary>
        /// رمز کردن رشته اتصال
        /// </summary>
        public static void Encryption()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
                connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            config.Save();
        }


        /// <summary>
        /// دیکریپت رشته اتصال
        /// </summary>
        public static void Decryption()
        {
            var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringSection != null && connectionStringSection.SectionInformation.IsProtected)
                connectionStringSection.SectionInformation.UnprotectSection();
            config.Save();


        }

        /// <summary>
        /// رشته اتصال از فایل App
        /// </summary>
        /// <returns></returns>
        public static string ConnString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            return connectionString;

        }

    }
}