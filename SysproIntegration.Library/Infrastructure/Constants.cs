using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Infrastructure
{
    public class Constants
    {
        public const string DefaultQbFileConnectionKey = "DefaultQuickBooksFileConnection";
        public const string DefaultAcumaticaFileConnectionKey = "DefaultAcumaticaFileConnection";
        public const string FileElement = "//fileElementSection/fileElements/add[@key='{0}']";
        public const string ServiceElement = "//serviceElementSection/serviceElements/add[@key='{0}']";
        public const string DefaultCrmConnectionKey = "xrm";

    }
}
