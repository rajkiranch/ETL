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
        public static AcumaticaInvoice TransformQbToAcumaticaInvoice(QbInvoice qbInvoice)
        {
            return Mapper.Map<QbInvoice, AcumaticaInvoice>(qbInvoice);
        }

        public static IList<AcumaticaInvoice> TransformQbToAcumaticaInvoiceList(IList<QbInvoice> qbInvoices)
        {
            return Mapper.Map<IList<QbInvoice>,IList<AcumaticaInvoice>>(qbInvoices);
        }

    }
}
