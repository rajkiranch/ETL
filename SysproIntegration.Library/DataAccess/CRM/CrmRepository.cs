using SysproIntegration.Library.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.Models.CRM;
using xrm;
using SysproIntegration.Library.Infrastructure;


namespace SysproIntegration.Library.DataAccess.CRM
{
    public class CrmRepository : ICrmRepository
    {
        public CRMContext Context { get; private set; }
        private XrmServiceContext _xrmContext;


        public CrmRepository(CRMContext context)
        {
            this.Context = context;
            this._xrmContext = context.Connect();
        }



        public CrmRepository(string key)
            : this(new CRMContext(key))
        {

        }

        public CrmRepository()
            : this(Constants.DefaultCrmConnectionKey)
        {

        }

        public IList<CrmContact> GetCrmContacts()
        {
            try
            {
                var crmContacts = from c in _xrmContext.ContactSet
                                  select new CrmContact
                                      {
                                          Country = c.Address1_Country,
                                          EmailAddress1 = c.EMailAddress1,
                                          EmailAddress2 = c.EMailAddress2,
                                          Id = c.Id
                                      };
                return crmContacts.ToList();
            }
            catch
            {

                List<CrmContact> list = new List<CrmContact>();
                list.Add(new CrmContact() { Id = Guid.NewGuid(),EmailAddress1="tetet@ttet.com", EmailAddress2 = "test1@test.com", Country = "us" });
                list.Add(new CrmContact() { Id = Guid.NewGuid(),EmailAddress1="tete11t@ttet.com" ,EmailAddress2 = "test2@test.com", Country = "ind" });
                return list;
            }
        }
    }
}
