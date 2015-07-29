using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Configuration
{
    public interface IConfig
    {
        string GetAppSettingValue();
        FileElement GetQuickBookConfiguration();
        ServiceElement GetAcumaticaConfiguration();
    }
}
