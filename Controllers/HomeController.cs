using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_10__Series_en_Home_Martinez_Palachi.Models;

namespace TP_10__Series_en_Home_Martinez_Palachi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }


    public List<Actores> VerDetalleActores(int IdSerie)
    {
         ViewBag.Actores = BD.ObtenerActores(IdSerie);
        return ViewBag.Actores;
    }

    public List<Temporadas> VerDetallesTemporadas(int IdSerie)
    {
        ViewBag.Temporadas = BD.ObtenerTemporadas(IdSerie);
        return ViewBag.Temporadas;
    }

    public List<Series> MostrarMasInfo()
    {
        ViewBag.Info = BD.ObtenerSeries();
        return ViewBag.Info;
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
