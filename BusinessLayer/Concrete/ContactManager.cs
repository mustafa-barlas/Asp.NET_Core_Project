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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal=contactDal;
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void Tadd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void Tdelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
           return _contactDal.GetByID(id);
        }

        public void Tupdate(Contact t)
        {
            _contactDal.Update(t);
        }

        public List<Contact> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
