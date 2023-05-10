using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aion.Models;
using Aion.Data;
using Microsoft.AspNetCore.Authorization;

namespace Aion.Controllers;

[Authorize(Roles = "Administrador")]
public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    private readonly ApplicationDbContext _context;

    public AdminController(ILogger<AdminController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Professores()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Professores(string name, string email, string phone, string subjects)
    {
        // Cria e cadastra o professor
        string userName = name.Split(' ')[0] + "." + name.Split(' ')[name.Split(' ').Count() - 1];
        Professor prof = new()
        {
            Nome = name,
            Email = email,
            Telefone = phone,
            Usuario = userName,
            Senha = "@Aion123"
        };
        _context.professores.Add(prof);
        _context.SaveChanges();

        foreach (var subject in subjects.Split(','))
        {
            //int disciplinaId = _context.Disciplinas.FirstOrDefault(d => d.Nome.Equals(subject)).Id;
            var formacao = new Formacao()
            {
                ProfessorId = prof.Id,
                DisciplinaId = _context.disciplinas.FirstOrDefault(d => d.Nome.Equals(subject)).Id
            };
            _context.formacoes.Add(formacao);
        }
        _context.SaveChanges();
        
        return View();
    }

    public IActionResult Horarios()
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
