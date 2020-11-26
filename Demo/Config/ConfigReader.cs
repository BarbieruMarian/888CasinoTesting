using Microsoft.Extensions.Configuration;
using System.IO;

namespace Demo.Config
{
    public class ConfigReader
    {
        public static void InitializeSettings(string jsonSection)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appconfig.json");

            IConfigurationRoot configurationRoot = builder.Build();

            Settings.URL = configurationRoot.GetSection(jsonSection).Get<ConfigSettings>().URL;
            Settings.Username = configurationRoot.GetSection(jsonSection).Get<ConfigSettings>().Username;
            Settings.Password = configurationRoot.GetSection(jsonSection).Get<ConfigSettings>().Password;

        }
    }
}
