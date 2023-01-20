using System;
using System.Collections.Generic;

namespace Unidad4.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public int Identificador { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Estado { get; set; } = null!;
}
