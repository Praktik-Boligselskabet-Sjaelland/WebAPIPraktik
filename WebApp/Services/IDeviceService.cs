using WebAppLibrary.model;

namespace WebApp.Services
{
    public interface IDeviceService
    {
        List<Device> GetAll();
        Device GetById(int id);
        Device Create(Device newDevice);
        Device Delete(int id);
        Device Update(Device updatedDevice);
    }
}
