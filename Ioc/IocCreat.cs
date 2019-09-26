
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;


namespace Ioc
{
   public class IocCreat
    {

        //职称设置
        //public static Iconfig_public_charDAL Createconfig_public_charDAL()
        //{
        //    UnityContainer ioc = CreatIoc("containerOne");
        //    return ioc.Resolve<config_public_charDAL>("config_public_charDAL");
        //}

        //public static Iconfig_public_charBLL Createconfig_public_charBLL()
        //{
        //    UnityContainer ioc = CreatIoc("containerTwo");
        //    return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        //}

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"";//复制自己Unity配置文件的绝对路径
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的Unity节点区.Configuration是UnityConfigurationSection的父类,所以要强转转换
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;
        }
    }
}
