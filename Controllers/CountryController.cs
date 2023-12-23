using Microsoft.AspNetCore.Mvc;

namespace TechcareerDotnetBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        // GET: api/country
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> countries = CountryData.GetCountries();
            return countries;
        }

        // GET api/country/5
        [HttpGet("{count}")]
        public IEnumerable<string> Get(int count)
        {
            var countries = CountryData.GetCountries().Take(count);
            return countries;
        }
    }
}

