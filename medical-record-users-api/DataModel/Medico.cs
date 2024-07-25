using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class Medico
{
    public decimal Id { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? RegistroMedico { get; set; }

    public string? Especialidad { get; set; }

    public byte[]? Firma { get; set; }

    public byte[]? Foto { get; set; }

    public string? Email { get; set; }

    public string Estado { get; set; } = null!;

    public string? Genero { get; set; }

    public decimal? UserId { get; set; }

    public virtual ICollection<Atencion> Atencions { get; set; } = new List<Atencion>();

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual User? User { get; set; }
}
