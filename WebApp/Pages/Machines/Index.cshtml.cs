using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Services;
using WebAppLibrary.model;

namespace WebApp.Pages.Machines
{
    public class IndexModel : PageModel
    {
        private IDeviceService _deviceService;

        public List<Device> Devices { get; set; }
       
        public IndexModel(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        public void OnGet()
        {
            Devices = _deviceService.GetAll();
        }
    }
}
