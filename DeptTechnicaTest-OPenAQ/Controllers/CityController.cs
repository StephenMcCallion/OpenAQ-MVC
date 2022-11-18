using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
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
    public class CityController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAPIHelper _apiHelper;

        public CityController(ILogger<HomeController> logger, IAPIHelper apiHelper)
        {
            _logger = logger;
            _apiHelper = apiHelper;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            string json = await _apiHelper.sendRequest("cities");
            CityRoot data = JsonConvert.DeserializeObject<CityRoot>(json);
            City city = new City(data);
            return View(city);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

