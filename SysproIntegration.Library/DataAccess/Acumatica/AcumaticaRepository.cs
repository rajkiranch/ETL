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
        private readonly AcumaticaContext _context;

        public AcumaticaRepository(AcumaticaContext context)
        {
            this._context = context;
           this._screen = _context.Connect();
        }

        public AcumaticaRepository(): this(new AcumaticaContext())
        {
            this._screen = _context.Connect();
        }

        public AcumaticaRepository(string key):this(new AcumaticaContext(key))
        {
            this._screen = _context.Connect();
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
