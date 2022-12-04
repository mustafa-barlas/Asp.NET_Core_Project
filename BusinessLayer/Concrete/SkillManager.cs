using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal=skillDal;
        }

        public List<Skill> TGetList()
        {
           return _skillDal.GetList();
        }

        public void Tadd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void Tdelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void Tupdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
