using SysproIntegration.Library.Models.Acumatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Interfaces.Acumatica
{
    public interface IAcumaticaInvoice
    {
        string AddInvoice(Invoice invoice);
    }
}
