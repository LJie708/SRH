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
    public class config_major_kindController : Controller
    {

        Iconfig_major_kindBLL isb = IocCreat.Createconfig_major_kindBLL();
        Iconfig_majorBLL imb = IocCreat.Createconfig_majorBLL();
        // GET: major_kind
        public ActionResult major_kind()
        {
            return View();
        }
        public ActionResult mkSel()
        {
            List<config_major_kindModel> list = isb.config_major_kindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult major_kind_add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult major_kind_add(config_major_kindModel cmm)
        {
            cmm.major_kind_id = isb.idjia1().ToString();
            int a = isb.config_major_kindAdd(cmm);
            if (a > 0)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('添加成功！');window.location.href= 'major_kind'</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('添加成功！');window.location.href= 'major_kind'</script>");
            }
        }
        
        public ActionResult major_kind_Del(int id,string kind_id)
        {
            int a = imb.Selectmajor_kind_id(Convert.ToInt32(kind_id));
            if (a<=0)
            {
                config_major_kindModel cmm = new config_major_kindModel()
                {
                    Id =Convert.ToInt16(id)
                };
                int b = isb.config_major_kindDelete(cmm);
                if (b>0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('删除成功');window.location.href= '/config_major_kind/major_kind'</script>");
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('删除失败！');window.location.href= '/config_major_kind/major_kind'</script>");
                }
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('删除失败！ 该职位分类下有子类');window.location.href= '/config_major_kind/major_kind'</script>");
            }
        }
    }
}