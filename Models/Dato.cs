using System;
using System.Collections.Generic;

namespace Tp_Barengo.Models;

public partial class Dato
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Autor { get; set; }

    public string? Editorial { get; set; }

    public string? Genero { get; set; }

    public string? Ubicacion { get; set; }

    public int? Copias { get; set; }
}
