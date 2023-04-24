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
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _ServiceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }

        public void Create(Service entity)
        {
            _ServiceRepository.Create(entity);
        }

        public void Delete(Service entity)
        {
            _ServiceRepository.Delete(entity);
        }

        public List<Service> GetAll()
        {
            return _ServiceRepository.GetAll();
        }

        public Service GetById(int id)
        {
            return _ServiceRepository.GetById(id);
        }

        public void Update(Service entity)
        {
            _ServiceRepository.Update(entity);
        }
    }
}
