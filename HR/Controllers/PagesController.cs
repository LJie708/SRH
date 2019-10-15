using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using IBLL;
using Ioc;
using System.Data;

namespace HR.Controllers
{
    public class PagesController : Controller
    {
        IAccessUrlBLL iaub = IocCreat.CreateAccessUrlBLL();
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Top()
        {
            return View();
        }
        public ActionResult Left()
        {
            return View();
        }
        public ActionResult TreeLink()
        {
            string pid = Request["Id"];
            DataTable dt = iaub.TreeL(pid);
            return Content(JsonConvert.SerializeObject(dt));
        }
    }
}