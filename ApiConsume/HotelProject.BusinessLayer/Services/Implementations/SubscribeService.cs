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
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository _subscribeRepository;

        public SubscribeService(ISubscribeRepository subscribeRepository)
        {
            _subscribeRepository = subscribeRepository;
        }

        public void Create(Subscribe entity)
        {
            _subscribeRepository.Create(entity);
        }

        public void Delete(Subscribe entity)
        {
            _subscribeRepository.Delete(entity);
        }

        public List<Subscribe> GetAll()
        {
            return _subscribeRepository.GetAll();
        }

        public Subscribe GetById(int id)
        {
            return _subscribeRepository.GetById(id);
        }

        public void Update(Subscribe entity)
        {
            _subscribeRepository.Update(entity);
        }
    }
}
