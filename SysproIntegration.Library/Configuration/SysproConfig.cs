using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Configuration
{
    public class SysproConfig:IConfig
    {
        readonly private string _key;

        public SysproConfig(string key)
        {
            this._key = key;
        }      
        public FileElement GetQuickBookConfiguration()
        {
            return DatabaseConfiguration.DatabaseFileSettings[_key];
        }

        public ServiceElement GetAcumaticaConfiguration()
        {
            return DatabaseConfiguration.DatabaseServiceSettings[_key];
        }

        public string GetAppSettingValue()
        {            
            return ConfigurationManager.AppSettings[_key].ToString();
        }
    }
}
