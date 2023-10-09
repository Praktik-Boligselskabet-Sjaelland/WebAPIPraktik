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
            _devices = FakeDeviceRepository.GetFakeDevices();
            nextId= nextId + 1;
        }
        public Device Create(Device newDevice)
        {
            newDevice.Id = nextId;
            _devices.Add(newDevice);

            return newDevice;
        }

        public Device Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Device GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetAll()
        {
            return new List<Device>(_devices);
        }

        public Device Update(Device updatedDevice)
        {
            throw new NotImplementedException();
        }
    }
}
