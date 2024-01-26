using ChartExample.Models.Chart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebApp.Models;
using WebApp.Services.Interfaces;
using WebApp.Services.PowerUseService;

namespace WebApp.Pages.Charts
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]

        public ChartJs Chart { get; set; }
        public string ChartJson { get; set; }

        public int FilterCriteria { get; set; }

        public List<PowerUse> PowerUse { get; private set; }

        public List<User> Users { get; private set; }

        private IPowerUseService _powerService;

        private IUserService _userService;

        public IndexModel(IPowerUseService powerUseService, IUserService userService) 
        {
            this._powerService = powerUseService;
            this._userService = userService;
        }

        public void OnGet()
        {

            // Ref: https://www.chartjs.org/docs/latest/
            var chartData = @"
        {
            type: 'bar',
            responsive: true,
            data:
            {
                labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
                datasets: [{
                    label: '# of Votes',
                    data: [12, 19, 3, 5, 2, 3],
                    backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)',
                    'rgba(75, 192, 192, 0.2)',
                    'rgba(153, 102, 255, 0.2)',
                    'rgba(255, 159, 64, 0.2)'
                        ],
                    borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                    'rgba(255, 159, 64, 1)'
                        ],
                    borderWidth: 1
                }]
            },
            options:
            {
                scales:
                {
                    yAxes: [{
                        ticks:
                        {
                            beginAtZero: true
                        }
                    }]
                }
            }
        }";

            Chart = JsonConvert.DeserializeObject<ChartJs>(chartData);
            ChartJson = JsonConvert.SerializeObject(Chart, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            });

            if (FilterCriteria > 0 && FilterCriteria <= 3)
            {
                PowerUse = _powerService.GetPowerUseFromUserId(FilterCriteria);
            }
            else
                PowerUse = _powerService.GetPowerUseFromUserId(1);

            Users = _userService.GetUsers();

        }
    }
}
