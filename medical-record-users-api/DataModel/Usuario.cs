using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class Usuario
{
    public decimal Id { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string? EstadoCivil { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string? Ocupacion { get; set; }

    public string? Pais { get; set; }

    public string? Departamento { get; set; }

    public string? Municipio { get; set; }

    public string? BarrioVereda { get; set; }

    public string? Zona { get; set; }

    public string? Direccion { get; set; }

    public string? Estrato { get; set; }

    public string? TelefonoContacto { get; set; }

    public string? TelefonoResidencia { get; set; }

    public string? NombresPadre { get; set; }

    public string? NombresMadre { get; set; }

    public string? NombresAcudiente { get; set; }

    public string? TelefonoPadres { get; set; }

    public string? TelefonoAcudiente { get; set; }

    public string? NombreEps { get; set; }

    public string? CodigoEps { get; set; }

    public string? Regimen { get; set; }

    public string? NombreIps { get; set; }

    public string? CodigoIps { get; set; }

    public string? TipoIdentificacionIps { get; set; }

    public string? Discapacidad { get; set; }

    public string? GrupoEtnico { get; set; }

    public string? Observaciones { get; set; }

    public byte[]? Foto { get; set; }

    public string? Email { get; set; }

    public string Estado { get; set; } = null!;

    public string? Localidad { get; set; }

    public string? Area { get; set; }

    public string? Posicion { get; set; }

    public string? AceptacionConsentimiento { get; set; }

    public string? AceptacionDatosPersonales { get; set; }

    public string? ParentescoAcudiente { get; set; }

    public string? Recuperacion { get; set; }

    public virtual ICollection<Atencion> Atencions { get; set; } = new List<Atencion>();

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual ICollection<HistoricoUsuario> HistoricoUsuarios { get; set; } = new List<HistoricoUsuario>();
}
