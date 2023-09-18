using WebApp.Models;
using WebAppLibrary.model;

namespace WebApp.Services
{
    public class DeviceService : IDeviceService
    {

        private readonly List<Device> _devices;
        private static int nextId = 0;

        public DeviceService() 
        {
            _devices = FakeDeviceRepository.GetDevices();
            nextId= nextId + 1;
        }
        public Device Create(Device newDevice)
        {
            throw new NotImplementedException();
        }

        public Device Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Device GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetDevices()
        {
            return new List<Device>(_devices);
        }

        public Device Update(Device updatedDevice)
        {
            throw new NotImplementedException();
        }
    }
}
