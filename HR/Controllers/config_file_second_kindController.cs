using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Ioc;
using Model;
using Newtonsoft.Json;

namespace HR.Controllers
{
    public class config_file_second_kindController : Controller
    {
        Iconfig_file_third_kindBLL ictb = IocCreat.Createconfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL icsb = IocCreat.Createconfig_file_second_kindBLL();
        Iconfig_file_first_kindBLL ifb = IocCreat.Createconfig_file_first_kindBLL();
        // GET: config_file_second_kind
        public ActionResult config_file_second_kindShow()
        {
            return View();
        }
        //显示
        public ActionResult SelectAll()
        {
            List<config_file_second_kindModel> list = icsb.config_file_second_kindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Add()
        {
            SelectList sl = new SelectList(ifb.config_file_first_kindSelect(), "first_kind_id", "first_kind_name");
            ViewBag.jg = sl;
            return View();
        }
        //添加
        public ActionResult AddSecond(config_file_second_kindModel csm)
        {
            csm.second_kind_id = "0" + icsb.config_file_second_kindMaxId().ToString();
            csm.first_kind_name = ifb.config_file_first_kindSelectByName(csm.first_kind_id);
            if (icsb.config_file_second_kindAdd(csm)>0)
            {
                return Content("<script>alert('添加成功!');location.href='/config_file_second_kind/config_file_second_kindShow';</script>");
            }else
            {
                return Content("<script>alert('添加失败!');location.href='/config_file_second_kind/Add';</script>");
            }
        }
        public ActionResult Update(int id)
        {
            config_file_second_kindModel csm = icsb.config_file_second_kindSelectById(id);
            return View(csm);
        }
        //修改
        public ActionResult UpdateSecond(config_file_second_kindModel csm)
        {
            if (icsb.config_file_second_kindUpdate(csm) > 0)
            {
                return Content("<script>alert('修改成功!');location.href='/config_file_second_kind/config_file_second_kindShow';</script>");
            }else
            {
                return Content("<script>alert('修改成功!');location.href='/config_file_second_kind/Update/'+csm.Id;</script>");
            }
        }
        //删除
        public ActionResult Delete(int id,string tid)
        {
            if (ictb.SelectByTid(tid) > 0)
            {
                return Content("<script>alert('不可删除!该II级机构名称下存在III级机构');location.href='/config_file_second_kind/config_file_second_kindShow';</script>");
            }
            config_file_second_kindModel csm = new config_file_second_kindModel() { Id = Convert.ToInt16(id) };
            if (icsb.config_file_second_kindDelete(csm) > 0)
            {
                return Content("<script>alert('删除成功!');location.href='/config_file_second_kind/config_file_second_kindShow';</script>");
            }
            else
            {
                return Content("<script>alert('删除失败!');location.href='/config_file_second_kind/config_file_second_kindShow';</script>");
            }
        }
    }
}