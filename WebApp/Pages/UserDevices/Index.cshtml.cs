using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages.UserDevices
{
    public class IndexModel : PageModel
    {
        private FakeDeviceRepository repo;

        public List<Device> Device { get; private set; }

        public IndexModel()
        {
            repo = new FakeDeviceRepository();
        }


        public void OnGet()
        {
            Device = repo.GetAllDevices();
        }
    }
}
