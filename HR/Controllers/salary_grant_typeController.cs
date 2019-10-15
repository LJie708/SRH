using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Ioc;
using IBLL;

namespace HR.Controllers
{
    public class salary_grant_typeController : Controller
    {
        Isalary_grant_typeBLL isb = IocCreat.Createsalary_grant_typeBLL();
        // GET: salary_grant_type
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            List<salary_grant_typeModel> list = isb.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(salary_grant_typeModel s)
        {
            if(ModelState.IsValid)
            {
                if (isb.Add(s) > 0)
                {
                    return Content("<script>alert('添加成功');location.href='/salary_grant_type/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('添加失败');location.href='/salary_grant_type/Index'</script>");
                }               
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            salary_grant_typeModel s = new salary_grant_typeModel()
            {
                Id=Id
            };
            if (isb.Delete(s) > 0)
            {
                return Content("<script>alert('删除成功');location.href='/salary_grant_type/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');location.href='/salary_grant_type/Index'</script>");
            }
        }
    }
}