using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Net;
using System.Configuration;
using System.ComponentModel;

namespace curfew
{
    class SqlSettings
    {
        public static void SetSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, false);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
