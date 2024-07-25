using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class ReporteBai
{
    public string Identificacion { get; set; } = null!;

    public string? Cie10 { get; set; }

    public string DiagnosticoCie10 { get; set; } = null!;

    public string? DiagnosticoSintomatico { get; set; }

    public string Especialidad { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}
