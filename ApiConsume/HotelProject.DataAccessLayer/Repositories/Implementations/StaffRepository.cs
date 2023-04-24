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
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(Context context) : base(context)
        {
        }
    }
}
