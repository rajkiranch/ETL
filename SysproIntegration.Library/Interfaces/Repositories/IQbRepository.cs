using System.Collections.Generic;
using SysproIntegration.Library.Models.QuickBooks;

namespace SysproIntegration.Library.Interfaces.Repositories
{
    public interface IQbRepository
    {
        IList<QbInvoice> GetInvoices();  
    }
}