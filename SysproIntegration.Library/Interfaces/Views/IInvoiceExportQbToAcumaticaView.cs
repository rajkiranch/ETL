using System.Collections.Generic;
using SysproIntegration.Library.Models.QuickBooks;
using SysproIntegration.Library.ViewModels;

namespace SysproIntegration.Library.Interfaces.Views
{
    public interface IInvoiceExportQbToAcumaticaView
    {
        IList<QBToAcumaticaInvoicesExportVM> QbInvoices { get; set; }     

        string Message {  set; }
    }
}