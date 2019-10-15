using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EFEntity;

namespace DAO
{
    public class engage_major_releaseDAO : DaoBase<engage_major_release>, Iengage_major_releaseDAO
    {
        public int engage_major_releaseAdd(engage_major_releaseModel emm)
        {
            engage_major_release emr = new engage_major_release()
            {
                first_kind_id = emm.first_kind_id,
                first_kind_name = emm.first_kind_name,
                second_kind_id = emm.second_kind_id,
                second_kind_name = emm.second_kind_name,
                third_kind_id = emm.third_kind_id,
                third_kind_name = emm.third_kind_name,
                major_kind_id = emm.major_kind_id,
                major_kind_name = emm.major_kind_name,
                major_id = emm.major_id,
                major_name = emm.major_name,
                human_amount = emm.human_amount,
                engage_type = emm.engage_type,
                deadline = emm.deadline,
                register = emm.register,
                regist_time = emm.regist_time,
                major_describe = emm.major_describe,
                engage_required = emm.engage_required,
                change_time = emm.change_time
            };
            return Add(emr);
        }

        public int engage_major_releaseDel(engage_major_releaseModel emm)
        {
            engage_major_release emr = new engage_major_release()
            {
                Id = emm.Id
            };
            return Delete(emr);
        }

        public List<engage_major_releaseModel> engage_major_releaseSelect()
        {
            List<engage_major_release> listr = Select();
            List<engage_major_releaseModel> list = new List<engage_major_releaseModel>();
            foreach (engage_major_release emm in listr)
            {
                engage_major_releaseModel emr = new engage_major_releaseModel()
                {
                    Id = emm.Id,
                    first_kind_id = emm.first_kind_id,
                    first_kind_name = emm.first_kind_name,
                    second_kind_id = emm.second_kind_id,
                    second_kind_name = emm.second_kind_name,
                    third_kind_id = emm.third_kind_id,
                    third_kind_name = emm.third_kind_name,
                    major_kind_id = emm.major_kind_id,
                    major_kind_name = emm.major_kind_name,
                    major_id = emm.major_id,
                    major_name = emm.major_name,
                    human_amount = emm.human_amount,
                    engage_type = emm.engage_type,
                    deadline = emm.deadline,
                    register = emm.register,
                    regist_time = emm.regist_time,
                    major_describe = emm.major_describe,
                    engage_required = emm.engage_required,
                    change_time = emm.change_time
                };
                list.Add(emr);
            }
            return list;
        }

        public engage_major_releaseModel engage_major_releaseSelectById(int id)
        {
            MyDbContext mc = new MyDbContext();
            List<engage_major_release> list = mc.engage_major_release.Where(
                e => e.Id == id).Select(e => e).ToList();
            engage_major_releaseModel erm = new engage_major_releaseModel()
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                major_kind_id = list[0].major_kind_id,
                major_kind_name = list[0].major_kind_name,
                major_id = list[0].major_id,
                major_name = list[0].major_name,
                human_amount = list[0].human_amount,
                engage_type = list[0].engage_type,
                deadline = list[0].deadline,
                register = list[0].register,
                regist_time = list[0].regist_time,
                major_describe = list[0].major_describe,
                engage_required = list[0].engage_required,
                change_time = list[0].change_time
            };
            return erm;
        }

        public int engage_major_releaseUpdate(engage_major_releaseModel emm)
        {
            engage_major_release emr = new engage_major_release()
            {
                Id = emm.Id,
                first_kind_id = emm.first_kind_id,
                first_kind_name = emm.first_kind_name,
                second_kind_id = emm.second_kind_id,
                second_kind_name = emm.second_kind_name,
                third_kind_id = emm.third_kind_id,
                third_kind_name = emm.third_kind_name,
                major_kind_id = emm.major_kind_id,
                major_kind_name = emm.major_kind_name,
                major_id = emm.major_id,
                major_name = emm.major_name,
                human_amount = emm.human_amount,
                engage_type = emm.engage_type,
                deadline = emm.deadline,
                register = emm.register,
                regist_time = emm.regist_time,
                major_describe = emm.major_describe,
                engage_required = emm.engage_required,
                change_time = emm.change_time
            };
            return Update(emr);
        }

        public List<engage_major_releaseModel> FenYe(int currentPage,int pageSize,out int rows)
        {
            var list = CreateContext().engage_major_release.AsNoTracking().OrderBy(e => e.Id);
            rows = list.Count();
            var fy = list
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            List<engage_major_releaseModel> elist = new List<engage_major_releaseModel>();
            foreach (engage_major_release emm in fy)
            {
                engage_major_releaseModel emr = new engage_major_releaseModel()
                {
                    Id = emm.Id,
                    first_kind_id = emm.first_kind_id,
                    first_kind_name = emm.first_kind_name,
                    second_kind_id = emm.second_kind_id,
                    second_kind_name = emm.second_kind_name,
                    third_kind_id = emm.third_kind_id,
                    third_kind_name = emm.third_kind_name,
                    major_kind_id = emm.major_kind_id,
                    major_kind_name = emm.major_kind_name,
                    major_id = emm.major_id,
                    major_name = emm.major_name,
                    human_amount = emm.human_amount,
                    engage_type = emm.engage_type,
                    deadline = emm.deadline,
                    register = emm.register,
                    changer = emm.changer,
                    regist_time = emm.regist_time,
                    major_describe = emm.major_describe,
                    engage_required = emm.engage_required,
                    change_time = emm.change_time
                };
                elist.Add(emr);
            }
            return elist;
        }
    }
}
