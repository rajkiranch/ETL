using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.BusinessLogic.Validations
{
    public interface IValidation
    {
        IList<string> Errors { get;}
        bool IsValid { get; }
    }

    
}
