using System.Xml.Linq;
using WebAppLibrary.model;

namespace WebApp.Models
{
    public class FakeDeviceRepository
    {
        /* public FakeDeviceRepository()
         {
             devices = new List<Device>();
             devices.Add(new Device() { Id = 1, Name = "Vaskemaskine", Description = "Bosh", Effect = 23, RunTime = 7000 });
             devices.Add(new Device() { Id = 2, Name = "Elbil", Description = "Tesla", Effect = 23, RunTime = 7000 });
             devices.Add(new Device() { Id = 3, Name = "GamerPC", Description = "Stationer PC", Effect = 23, RunTime = 7000 });
         }
        */

        private static List<Device> _devices = new List<Device>()
        {
            new Device( 1, "Vaskemaskine", "Bosh", 23,  7000),
            new Device(2, "Elbil", "Tesla", 23, 7000),
            new Device(3, "Gamer PC", "Stationer computer", 23, 7000)

        };

        public static List<Device> GetFakeDevices()
        {
            return new List<Device>(_devices);
        }
    }
}
