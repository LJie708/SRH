
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAO;
using Model;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Runtime.Remoting.Messaging;

namespace DAO
{
    public class engage_resumeDAO : DaoBase<engage_resume>, Iengage_resumeDAO
    {
        //添加
        public int engage_resumeAdd(engage_resumeModel erm)
        {
            engage_resume er = new engage_resume()
            {
                human_name = erm.human_name,
                engage_type = erm.engage_type,
                human_address = erm.human_address,
                human_postcode = erm.human_postcode,
                human_major_kind_id = erm.human_major_kind_id,
                human_major_kind_name = erm.human_major_kind_name,
                human_major_id = erm.human_major_id,
                human_major_name = erm.human_major_name,
                human_telephone = erm.human_telephone,
                human_homephone = erm.human_homephone,
                human_mobilephone = erm.human_mobilephone,
                human_email = erm.human_email,
                human_hobby = erm.human_hobby,
                human_specility = erm.human_specility,
                human_sex = erm.human_sex,
                human_religion = erm.human_religion,
                human_party = erm.human_party,
                human_nationality = erm.human_nationality,
                human_race = erm.human_race,
                human_birthday = erm.human_birthday,
                human_age = erm.human_age,
                human_educated_degree = erm.human_educated_degree,
                human_educated_years = erm.human_educated_years,
                human_educated_major = erm.human_educated_major,
                human_college = erm.human_college,
                human_idcard = erm.human_idcard,
                human_birthplace = erm.human_birthplace,
                demand_salary_standard = erm.demand_salary_standard,
                human_history_records = erm.human_history_records,
                remark = erm.remark,
                check_status = erm.check_status,
                regist_time = erm.regist_time,
                human_picture = erm.human_picture,
                test_amount = erm.test_amount,
                register = erm.register,
                checker = erm.checker,
                check_time = DateTime.Now,
            };
            return Add(er);
        }
        //删除
        public int engage_resumeDel(engage_resumeModel erm)
        {
            engage_resume er = new engage_resume()
            {
                Id = erm.Id
            };
            return Delete(er);
        }
        //查询
        public List<engage_resumeModel> engage_resumeSelect()
        {
            List<engage_resume> list = Select();
            List<engage_resumeModel> liste = new List<engage_resumeModel>();
            foreach (engage_resume erm in list)
            {
                engage_resumeModel er = new engage_resumeModel()
                {
                    Id = erm.Id,
                    human_name = erm.human_name,
                    engage_type = erm.engage_type,
                    human_address = erm.human_address,
                    human_postcode = erm.human_postcode,
                    human_major_kind_id = erm.human_major_kind_id,
                    human_major_kind_name = erm.human_major_kind_name,
                    human_major_id = erm.human_major_id,
                    human_major_name = erm.human_major_name,
                    human_telephone = erm.human_telephone,
                    human_homephone = erm.human_homephone,
                    human_mobilephone = erm.human_mobilephone,
                    human_email = erm.human_email,
                    human_hobby = erm.human_hobby,
                    human_specility = erm.human_specility,
                    human_sex = erm.human_sex,
                    human_religion = erm.human_religion,
                    human_party = erm.human_party,
                    human_nationality = erm.human_nationality,
                    human_race = erm.human_race,
                    human_birthday = erm.human_birthday,
                    human_age = erm.human_age,
                    human_educated_degree = erm.human_educated_degree,
                    human_educated_years = erm.human_educated_years,
                    human_educated_major = erm.human_educated_major,
                    human_college = erm.human_college,
                    human_idcard = erm.human_idcard,
                    human_birthplace = erm.human_birthplace,
                    demand_salary_standard = erm.demand_salary_standard,
                    human_history_records = erm.human_history_records,
                    remark = erm.remark,
                    check_status = erm.check_status,
                    regist_time = erm.regist_time,
                    human_picture = erm.human_picture,
                    test_amount = erm.test_amount,
                    register = erm.register,
                    checker = erm.checker,
                    check_time = DateTime.Now
                };
                liste.Add(er);
            }
            return liste;
        }
        //根据id查询
        public engage_resumeModel engage_resumeSelectById(int id)
        {
            MyDbContext mc = new MyDbContext();
            List<engage_resume> list = mc.engage_resume.Where(
                e => e.Id == id).Select(e => e).ToList();
            engage_resumeModel erm = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                check_status = list[0].check_status,
                regist_time = list[0].regist_time,
                human_picture = list[0].human_picture,
                test_amount = list[0].test_amount,
                register = list[0].register,
                checker = list[0].checker,
                check_time = list[0].check_time,
            };
            return erm;
        }
        //修改
        public int engage_resumeUpdate(engage_resumeModel erm)
        {
            engage_resume er = new engage_resume()
            {
                Id = erm.Id,
                human_name = erm.human_name,
                engage_type = erm.engage_type,
                human_address = erm.human_address,
                human_postcode = erm.human_postcode,
                human_major_kind_id = erm.human_major_kind_id,
                human_major_kind_name = erm.human_major_kind_name,
                human_major_id = erm.human_major_id,
                human_major_name = erm.human_major_name,
                human_telephone = erm.human_telephone,
                human_homephone = erm.human_homephone,
                human_mobilephone = erm.human_mobilephone,
                human_email = erm.human_email,
                human_hobby = erm.human_hobby,
                human_specility = erm.human_specility,
                human_sex = erm.human_sex,
                human_religion = erm.human_religion,
                human_party = erm.human_party,
                human_nationality = erm.human_nationality,
                human_race = erm.human_race,
                human_birthday = erm.human_birthday,
                human_age = erm.human_age,
                human_educated_degree = erm.human_educated_degree,
                human_educated_years = erm.human_educated_years,
                human_educated_major = erm.human_educated_major,
                human_college = erm.human_college,
                human_idcard = erm.human_idcard,
                human_birthplace = erm.human_birthplace,
                demand_salary_standard = erm.demand_salary_standard,
                human_history_records = erm.human_history_records,
                remark = erm.remark,
                check_status = erm.check_status,
                regist_time = erm.regist_time,
                human_picture = erm.human_picture,
                test_amount = erm.test_amount,
                register = erm.register,
                checker = erm.checker,
                check_time = erm.check_time,
            };
            return Update(er);
        }
        
    }
}
