using HotelListingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAPI.Controllers
{
    [ApiVersion("2.0", Deprecated =true)]
    //[Route("api/{v:apiversion}/Country")]
    [Route("api/Country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public CountryV2Controller(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {

            return Ok(_databaseContext.Countries);
        }
    }
}
