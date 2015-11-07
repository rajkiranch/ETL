using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SysproIntegration.Library.Models.Acumatica;

namespace SysproIntegration.Library.BusinessLogic.Validations
{
    public partial class InvoiceValidator : AbstractValidator<AcumaticaInvoice>
    {
        public InvoiceValidator()
        {
            RuleFor(x => x.Column4).NotNull().WithMessage("colum4 cannot be null");
            RuleFor(x => x.Column5).Length(1, 50).WithMessage("colum5 length must be between 1 and 50");            
        }
    }

    
}
