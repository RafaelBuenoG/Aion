﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aion.Models;
using Aion.Data;

namespace Aion.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var disciplinas = _context.Disciplinas;
        return View(disciplinas);
    }

    public IActionResult Sobre()
    {
        var disciplinas = _context.Disciplinas;
        return View(disciplinas);
    }

    public IActionResult Planos()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
