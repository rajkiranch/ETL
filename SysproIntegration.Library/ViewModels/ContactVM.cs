using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.ViewModels
{
    public class ContactVM
    {
        public Guid Id { get; set; }
        public string EMailAddress { get; set; }
        public string Country { get; set; }
    }
}
