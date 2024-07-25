using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class RipsU
{
    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string? CodigoEps { get; set; }

    public string? Regimen { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public int? Edad { get; set; }

    public int? UnMedida { get; set; }

    public string? Sexo { get; set; }

    public string Departamento { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string? Zona { get; set; }

    public DateTime? Fecha { get; set; }
}
