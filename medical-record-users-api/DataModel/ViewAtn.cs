using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class ViewAtn
{
    public DateTime? Fecha { get; set; }

    public string? TipoAtencion { get; set; }

    public string? Atn { get; set; }

    public decimal ProfesionalMed { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Especialidad { get; set; }
}
