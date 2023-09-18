namespace WebApp.Models
{
    public class FakeDeviceRepository
    {
        private List<Device> devices { get; }

        public FakeDeviceRepository() 
        {
            devices = new List<Device>();
            devices.Add(new Device() { Id=1, Name="Vaskemaskine", Description="Bosh", Effect=23, RunTime=7000});
            devices.Add(new Device() { Id =2 , Name = "Elbil", Description = "Tesla", Effect =23 , RunTime = 7000});
            devices.Add(new Device() { Id = 3, Name = "GamerPC", Description = "Stationer PC", Effect = 23, RunTime = 7000 });
        }

        public List<Device> GetAllDevices() 
        {
            return devices.ToList();
        }
    }
}
