using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SysproIntegration.Library.Interfaces
{
    public interface IDataBaseContext<T>
    {
        T Connect();
    }

    public interface IDataBaseFileContext<T>
    {
        T Connect(XmlDocument xmlDoc);
    }

}
