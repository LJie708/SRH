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
    public class config_file_first_kindController : Controller
    {
        Iconfig_file_first_kindBLL ickb = IocCreat.Createconfig_file_first_kindBLL();
        Iconfig_file_second_kindBLL icsb = IocCreat.Createconfig_file_second_kindBLL();
        // GET: config_file_first_kind
        public ActionResult config_file_first_kindShow()
        {
            return View();
        }
        //数据显示
        public ActionResult SelectAll()
        {
            List<config_file_first_kindModel> list = ickb.config_file_first_kindSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Add()
        {
            return View();
        }
        //添加
        public ActionResult AddFirst(config_file_first_kindModel cfkm)
        {
            cfkm.first_kind_id = "0" + ickb.config_file_first_kindMaxId().ToString();
            if (ickb.config_file_first_kindAdd(cfkm) > 0)
            {
                return Content("<script>alert('I级机构添加成功!');location.href='/config_file_first_kind/config_file_first_kindShow';</script>");
            }else
            {
                return Content("<script>alert('I级机构添加失败!');location.href='/config_file_first_kind/Add';</script>");
            }
        }
        public ActionResult Update(int id)
        {
            config_file_first_kindModel cfm = ickb.config_file_first_kindSelectById(id);
            return View(cfm);
        }
        //修改
        public ActionResult UpdateFirst(config_file_first_kindModel cfkm)
        {
            if (ickb.config_file_first_kindUpdate(cfkm) > 0)
            {
                return Content("<script>alert('修改成功!');location.href='/config_file_first_kind/config_file_first_kindShow';</script>");
            }else
            {
                return Content("<script>alert('修改失败!');location.href='/config_file_first_kind/Update/'+cfkm.Id;</script>");
            }
        }
        //删除
        public ActionResult Delete(int id,string fid)
        {
            if (icsb.SelectByFid(fid) > 0)
            {
                return Content("<script>alert('不可删除!该I级机构名称下存在II级机构');location.href='/config_file_first_kind/config_file_first_kindShow';</script>");
            }
            else
            {
                config_file_first_kindModel ctm = new config_file_first_kindModel() { Id = Convert.ToInt16(id) };
                if (ickb.config_file_first_kindDelete(ctm) > 0)
                {
                    return Content("<script>alert('删除成功!');location.href='/config_file_first_kind/config_file_first_kindShow';</script>");
                }
                else
                {
                    return Content("<script>alert('删除失败!');location.href='/config_file_first_kind/config_file_first_kindShow';</script>");
                }
            }
        }
    }
}