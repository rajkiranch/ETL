using SysproIntegration.Library.Interfaces.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.Models.QuickBooks;
using SysproIntegration.Library.Interfaces.Services;
using SysproIntegration.Library.BusinessLogic;
using SysproIntegration.Library.ViewModels;
using SysproIntegration.Library.BusinessLogic.Transformations;
using SysproIntegration.Library.Infrastructure;

namespace SysproIntegration.Library.Presenters
{
    public class InvoiceExportQBToAcumaticaPresenter
    {
        readonly IInvoiceExportQbToAcumaticaView _invoiceExportQbToAcumaticaView;
        readonly IAcumaticaService _acumaticaService;
        readonly IQuickBooksService _quickBooksService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceExportQbToAcumaticaView"></param>
        /// <param name="acumaticaService"></param>
        /// <param name="quickBooksService"></param>
        public InvoiceExportQBToAcumaticaPresenter(IInvoiceExportQbToAcumaticaView invoiceExportQbToAcumaticaView,
                                                   IAcumaticaService acumaticaService, 
                                                   IQuickBooksService quickBooksService)
        {
            this._invoiceExportQbToAcumaticaView = invoiceExportQbToAcumaticaView;
            this._acumaticaService = acumaticaService;
            this._quickBooksService = quickBooksService;
        }
        /// <summary>
        /// 
        /// </summary>
        public void LoadInvoices()
        {
            var qbInvoices = from c in _quickBooksService.GetInvoices()
                             select new QBToAcumaticaInvoicesExportVM
                                 {
                                     Column1 = c.Column1,
                                     Column2 = c.Column2
                                 };
            _invoiceExportQbToAcumaticaView.QbInvoices = qbInvoices.ToList();

        }
        /// <summary>
        /// 
        /// </summary>
        public void ExportToAcumatica()
        {

            var qbInvoicesExportValues = from c in _invoiceExportQbToAcumaticaView.QbInvoices.Where(c=>c.Export==true)
                                                    select new QbInvoice { Column1 = c.Column1, Column2 = c.Column2 };

            List<QbInvoice> filteredValues = qbInvoicesExportValues.ToList();

            //Conversion
            var acumaticaInvoices = AcumaticaTransformation.TransformQbToAcumaticaInvoiceList(filteredValues);
            //Add Invoices to Acumatica
            this._acumaticaService.AddInvoices(acumaticaInvoices);

            //If Error Display error message
            var errorDesc = string.Empty;
            if (this._acumaticaService.DataErrors != null && this._acumaticaService.DataErrors.Count > 0)
            {
                foreach (var error in _acumaticaService.DataErrors)
                {
                    foreach (var recordError in error.Errors)
                    {
                        errorDesc = string.Concat(errorDesc, recordError, ",");
                    }
                }
                _invoiceExportQbToAcumaticaView.Message = errorDesc;
                Logger<InvoiceExportQBToAcumaticaPresenter>.LogInfo(errorDesc);
            }
            else
            {
                _invoiceExportQbToAcumaticaView.Message = "Exported Successfully!";
            }
        }

    }
}
