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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal=portfolioDal;
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void Tadd(Portfolio t)
        {
           _portfolioDal.Insert(t);
        }

        public void Tdelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public void Tupdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
