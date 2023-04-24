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
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;

        public StaffService(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public void Create(Staff entity)
        {
            _staffRepository.Create(entity);
        }

        public void Delete(Staff entity)
        {
            _staffRepository.Delete(entity);
        }

        public List<Staff> GetAll()
        {
            return _staffRepository.GetAll();
        }

        public Staff GetById(int id)
        {
            return _staffRepository.GetById(id);
        }

        public void Update(Staff entity)
        {
            _staffRepository.Update(entity);
        }
    }
}
