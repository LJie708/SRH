using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Model;
using Newtonsoft.Json;
using Ioc;
namespace HR.Controllers
{
    public class config_public_charController : Controller
    {
        Iconfig_public_charBLL isb = IocCreat.Createconfig_public_charBLL();
        // GET: config_public_char
        public ActionResult profession_design()
        {
            return View();
        }

        public ActionResult pdSele()
        {
            List<config_public_charModel> list = isb.config_public_charSeleBYKind("职称");
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult pdDel(int id)
        {
            config_public_charModel ccm = new config_public_charModel()
            {
                 Id=Convert.ToInt16(id)
            };
            int aa = isb.config_public_charDelete(ccm);
            if (aa > 0)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('删除成功！');window.location.href= '/config_public_char/profession_design'</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('删除成功！');window.location.href= '/config_public_char/profession_design'</script>");
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<config_public_charModel> list = isb.config_public_charSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult PublicAdd(config_public_charModel c)
        {
            if (isb.config_public_charAdd(c) > 0)
            {
                return Content("<script>alert('添加成功');location.href='/config_public_char/Index';</script>");
            }
            else
            {
                return Content("<script>alert('添加失败');location.href='/config_public_char/Index';</script>");
            }
        }

        public ActionResult Delete(int id)
        {
            config_public_charModel t = new config_public_charModel();
            t.Id = Convert.ToInt16(id);
            if (isb.config_public_charDelete(t) > 0)
            {
                return Content("<script>alert('删除成功');location.href='/config_public_char/Index';</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');location.href='/config_public_char/Index';</script>");
            }
        }
    }
}