using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aion.Models;

[Table("Disponibilidade")]
public class Disponibilidade
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string DiaSemana { get; set; }

    public string HoraInicio { get; set; }

    public string HoraFim { get; set; }

    public int ProfessorId { get; set; }
}
