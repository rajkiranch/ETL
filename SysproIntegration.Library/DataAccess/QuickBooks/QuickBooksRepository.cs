using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Interfaces;
using SysproIntegration.Library.Models.QuickBooks;
using SysproIntegration.Library.Interfaces.Repositories;

namespace SysproIntegration.Library.DataAccess.QuickBooks
{
    public class QuickBooksRepository:IQbRepository
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


        public IList<QbInvoice> GetInvoices()
        {
            
            //:Todo
            return new List<QbInvoice>()
            {
                new QbInvoice(){Column1 = "1",Column2 = "desc1"},
                new QbInvoice(){Column1 = "2",Column2 = ""},

            };
        }
    }
}
