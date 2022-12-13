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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal=userMessageDal;
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
           return _userMessageDal.GetUserMessagesWithUser();
        }

        public void Tadd(UserMessage t)
        {
            _userMessageDal.Insert(t);  
        }

        public void Tdelete(UserMessage t)
        {
            _userMessageDal.Delete(t);
        }

        public UserMessage TGetByID(int id)
        {
            return _userMessageDal.GetByID(id); 
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public void Tupdate(UserMessage t)
        {
            _userMessageDal.Update(t);  
        }
    }
}
