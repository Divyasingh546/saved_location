using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saved__Locations.Models;

namespace Saved__Locations.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLocation()
        {
            // Simulate retrieving location data (replace with your logic)
            var location = new LocationInfo
            {
                Latitude = 40.7128, // Replace with actual latitude
                Longitude = -74.0060, // Replace with actual longitude
                Address = "New York, NY" // Replace with actual address
            };

            return Ok(location);
        }
    }

}
