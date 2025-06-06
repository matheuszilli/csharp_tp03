using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CityBreaks.Web.Models;
using CityBreaks.Web.Services;

namespace CityBreaks.Web.Pages
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService _cityService;

        public CityDetailsModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public City? City { get; set; }

        public string SearchedName { get; set; } = string.Empty;


        public async Task<IActionResult> OnGetAsync(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return RedirectToPage("/Index");
            }

            SearchedName = name;

            City = await _cityService.GetByNameAsync(name);

            return Page();
        }
    }
}