using Microsoft.AspNetCore.Mvc;
using WBWalks.Models.Domain;

namespace WBWalks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                   Id = Guid.NewGuid(),
                   Name = "Wellington",
                   Code = "WLG",
                   Area = 2775,
                   Lat = -1.8822,
                   Long = 299.88,
                   population = 5000000

                 },
                new Region
                {

                   Id = Guid.NewGuid(),
                   Name = "Auckland",
                   Code = "AUCK",
                   Area = 27755,
                   Lat = -1.8822,
                   Long = 299.88,
                   population = 5000000
                }
            };
            return Ok(regions);
        }
    }
}
