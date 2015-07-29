using SysproIntegration.Library.Configuration;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.DataAccess.Acumatica
{
    public class AcumaticaContext : IDataBaseContext<Screen>
    {
        private readonly IConfig _config;
       
        public AcumaticaContext(IConfig config)
        {
            this._config = config;
        }
        public AcumaticaContext()
            : this(new SysproConfig("AcumaticaConnection"))
        {
        }
        public AcumaticaContext(string key)
            :this(new SysproConfig(key))
        {
        }
        public Screen Connect()
        {
            var acumaticaElement = this._config.GetAcumaticaConfiguration();
            ///connection logic
            return new Screen();
        }
    }
}
