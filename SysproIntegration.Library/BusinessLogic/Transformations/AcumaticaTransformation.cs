using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SysproIntegration.Library.Models.Acumatica;
using SysproIntegration.Library.Models.QuickBooks;

namespace SysproIntegration.Library.BusinessLogic.Transformations
{
    public class AcumaticaTransformation
    {
        public static Invoice TransformQbToAcumaticaInvoice(QbInvoice qbInvoice, Invoice invoice)
        {
            return Mapper.Map<QbInvoice, Invoice>(qbInvoice);
        }

        public static IList<Invoice> TransformQbToAcumaticaInvoiceList(IList<QbInvoice> qbInvoices, IList<Invoice> invoices)
        {
            return Mapper.Map<IList<QbInvoice>,IList<Invoice>>(qbInvoices);
        }

    }
}
