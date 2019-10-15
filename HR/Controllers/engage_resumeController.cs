using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Ioc;
using IBLL;

namespace HR.Controllers
{
    public class engage_resumeController : Controller
    {
        Iconfig_public_charBLL icpb = IocCreat.Createconfig_public_charBLL();
        Iconfig_major_kindBLL icmb = IocCreat.Createconfig_major_kindBLL();
        Iconfig_majorBLL icb = IocCreat.Createconfig_majorBLL();
        // GET: engage_resume
        public ActionResult Create(engage_major_releaseModel emrm)
        {
            //职位分类
            List<config_major_kindModel> cmm = icmb.config_major_kindSelect();
            //国籍
            List<config_public_charModel> gj = icpb.config_public_charSeleBYKind("国籍");
            if (emrm != null)
            {
                //从职位申请跳转
                return View();
            }else
            {
                //直接点击简历登记
                return View();
            }
        }
        
    }
}