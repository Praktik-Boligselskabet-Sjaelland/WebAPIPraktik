namespace WebApp.Models
{
    public class FakeDeviceRepository
    {
        private List<Device> _devices;

        public FakeDeviceRepository() 
        {
            _devices = new List<Device>();
            _devices.Add(new Device() { Id=1, Name="Vaskemaskine", Description="Bosh", Effect=23, RunTime=7000});
            _devices.Add(new Device() { Id =2 , Name = "Elbil", Description = "Tesla", Effect =23 , RunTime = 7000});
            _devices.Add(new Device() { Id = 3, Name = "GamerPC", Description = "Stationer PC", Effect = 23, RunTime = 7000 });
        }
    }
}
