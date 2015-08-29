using System.Collections.Generic;
using SysproIntegration.Library.Models.QuickBooks;

namespace SysproIntegration.Library.Interfaces.Views
{
    public interface IInvoiceExportQbToAcumaticaView
    {
        IList<QbInvoice> QbInvoices { get; set; }

        bool ExportInvoicesToAcumatica();

        string Message { get; set; }
    }
}