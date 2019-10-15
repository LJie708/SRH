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
    public class config_file_third_kindController : Controller
    {
        Iconfig_file_first_kindBLL icfb = IocCreat.Createconfig_file_first_kindBLL();
        Iconfig_file_second_kindBLL icsb = IocCreat.Createconfig_file_second_kindBLL();
        Iconfig_file_third_kindBLL ictb = IocCreat.Createconfig_file_third_kindBLL();
        // GET: config_file_third_kind
        public ActionResult config_file_third_kindShow()
        {
            return View();
        }
        //显示
        public ActionResult SelectAll()
        {
            List<config_file_third_kindModel> list = ictb.config_file_third_kindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Add()
        {
            SelectList sl = new SelectList(icfb.config_file_first_kindSelect(), "first_kind_id", "first_kind_name");
            ViewBag.yj = sl;
            return View();
        }
        //I级-II级联动
        public ActionResult First_kind(int yj)
        {
            List<config_file_second_kindModel> list = icsb.OnChanges(yj);
            return Content(JsonConvert.SerializeObject(list));
        }
        //II级-III级联动
        public ActionResult Second_kind(int ej)
        {
            List<config_file_third_kindModel> list = ictb.OnChanges(ej);
            return Content(JsonConvert.SerializeObject(list));
        }
        //添加
        public ActionResult AddThird(config_file_third_kindModel ctm)
        {
            ctm.third_kind_id = "0" + ictb.Iconfig_file_third_kindMaxId().ToString();
            ctm.first_kind_name = icfb.config_file_first_kindSelectByName(ctm.first_kind_id);
            ctm.second_kind_name = icsb.config_file_second_kindSelectByName(ctm.second_kind_id);
            if (ictb.config_file_third_kindAdd(ctm) > 0)
            {
                return Content("<script>alert('添加成功!');location.href='/config_file_third_kind/config_file_third_kindShow';</script>");
            }else
            {
                return Content("<script>alert('添加失败!');location.href='/config_file_third_kind/Add';</script>");
            }
        }

        public ActionResult Update(int id)
        {
            config_file_third_kindModel ctm = ictb.config_file_third_kindSelectById(id);
            return View(ctm);
        }
        //修改
        public ActionResult UpdateThird(config_file_third_kindModel ctm)
        {
            if (ictb.config_file_third_kindUpdate(ctm) > 0)
            {
                return Content("<script>alert('修改成功!');location.href='/config_file_third_kind/config_file_third_kindShow';</script>");
            }else
            {
                return Content("<script>alert('修改失败!');location.href='/config_file_third_kind/Update/'+ctm.Id;</script>");
            }
        }
        //删除
        public ActionResult Delete(int id)
        {
            config_file_third_kindModel ctm = new config_file_third_kindModel() { Id = Convert.ToInt16(id) };
            if (ictb.config_file_third_kindDelete(ctm) > 0)
            {
                return Content("<script>alert('删除成功!');location.href='/config_file_third_kind/config_file_third_kindShow';</script>");
            }else
            {
                return Content("<script>alert('删除失败!');location.href='/config_file_third_kind/config_file_third_kindShow';</script>");
            }
        }
    }
}