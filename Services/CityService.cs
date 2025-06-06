using Microsoft.EntityFrameworkCore;
using CityBreaks.Web.Data;
using CityBreaks.Web.Models;

namespace CityBreaks.Web.Services
{
    public class CityService : ICityService
    {
        private readonly CityBreaksContext _context;
        public CityService(CityBreaksContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllAsync()
        {

            return await _context.Cities
                .Include(c => c.Country)
                .Include(c => c.Properties)
                .OrderBy(c => c.Name)
                .ToListAsync();
        }
    }
}