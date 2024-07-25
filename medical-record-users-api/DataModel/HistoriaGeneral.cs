using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class HistoriaGeneral
{
    public decimal Id { get; set; }

    /// <summary>
    /// 01 = Atención del parto (puerperio) 02 = Atención del recién nacido 03 = Atención en planificación familiar 04 = Detección de alteraciones De crecimiento y desarrollo Del menor de diez años 05 = Detección de alteración del desarrollo joven 06 = Detección de alteraciones del embarazo 07 = Detección de alteraciones del adulto 08 = Detección de alteraciones de agudeza visual 09 = Detección de enfermedad profesional &lt;&lt;10 = No aplica&gt;&gt;
    /// </summary>
    public string? Finalidad { get; set; }

    /// <summary>
    /// DD/MM/YYYY
    /// </summary>
    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaEgreso { get; set; }

    /// <summary>
    /// 20 alfaanumérico (Generación autom o manual)
    /// </summary>
    public string? NumeroFactura { get; set; }

    public DateTime? FechaExpedFactura { get; set; }

    /// <summary>
    /// Se registra el primer día del mes en que se expide la factura
    /// </summary>
    public DateTime? FechaInicioPeriodoFactura { get; set; }

    /// <summary>
    /// Se registra el último día del mes en que se expide la factura
    /// </summary>
    public DateTime? FechaFinalPeriodoFactura { get; set; }

    public decimal IdAtencion { get; set; }

    public string? Cie10 { get; set; }

    public string? Causaexterna { get; set; }

    public string? Tipodiagnostico { get; set; }

    public string? Finalidadetalle { get; set; }

    public virtual ICollection<DetalleHistorium> DetalleHistoria { get; set; } = new List<DetalleHistorium>();

    public virtual ICollection<HistoriaProcedimiento> HistoriaProcedimientos { get; set; } = new List<HistoriaProcedimiento>();

    public virtual Atencion IdAtencionNavigation { get; set; } = null!;
}
