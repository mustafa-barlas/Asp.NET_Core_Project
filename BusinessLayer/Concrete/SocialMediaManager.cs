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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal=socialMediaDal;
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }

        public void Tadd(SocialMedia t)
        {
            _socialMediaDal.Insert(t);  
        }

        public void Tdelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetByID(id); 
        }

        public void Tupdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }

        public List<SocialMedia> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
