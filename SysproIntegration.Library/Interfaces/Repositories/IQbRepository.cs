using System.Collections.Generic;
using SysproIntegration.Library.Models.QuickBooks;

namespace SysproIntegration.Library.Interfaces.Repositories
{
    public interface IQbInvoiceRepository
    {
        IList<QbInvoice> GetInvoices();  
    }
}