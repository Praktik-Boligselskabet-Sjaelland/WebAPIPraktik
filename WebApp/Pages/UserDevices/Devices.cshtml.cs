using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using WebApp.Services;
using WebAppLibrary.model;

namespace WebApp.Pages
{
    public class DevicesModel : PageModel
    {
        private IDeviceService _deviceService;
       
        public List<Device> Devices { get; private set; }
        
        /*public IndexModel(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }*/
        public void OnGet()
        {
            Devices = _deviceService.GetDevices();
        }
    }
}
