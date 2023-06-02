using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aion.Models;
using Aion.Data;
using Microsoft.AspNetCore.Authorization;

namespace Aion.Controllers;

[Authorize(Roles = "Professor")]
public class ProfessorController : Controller
{
    private readonly ILogger<ProfessorController> _logger;

    private readonly ApplicationDbContext _context;

    public ProfessorController(ILogger<ProfessorController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RegDados()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult RegDados(string week)
    {
        return RedirectToAction(nameof(RegDados2), week);
    }

    public IActionResult RegDados2()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RegDados2(string week, string horaInicio, string horaFim)
    {
        Disponibilidade disp = new()
        {
            // DiaSemana = week,
            HoraInicio = horaInicio,
            HoraFim = horaFim,
            // ProfessorId = ;
        };
        _context.disponibilidades.Add(disp);
        _context.SaveChanges();
        return RedirectToAction(nameof(RegDadosSuccess));
    }

    public IActionResult RegDadosSuccess()
    {
        return View();
    }

    public IActionResult HorarioFinal()
    {
        return View();
    }

    public IActionResult Config()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
