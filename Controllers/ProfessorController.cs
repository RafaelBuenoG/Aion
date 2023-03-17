using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aion.Models;

namespace Aion.Controllers;

// Pesquisar mais sobre (PatoRestaurant)
// [Authorize(Roles = "Administrador")] Especifica que so pode acessar o controller quem tiver o cargo de admin e funcionario
public class ProfessorController : Controller
{
    private readonly ILogger<ProfessorController> _logger;

    public ProfessorController(ILogger<ProfessorController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
