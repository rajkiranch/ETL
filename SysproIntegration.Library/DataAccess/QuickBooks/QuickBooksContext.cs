using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QbSync.QbXml.Objects;
using SysproIntegration.Library.Configuration;
using SysproIntegration.Library.Interfaces;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Infrastructure;

namespace SysproIntegration.Library.DataAccess.QuickBooks
{
    public class QuickBooksContext : IDataBaseContext<QuickBooksXml>
    {
        private readonly IConfig _config;

        public QuickBooksContext(IConfig config)
        {
            this._config = config;
        }

        public QuickBooksContext(string key) : this(new SysproConfig(key))
        {
            
        }

        public QuickBooksContext() : this(new SysproConfig(Constants.DefaultQbFileConnectionKey))
        {
            
        }
        
        public QuickBooksXml Connect()
        {

            return new QuickBooksXml();
        }
    }
}
