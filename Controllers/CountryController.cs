using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Business;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private ICountries countries;
        public CountryController(ICountries countries)
        {
            this.countries = countries;

        }

        [HttpGet]
        public JsonResult getCountry()
        {
            var country = countries.GetCountries().ToList();

            return Json(country);


        }
    }
}
