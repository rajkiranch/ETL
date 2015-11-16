using SysproIntegration.Library.Interfaces.Services;
using SysproIntegration.Library.Presenters;
using SysproIntegration.Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Syspro.Crm.Controllers
{

     [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {        
        private ContactPresenter contactPresenter;
        public ContactController(IContactService contactService)
        {
            contactPresenter = new ContactPresenter(contactService);
        }

        [HttpGet]   
        [ActionName("Get")]
        public IList<ContactVM> GetContacts()
        {
            return contactPresenter.DisplayContacts();
        }
    }
}
