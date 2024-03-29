﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService 
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal=testimonialDal;
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();   
        }

        public void Tadd(Testimonial t)
        {
            _testimonialDal.Insert(t);  
        }

        public void Tdelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public void Tupdate(Testimonial t)
        {
            _testimonialDal.Update(t);  
        }

        public List<Testimonial> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
