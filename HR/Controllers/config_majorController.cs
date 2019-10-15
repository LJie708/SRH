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
    public class config_majorController : Controller
    {
        Iconfig_majorBLL imb = IocCreat.Createconfig_majorBLL();
        Iconfig_major_kindBLL imk = IocCreat.Createconfig_major_kindBLL();
        // GET: config_major
        public ActionResult major()
        {
            return View();
        }
        public ActionResult mjSel()
        {
            List<config_majorModel> list = imb.config_majorSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult major_add()
        {
            SelectList sl = new SelectList(imk.config_major_kindSelect(), "major_kind_id", "major_kind_name");
            ViewBag.s = sl;
            return View();
        }
        [HttpPost]
        public ActionResult major_add(config_majorModel cmm)
        {
            cmm.major_kind_name = imk.Selmajor_kind_name(cmm.major_kind_id);
            cmm.major_id = imb.major_kind_idMaxId().ToString();
            int a = imb.config_majorAdd(cmm);

            if (a > 0)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('添加成功！');window.location.href= 'major'</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('添加失败！');window.location.href= 'major'</script>");
            }
        }

        public ActionResult major_Del(int Id)
        {
            config_majorModel ccm = new config_majorModel()
            {
                Id = Id
            };

            int aa = imb.config_majorDelete(ccm);
            
            if (aa > 0)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('删除成功！');window.location.href= '/config_major/major'</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('删除成功！');window.location.href= '/config_major/major'</script>");
            }
            
        }

    }
}