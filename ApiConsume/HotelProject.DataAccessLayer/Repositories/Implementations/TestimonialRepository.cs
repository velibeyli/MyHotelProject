using HotelProject.DataAccessLayer.DB;
using HotelProject.DataAccessLayer.Repositories.Interfaces;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Repositories.Implementations
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(Context context) : base(context)
        {
        }
    }
}
