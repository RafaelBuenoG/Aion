using Aion.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Aion.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Atribuicao> atribuicoes { get; set; }

    public DbSet<Curso> cursos { get; set; }

    public DbSet<Disciplina> Disciplinas { get; set; }

    public DbSet<Disponibilidade> disponibilidades { get; set; }

    public DbSet<Grade> grades { get; set; }

    public DbSet<GradeDisciplinas> gradeDisciplinas { get; set; }

    public DbSet<PeriodoLetivo> periodoLetivos { get; set; }

    public DbSet<Professor> professores { get; set; }
}
