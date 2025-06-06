using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CityBreaks.Web.Models;
using CityBreaks.Web.Services;

namespace CityBreaks.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICityService _cityService;

        public IndexModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public List<City> Cities { get; set; } = new List<City>();

        public async Task OnGetAsync()
        {
            Cities = await _cityService.GetAllAsync();
        }
    }
}