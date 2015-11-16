using SysproIntegration.Library.BusinessLogic;
using SysproIntegration.Library.Interfaces.Services;
using SysproIntegration.Library.Presenters;
using SysproIntegration.Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SysproWebApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>    
    public class ContactController : Controller
    {
        private ContactPresenter contactPresenter;
        readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {            
            this._contactService = contactService;
        }       
        public ActionResult  GetContacts()
        {
            contactPresenter = new ContactPresenter(_contactService);
            return Json(contactPresenter.DisplayContacts(), JsonRequestBehavior.AllowGet);
        }
    }
}
