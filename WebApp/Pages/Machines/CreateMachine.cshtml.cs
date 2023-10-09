using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Services;
using WebAppLibrary.model;

namespace WebApp.Pages.Machines
{
    public class CreateMachineModel : PageModel
    {
        private IDeviceService _deviceService;

        // properties
        [BindProperty]
        public Device Device { get; set; }

        public CreateMachineModel(IDeviceService deviceService)
        {
            _deviceService = deviceService;

        }

        public void OnGet()
        {
            Device = new Device();
        }

        public void OnPost()
        {
            _deviceService.Create(Device);
        }
    }
}
