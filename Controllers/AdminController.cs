using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aion.Models;
using Aion.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

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

    public IActionResult Materias()
    {

        List<Disciplina> materias = _context.disciplinas.ToList();
        ViewData["hasMateria"] = materias.Count() < 1 ? false : true;
        return View(materias);
    }

    [HttpPost]
    public IActionResult Materias(string name)
    {
        Disciplina sub = new()
        {
            Nome = name
        };
        _context.disciplinas.Add(sub);
        _context.SaveChanges();

        // Recarrega automáticamente a página quando adicionado
        List<Disciplina> materias = _context.disciplinas.ToList();
        return View(materias);
    }

    public IActionResult Professores()
    {
        ViewData["Materias"] = _context.disciplinas.OrderBy(m => m.Nome);
        List<Professor> professores = _context.professores.ToList();
        ViewData["hasProfessor"] = professores.Count() < 1 ? false : true;
        return View(professores);
    }

    [HttpPost]
    public IActionResult Professores(string name, string email, string phone, string subjects)
    {
        // Cria e cadastra o professor
        //string userName = name.Split(' ')[0] + "." + name.Split(' ')[name.Split(' ').Count() - 1];
        Professor prof = new()
        {
            Nome = name,
            Email = email,
            Telefone = phone,
            Usuario = "userName",
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
        
        // Recarrega automáticamente a página quando adicionado
        ViewData["Materias"] = _context.disciplinas.OrderBy(m => m.Nome);
        List<Professor> professores = _context.professores.ToList();
        return View(professores);
    }

    [HttpPost, ActionName("DeleteMateria")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteMateria(int id)
    {
        var disciplina = _context.disciplinas.Find(id);
        _context.disciplinas.Remove(disciplina);
        _context.SaveChanges();
        return RedirectToAction(nameof(Materias));
    }

    [HttpPost, ActionName("DeleteProfessor")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteProfessor(int id)
    {
        var professor = _context.professores.Find(id);
        _context.professores.Remove(professor);
        _context.SaveChanges();
        return RedirectToAction(nameof(Professores));
    }

    public IActionResult EditProfessor(int id)
    {
        
        return RedirectToAction(nameof(Professores));
    }

    public IActionResult Cursos()
    {
        List<Curso> cursos = _context.cursos.ToList();
        ViewData["hasCurso"] = cursos.Count() < 1 ? false : true;
        return View(cursos);
    }

    [HttpPost]
    public IActionResult Cursos(string name, string type, int qtySem)
    {
        if (ModelState.IsValid)
        {
            Curso course = new()
            {
                Nome = name,
                Tipo = type,
                QtdeSem = qtySem
            };
            _context.cursos.Add(course);
            _context.SaveChanges();
        }

        // Recarrega automáticamente a página quando adicionado
        List<Curso> cursos = _context.cursos.ToList();
        return View(cursos);
    }
    
    [HttpPost, ActionName("DeleteCurso")]
    public IActionResult DeleteCurso(int id)
    {
        var curso = _context.cursos.Find(id);
        _context.cursos.Remove(curso);
        _context.SaveChanges();
        return RedirectToAction(nameof(Cursos));
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
