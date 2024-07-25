using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class Atencion
{
    public decimal Id { get; set; }

    /// <summary>
    /// 1=Ambulatoria 2=Hospitalizado 3=Urgencias
    /// </summary>
    public string? TipoAtencion { get; set; }

    /// <summary>
    /// Médico/Enfermería/Odontología/Psicología/Especialista
    /// </summary>
    public string? TipoHistoriaEspecialidad { get; set; }

    /// <summary>
    /// 1 = Primera Vez, 2 =Control
    /// </summary>
    public string? Frecuencia { get; set; }

    public decimal ProfesionalMed { get; set; }

    public decimal IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ICollection<HistoriaGeneral> HistoriaGenerals { get; set; } = new List<HistoriaGeneral>();

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual Medico ProfesionalMedNavigation { get; set; } = null!;
}
