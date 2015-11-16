using SysproIntegration.Library.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysproIntegration.Library.Models.CRM;
using SysproIntegration.Library.DataAccess.CRM;
using SysproIntegration.Library.Interfaces.Repositories;

namespace SysproIntegration.Library.BusinessLogic
{
    public class ContactService : IContactService
    {
        readonly ICrmRepository _crmRepository;

        public ContactService(ICrmRepository crmRepository)
        {
            this._crmRepository = crmRepository;
        }
        public ContactService():this(new CrmRepository())
        {

        }

        public IList<CrmContact> GetContacts()
        {
            return _crmRepository.GetCrmContacts();
        }
    }
}
