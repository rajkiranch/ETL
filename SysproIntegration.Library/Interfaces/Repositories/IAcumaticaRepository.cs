using System.Collections.Generic;
using SysproIntegration.Library.Models.Acumatica;

namespace SysproIntegration.Library.Interfaces.Repositories
{
    public interface IAcumaticaRepository
    {
        bool IsStockItemExists(string name);
        string AddStock(Stock stock);
        string AddInvoice(AcumaticaInvoice invoice);
        IList<AcumaticaInvoice> GetInvoices();
        void AddInvoices(IList<AcumaticaInvoice> invoices);
    }
}