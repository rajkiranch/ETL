using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SysproIntegration.Library.Models.Acumatica;

namespace SysproIntegration.Library.BusinessLogic.Validations
{
    public partial class InvoiceValidation : IValidation
    {
        private readonly Invoice _invoice;
        private bool _isValid = false;
        private IList<string> _errorsList=new List<string>();

        public InvoiceValidation(Invoice invoice)
        {
            this._invoice = invoice;
            CheckValidation();
        }

        private void CheckValidation()
        {
            InvoiceValidator validator=new InvoiceValidator();
            var results = validator.Validate(_invoice);
            _isValid = results.IsValid;
            var failures = results.Errors;
            foreach (var failure in failures)
            {
                _errorsList.Add(failure.ErrorMessage);
            }
        }

        public  virtual  bool IsValid
        {
            get
            {                
                return _isValid;
            }            
        }

        public IList<string> Errors
        {
            get { return _errorsList; }           
        }
    }
}
