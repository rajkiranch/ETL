using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;


using SysproIntegration.Library.Interfaces;
using SysproIntegration.Library.External;



namespace SysproIntegration.Library.DataAccess.CRM
{
    public class CRMContext : IDataBaseContext<MSCrmProxy>
    {



        public MSCrmProxy Connect()
        {
            throw new NotImplementedException();
        }
    }
}
