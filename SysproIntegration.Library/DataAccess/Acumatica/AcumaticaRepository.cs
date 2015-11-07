using System;
using System.Collections.Generic;
using SysproIntegration.Library.Models.Acumatica;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Interfaces.Repositories;

namespace SysproIntegration.Library.DataAccess.Acumatica
{    
    public class AcumaticaRepository : IAcumaticaRepository
    {
        private Screen _screen;
        public AcumaticaContext Context { get; private set; }

        public AcumaticaRepository(AcumaticaContext context)
        {
            
            this.Context = context;
            this._screen = Context.Connect();
        }

        public AcumaticaRepository(): this(new AcumaticaContext())
        {
            
        }

        public AcumaticaRepository(string key):this(new AcumaticaContext(key))
        {
            
        }

        public bool IsStockItemExists(string name)
        {
           
            throw new NotImplementedException();
        }

        public string AddStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public string AddInvoice(AcumaticaInvoice invoice)
        {
            //todo:
            return String.Empty;
        }

        

        public IList<AcumaticaInvoice> GetInvoices()
        {
            //:Todo
            return new List<AcumaticaInvoice>()
            {
                new AcumaticaInvoice(){Column4 = "1",Column5 = "desc1"},
                new AcumaticaInvoice(){Column4 = "2",Column5 = "desc2"},

            };
        }


        public void AddInvoices(IList<AcumaticaInvoice> invoices)
        {
            //todo:
            //this._screen.AddInvoices
        }
    }
   
}
