using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DeptTechnicaTest_OPenAQ.Interfaces;
using DeptTechnicaTest_OPenAQ.Models;
using DeptTechnicaTest_OPenAQ.Models.DataModels;
using DeptTechnicaTest_OPenAQ.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeptTechnicaTest_OPenAQ.Controllers
{
    public class CountryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAPIHelper _apiHelper;

        public CountryController(ILogger<HomeController> logger, IAPIHelper apiHelper)
        {
            _logger = logger;
            _apiHelper = apiHelper;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            Country country = new Country();
            string json = await _apiHelper.sendRequest("countries");
            CountryRoot data = JsonConvert.DeserializeObject<CountryRoot>(json);
            country.CountriesDDL = data.results;
            return View(country); 
        }

        public async Task<IActionResult> searchByID(int id)
        {
            Country country = new Country();
            string json = await _apiHelper.sendRequest("countries");
            CountryRoot data = JsonConvert.DeserializeObject<CountryRoot>(json);
            country.CountriesDDL = data.results;
            return View(country);
        }

        public async Task<IActionResult> SearchByName(int id)
        {
            Country country = new Country();
            string json = await _apiHelper.sendRequest("countries");
            CountryRoot data = JsonConvert.DeserializeObject<CountryRoot>(json);
            country.CountriesDDL = data.results;
            return View(country);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

