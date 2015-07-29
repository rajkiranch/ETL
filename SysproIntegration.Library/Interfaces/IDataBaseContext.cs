using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Interfaces
{
    public interface IDataBaseContext<T>
    {
        T Connect();
    }
}
