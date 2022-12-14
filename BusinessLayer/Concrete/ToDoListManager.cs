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
    public class ToDoListManager : IToDoListService
    {
        IToDoList _toDoListDal;

        public ToDoListManager(IToDoList toDoListDal)
        {
            _toDoListDal=toDoListDal;
        }

        public void Tadd(ToDoList t)
        {
            _toDoListDal.Insert(t);
        }

        public void Tdelete(ToDoList t)
        {
            _toDoListDal.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _toDoListDal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void Tupdate(ToDoList t)
        {
            _toDoListDal.Update(t);
        }
    }
}
