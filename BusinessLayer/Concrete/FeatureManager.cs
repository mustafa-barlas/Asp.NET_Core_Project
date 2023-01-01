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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal=featureDal;
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void Tadd(Feature t)
        {
           _featureDal.Insert(t);   
        }

        public void Tdelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id); 
        }

        public void Tupdate(Feature t)
        {
            _featureDal.Update(t);
        }

        public List<Feature> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
