using SysproIntegration.Library.Interfaces.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.Models.Acumatica;
using SysproIntegration.Library.External;

namespace SysproIntegration.Library.DataAccess.Acumatica
{
    

    public class AcumaticaRepository : IAcumaticaStock, IAcumaticaInvoice
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

        public string AddInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
   
}
