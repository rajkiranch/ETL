using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.External;

namespace SysproIntegration.Library.DataAccess.QuickBooks
{
    public class QuickBooksRepository
    {
        public QuickBooksContext Context { get; private set; }
        private QuickBooksXml _quickBooksXml;

        public QuickBooksRepository(QuickBooksContext context)
        {
            this.Context = context;
            this._quickBooksXml = context.Connect();
        }

        public QuickBooksRepository()
            : this(new QuickBooksContext())
        {

        }

        public QuickBooksRepository(string key)
            : this(new QuickBooksContext(key))
        {

        }

    }
}
