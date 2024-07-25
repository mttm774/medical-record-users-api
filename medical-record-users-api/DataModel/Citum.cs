using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class Citum
{
    public decimal Id { get; set; }

    public DateTime? FechaCita { get; set; }

    public string? Estado { get; set; }

    public decimal? IdUsuario { get; set; }

    public decimal? IdMedico { get; set; }

    public DateTime? HoraFin { get; set; }

    public virtual Medico? IdMedicoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
