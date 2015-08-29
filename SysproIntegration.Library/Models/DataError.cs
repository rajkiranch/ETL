using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Models
{
    public class DataError
    {
        public object Data { get; set; }

        public IList<string> Errors { get; set; }

    }
}
