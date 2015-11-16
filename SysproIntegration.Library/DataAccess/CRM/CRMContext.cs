using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using SysproIntegration.Library.Configuration;
using SysproIntegration.Library.Interfaces;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Infrastructure;
using xrm;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk;
using System.Net;



namespace SysproIntegration.Library.DataAccess.CRM
{
    public class CRMContext : IDataBaseContext<XrmServiceContext>
    {
        private Microsoft.Xrm.Sdk.IOrganizationService _organizationService;

        private readonly IConfig _config;

        public XrmServiceContext Connect()
        {
            try
            {
                var crmConfig = _config.GetServiceConfiguration();


                Uri organizationUri = new Uri(crmConfig.Url);
                Uri homeRealmUri = null;

                AuthenticationCredentials authCredentials = new AuthenticationCredentials();

                authCredentials.ClientCredentials.Windows.ClientCredential =
                            new System.Net.NetworkCredential(crmConfig.UserName,
                                crmConfig.Password,
                                "MS");


                OrganizationServiceProxy orgProxy = new OrganizationServiceProxy(organizationUri, homeRealmUri, null, null);
                _organizationService = (IOrganizationService)orgProxy;
                //return _organizationService;


                return new XrmServiceContext(_organizationService);
            }
            catch
            {
                return null;
            }
        }

         public CRMContext(IConfig config)
        {
            this._config = config;
        }

        public CRMContext(string key) : this(new SysproConfig(key))
        {
            
        }

        public CRMContext()
            : this(new SysproConfig(Constants.DefaultCrmConnectionKey))
        {
            
        }


    }
}
