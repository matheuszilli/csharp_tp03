using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CityBreaks.Web.Models;
using CityBreaks.Web.Services;
using CityBreaks.Web.Data;

namespace CityBreaks.Web.Pages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly ICityService _cityService;
        private readonly CityBreaksContext _context;

        public CreatePropertyModel(ICityService cityService, CityBreaksContext context)
        {
            _cityService = cityService;
            _context = context;
        }
        
        [BindProperty]
        public Property Property { get; set; } = new Property();

        public SelectList CitiesSelectList { get; set; } = new SelectList(new List<City>(), "Id", "Name");

        public async Task OnGetAsync()
        {
            await LoadCitiesAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                await LoadCitiesAsync();
                return Page();
            }

            try
            {
                await _context.Properties.AddAsync(Property);

                await _context.SaveChangesAsync();

                var city = await _context.Cities.FindAsync(Property.CityId);
                if (city != null)
                {
                    return RedirectToPage("/CityDetails", new { name = city.Name });
                }

                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Erro ao salvar a propriedade: {ex.Message}");
                await LoadCitiesAsync();
                return Page();
            }
        }

        private async Task LoadCitiesAsync()
        {
            var cities = await _cityService.GetAllAsync();

            CitiesSelectList = new SelectList(
                cities.Select(c => new
                {
                    Id = c.Id,
                    DisplayName = $"{c.Name} ({c.Country.CountryName})"
                }),
                "Id",
                "DisplayName"
            );
        }
    }
}