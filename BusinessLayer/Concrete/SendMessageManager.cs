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
    public class SendMessageManager :IMessageService
    {
        IMessageDal _messageDal;

        public SendMessageManager(IMessageDal messageDal)
        {
            _messageDal=messageDal;
        }

        public void Tadd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void Tdelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
