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
    public class engage_major_releaseController : Controller
    {
        Iconfig_file_first_kindBLL icfb = IocCreat.Createconfig_file_first_kindBLL();
        Iconfig_file_second_kindBLL icsb = IocCreat.Createconfig_file_second_kindBLL();
        Iconfig_file_third_kindBLL ictb = IocCreat.Createconfig_file_third_kindBLL();
        Iconfig_majorBLL icb = IocCreat.Createconfig_majorBLL();
        Iconfig_major_kindBLL icmb = IocCreat.Createconfig_major_kindBLL();
        Iconfig_public_charBLL icpb = IocCreat.Createconfig_public_charBLL();
        Iengage_major_releaseBLL iemb = IocCreat.Createengage_major_releaseBLL();
        // GET: engage_major_release
        public ActionResult engage_major_releaseShow()
        {
            SelectList fsl = new SelectList(icfb.config_file_first_kindSelect(), "first_kind_id", "first_kind_name");
            //SelectList pxsl = new SelectList(icpb.config_public_charSeleBYKind("职称"), "attribute_kind", "attribute_name");
            SelectList flsl = new SelectList(icmb.config_major_kindSelect(), "major_kind_id", "major_kind_name");
            ViewBag.yj = fsl;
            //ViewBag.zplx = pxsl;
            ViewBag.zwfl = flsl;
            return View();
        }
        //职位联动
        public ActionResult FillType(int zw)
        {
            List<config_majorModel> list = icb.SelectByType(zw);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Add(engage_major_releaseModel emm)
        {
            emm.first_kind_name = icfb.config_file_first_kindSelectByName(emm.first_kind_id);
            emm.second_kind_name = icsb.config_file_second_kindSelectByName(emm.second_kind_id);
            emm.third_kind_name = ictb.SelectByName(emm.third_kind_id);
            emm.major_kind_name = icmb.Selmajor_kind_name(emm.major_kind_id);
            emm.major_name = icb.SelectByName(emm.major_kind_id, emm.major_id);
            emm.change_time = DateTime.Now;
            if (iemb.engage_major_releaseAdd(emm) > 0)
            {
                return Content("<script>alert('职位发布登记成功!');location.href='/engage_major_release/engage_major_releaseShow';</script>");
            }else
            {
                return Content("<script>alert('职位发布登记失败!');location.href='/engage_major_release/engage_major_releaseShow';</script>");
            }
        }
        //职位变更
        public ActionResult Change()
        {
            return View();
        }
        //分页查询
        public ActionResult ShowAll(int currentPage,int pageSize)
        {
            int rows = 0;
            List<engage_major_releaseModel> list = iemb.FenYe(currentPage, pageSize, out rows);
            TempData["rows"] = rows;
            return Content(JsonConvert.SerializeObject(list));
        }
        //获取总行数
        public ActionResult GetRows()
        {
            return Content(TempData["rows"].ToString());
        }
        //职位修改回显
        public ActionResult Update(int id)
        {
            engage_major_releaseModel emm = iemb.engage_major_releaseSelectById(id);
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "社会招聘", Value = "社会招聘" });
            list.Add(new SelectListItem() { Text = "校园招聘", Value = "校园招聘" });
            SelectList sl = new SelectList(list, "Text", "Value",emm.engage_type);
            ViewBag.zplx = sl;
            return View(emm);
        }
        //职位修改
        public ActionResult engage_major_releaseUpdate(engage_major_releaseModel emm)
        {
            if (iemb.engage_major_releaseUpdate(emm) > 0)
            {
                return Content("<script>alert('职位发布变更成功!');location.href='/engage_major_release/Change';</script>");
            }else
            {
                return Content("<script>alert('职位发布变更失败!');location.href='/engage_major_release/Update/'+emm.Id;</script>");
            }
        }
        //职位删除
        public ActionResult Delete(int id)
        {
            engage_major_releaseModel emm = new engage_major_releaseModel() { Id = Convert.ToInt16(id) };
            if (iemb.engage_major_releaseDel(emm) > 0)
            {
                return Content("<script>alert('职位发布删除成功!');location.href='/engage_major_release/Change';</script>");
            }else
            {
                return Content("<script>alert('职位发布删除失败!');location.href='/engage_major_release/Change';</script>");
            }
        }
        //职位查询
        public ActionResult SelectShow()
        {
            return View();
        }
        //职位明细
        public ActionResult ShowMx(int id)
        {
            engage_major_releaseModel emm = iemb.engage_major_releaseSelectById(id);
            return View(emm);
        }
        //确认申请--跳到简历登陆
        public ActionResult Tojl(engage_major_releaseModel emm)
        {
            return View();
        }
    }
}