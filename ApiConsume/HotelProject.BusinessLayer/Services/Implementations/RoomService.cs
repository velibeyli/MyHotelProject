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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void Create(Room entity)
        {
            _roomRepository.Create(entity);
        }

        public void Delete(Room entity)
        {
            _roomRepository.Delete(entity);
        }

        public List<Room> GetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room GetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public void Update(Room entity)
        {
            _roomRepository.Update(entity);
        }
    }
}
