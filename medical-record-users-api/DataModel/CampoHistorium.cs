using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class CampoHistorium
{
    public decimal Id { get; set; }

    public string SeccionPpal { get; set; } = null!;

    public string NombreCampo { get; set; } = null!;

    public string TituloCampo { get; set; } = null!;

    /// <summary>
    /// T = Texto, L = Lista, M = Múltiple
    /// </summary>
    public string TipoCampo { get; set; } = null!;

    public string? Lista { get; set; }

    /// <summary>
    /// MG= Medicina General, EN = Enfermería, PS = Psicología, DE = Deportología
    /// </summary>
    public string TipoHistoria { get; set; } = null!;

    /// <summary>
    /// S = Si, N = No
    /// </summary>
    public string Obligatorio { get; set; } = null!;

    /// <summary>
    /// A = Activo, I = Inactivo
    /// </summary>
    public string Estado { get; set; } = null!;

    public decimal? Orden { get; set; }

    public virtual ICollection<DetalleHistorium> DetalleHistoria { get; set; } = new List<DetalleHistorium>();
}
