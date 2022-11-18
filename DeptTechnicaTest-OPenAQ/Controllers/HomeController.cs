using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DeptTechnicaTest_OPenAQ.Models;
using DeptTechnicaTest_OPenAQ.Interfaces;
using DeptTechnicaTest_OPenAQ.Models.DataModels;
using DeptTechnicaTest_OPenAQ.Models.ViewModels;
using Newtonsoft.Json;

namespace DeptTechnicaTest_OPenAQ.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAPIHelper _apiHelper;

    public HomeController(ILogger<HomeController> logger, IAPIHelper apiHelper)
    {
        _logger = logger;
        _apiHelper = apiHelper;
    }

    public async Task<IActionResult> Index()
    {
        string json = await _apiHelper.sendRequest("latest");
        LatestRoot data = JsonConvert.DeserializeObject<LatestRoot>(json);
        Home home = new Home(data);
        return View(home);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

