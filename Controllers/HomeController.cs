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


    public Actores VerDetalleActores(int IdActor)
    {
        List<Actores> Actores = BD.ObtnerActores(IdActor);
        return Actores[IdActor];
    }

    public List<Temporadas> VerDetallesTemporadas(int IdSerie)
    {
        List<Temporadas> Temporadas = BD.ObtnerTemporadas(IdSerie);
        return Temporadas;
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
