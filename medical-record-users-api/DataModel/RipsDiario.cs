using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class RipsDiario
{
    public DateTime? Fecha { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public string? Apellidos { get; set; }

    public string? Nombres { get; set; }

    public string? CodigoEntidadAdm { get; set; }

    public string? TipoUsuario { get; set; }

    public int Edad { get; set; }

    public int? UnidadMedidaEdad { get; set; }

    public string Sexo { get; set; } = null!;

    public string? TipoStakeholder { get; set; }

    public string? ProgramaProceso { get; set; }

    public string Departamento { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string? Zona { get; set; }

    public string? Cups { get; set; }

    public string? Procedimiento { get; set; }

    public string CodigoCie10 { get; set; } = null!;

    public string DiagnosticoPrincipal { get; set; } = null!;

    public string? Finalidad { get; set; }

    public string? CausaExt { get; set; }

    public string? TipoDiagnostico { get; set; }

    public string Eps { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Medico { get; set; }

    public string Semestre { get; set; } = null!;
}
