using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class ViewAtnPsicoPedagogium
{
    public decimal No { get; set; }

    public string? NombreDelEstudiante { get; set; }

    public string Documento { get; set; } = null!;

    public int? Edad { get; set; }

    public string? Celular { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? MotivoConsulta { get; set; }

    public string? ItemConsulta { get; set; }

    public string? Carrera { get; set; }

    public string? Observaciones { get; set; }

    public string? Compromisos { get; set; }

    public string? Avances { get; set; }

    public string? EvaluacionProceso { get; set; }

    public decimal IdCampo { get; set; }

    public decimal IdHistoria { get; set; }

    public DateTime? Fecha { get; set; }
}
