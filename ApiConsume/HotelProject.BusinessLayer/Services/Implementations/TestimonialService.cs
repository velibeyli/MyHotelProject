using HotelProject.BusinessLayer.Services.Interfaces;
using HotelProject.DataAccessLayer.Repositories.Interfaces;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Services.Implementations
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void Create(Testimonial entity)
        {
            _testimonialRepository.Create(entity);
        }

        public void Delete(Testimonial entity)
        {
            _testimonialRepository.Delete(entity);
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialRepository.GetAll();
        }

        public Testimonial GetById(int id)
        {
            return _testimonialRepository.GetById(id);
        }

        public void Update(Testimonial entity)
        {
            _testimonialRepository.Update(entity);
        }
    }
}
