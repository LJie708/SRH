using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using IDAO;
using IBLL;
using DAO;

namespace Ioc
{
   public class IocCreat
    {
        //权限
        public static IAccessUrlDAO CreateAccessUrlDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<AccessUrlDAO>("AccessUrlDAO");
        }

        public static IAccessUrlBLL CreateAccessUrlBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<IAccessUrlBLL>("AccessUrlBLL");
        }

        //I级联动
        public static Iconfig_file_first_kindDAO Createconfig_file_first_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_first_kindDAO>("config_file_first_kindDAO");
        }

        public static Iconfig_file_first_kindBLL Createconfig_file_first_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_file_first_kindBLL>("config_file_first_kindBLL");
        }
        
        //II级联动
        public static Iconfig_file_second_kindDAO Createconfig_file_second_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_second_kindDAO>("config_file_second_kindDAO");
        }

        public static Iconfig_file_second_kindBLL Createconfig_file_second_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_file_second_kindBLL>("config_file_second_kindBLL");
        }
        
        //III级联动
        public static Iconfig_file_third_kindDAO Createconfig_file_third_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_third_kindDAO>("config_file_third_kindDAO");
        }

        public static Iconfig_file_third_kindBLL Createconfig_file_third_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_file_third_kindBLL>("config_file_third_kindBLL");
        }
        
        //职称设置
        public static Iconfig_public_charDAO Createconfig_public_charDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_public_charDAO>("config_public_charDAO");
        }

        public static Iconfig_public_charBLL Createconfig_public_charBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }

        //职位分类
        public static Iconfig_major_kindDAO Createconfig_major_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_major_kindDAO>("config_major_kindDAO");
        }

        public static Iconfig_major_kindBLL Createconfig_major_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_major_kindBLL>("config_major_kindBLL");
        }

        //职位设置
        public static Iconfig_majorDAO Createconfig_majorDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_majorDAO>("config_majorDAO");
        }

        public static Iconfig_majorBLL Createconfig_majorBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_majorBLL>("config_majorBLL");
        }
        
        //薪酬
        public static Isalary_grant_typeDAO Createsalary_grant_typeDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<Isalary_grant_typeDAO>("salary_grant_typeDAO");
        }

        public static Isalary_grant_typeBLL Createsalary_grant_typeBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Isalary_grant_typeBLL>("salary_grant_typeBLL");
        }

        //职位发布管理
        public static Iengage_major_releaseDAO Createengage_major_releaseDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<engage_major_releaseDAO>("engage_major_releaseDAO");
        }

        public static Iengage_major_releaseBLL Createengage_major_releaseBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iengage_major_releaseBLL>("engage_major_releaseBLL");
        }

        //简历管理
        public static Iengage_resumeDAO Createengage_resumeDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<engage_resumeDAO>("engage_resumeDAO");
        }

        public static Iengage_resumeBLL Createengage_resumeBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iengage_resumeBLL>("engage_resumeBLL");
        }

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"H:\Y2\MVC\SHR\HR\Unity.config";//复制自己Unity配置文件的绝对路径
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的Unity节点区.Configuration是UnityConfigurationSection的父类,所以要强转转换
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;
        }
    }
}
