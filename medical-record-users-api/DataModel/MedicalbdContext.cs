using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace medical_record_users_api.DataModel;

public partial class MedicalbdContext : DbContext
{
    public MedicalbdContext()
    {
    }

    public MedicalbdContext(DbContextOptions<MedicalbdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anexo> Anexos { get; set; }

    public virtual DbSet<Atencion> Atencions { get; set; }

    public virtual DbSet<CampoHistorium> CampoHistoria { get; set; }

    public virtual DbSet<Casospsicopedagogia2021> Casospsicopedagogia2021s { get; set; }

    public virtual DbSet<Cie10> Cie10s { get; set; }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<DetalleHistorium> DetalleHistoria { get; set; }

    public virtual DbSet<Dominio> Dominios { get; set; }

    public virtual DbSet<Dxsintomatico> Dxsintomaticos { get; set; }

    public virtual DbSet<EventTracking> EventTrackings { get; set; }

    public virtual DbSet<HistoriaGeneral> HistoriaGenerals { get; set; }

    public virtual DbSet<HistoriaProcedimiento> HistoriaProcedimientos { get; set; }

    public virtual DbSet<HistoricoUsuario> HistoricoUsuarios { get; set; }

    public virtual DbSet<Medico> Medicos { get; set; }

    public virtual DbSet<ReporteBai> ReporteBais { get; set; }

    public virtual DbSet<ResumenHistorium> ResumenHistoria { get; set; }

    public virtual DbSet<RipsAc> RipsAcs { get; set; }

    public virtual DbSet<RipsAf> RipsAfs { get; set; }

    public virtual DbSet<RipsDiario> RipsDiarios { get; set; }

    public virtual DbSet<RipsU> RipsUs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<ViewAtention> ViewAtentions { get; set; }

    public virtual DbSet<ViewAtentionRemision> ViewAtentionRemisions { get; set; }

    public virtual DbSet<ViewAtn> ViewAtns { get; set; }

    public virtual DbSet<ViewAtnPsicoPedagogium> ViewAtnPsicoPedagogia { get; set; }

    public virtual DbSet<ViewLugare> ViewLugares { get; set; }

    public virtual DbSet<ViewReportAttention> ViewReportAttentions { get; set; }

    public virtual DbSet<ViewReporteMorbilidad> ViewReporteMorbilidads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=medical-records-db.database.windows.net;Database=medicalbd;User Id=medicalapi;Password=Miso2024*");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anexo>(entity =>
        {
            entity.ToTable("Anexo");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Anexo1).HasColumnName("Anexo");
            entity.Property(e => e.IdAtencion).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NombreArchivo).IsUnicode(false);
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.TipoAnexo).IsUnicode(false);

            entity.HasOne(d => d.IdAtencionNavigation).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.IdAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anexo_Atencion");
        });

        modelBuilder.Entity<Atencion>(entity =>
        {
            entity.ToTable("Atencion");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Frecuencia)
                .IsUnicode(false)
                .HasComment("1 = Primera Vez, 2 =Control");
            entity.Property(e => e.IdUsuario).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProfesionalMed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TipoAtencion)
                .IsUnicode(false)
                .HasComment("1=Ambulatoria 2=Hospitalizado 3=Urgencias");
            entity.Property(e => e.TipoHistoriaEspecialidad)
                .IsUnicode(false)
                .HasComment("Médico/Enfermería/Odontología/Psicología/Especialista");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Atencions)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atencion_Usuario");

            entity.HasOne(d => d.ProfesionalMedNavigation).WithMany(p => p.Atencions)
                .HasForeignKey(d => d.ProfesionalMed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atencion_Medico");
        });

        modelBuilder.Entity<CampoHistorium>(entity =>
        {
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("A = Activo, I = Inactivo");
            entity.Property(e => e.Lista)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NombreCampo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Obligatorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("S = Si, N = No");
            entity.Property(e => e.Orden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("orden");
            entity.Property(e => e.SeccionPpal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoCampo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("T = Texto, L = Lista, M = Múltiple");
            entity.Property(e => e.TipoHistoria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("MG= Medicina General, EN = Enfermería, PS = Psicología, DE = Deportología");
            entity.Property(e => e.TituloCampo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Casospsicopedagogia2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("casospsicopedagogia2021");

            entity.Property(e => e.Avances)
                .IsUnicode(false)
                .HasColumnName("avances");
            entity.Property(e => e.Compromisos)
                .IsUnicode(false)
                .HasColumnName("compromisos");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hora");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Idatencion)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idatencion");
            entity.Property(e => e.Idhistoria)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idhistoria");
            entity.Property(e => e.Itemconsulta)
                .IsUnicode(false)
                .HasColumnName("itemconsulta");
            entity.Property(e => e.Motivo)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Startwithdetail)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("startwithdetail");
        });

        modelBuilder.Entity<Cie10>(entity =>
        {
            entity.HasKey(e => e.Valor).HasName("PK__Cie10__40B8076E1E2CEDA2");

            entity.ToTable("Cie10");

            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valor");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Citum>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FechaCita).HasColumnType("datetime");
            entity.Property(e => e.HoraFin).HasColumnType("datetime");
            entity.Property(e => e.IdMedico).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdUsuario).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.IdMedicoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdMedico)
                .HasConstraintName("FK_Cita_Medico");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_Cita_Usuario");
        });

        modelBuilder.Entity<DetalleHistorium>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdCampo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdHistoria).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Valor).IsUnicode(false);

            entity.HasOne(d => d.IdCampoNavigation).WithMany(p => p.DetalleHistoria)
                .HasForeignKey(d => d.IdCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleHistoria_CampoHistoria");

            entity.HasOne(d => d.IdHistoriaNavigation).WithMany(p => p.DetalleHistoria)
                .HasForeignKey(d => d.IdHistoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleHistoria_HistoriaGeneral");
        });

        modelBuilder.Entity<Dominio>(entity =>
        {
            entity.ToTable("Dominio");

            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Auxiliar1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orden)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("orden");
            entity.Property(e => e.Valor)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dxsintomatico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DXSintomaticos");

            entity.Property(e => e.Auxiliar1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descwithoutaccents)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1251_CS_AS")
                .HasColumnName("descwithoutaccents");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Orden)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("orden");
            entity.Property(e => e.Valor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EventTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventTra__3213E83FAD676C55");

            entity.ToTable("EventTracking");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Evento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("evento");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Userid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<HistoriaGeneral>(entity =>
        {
            entity.ToTable("HistoriaGeneral");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Causaexterna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("causaexterna");
            entity.Property(e => e.Cie10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cie10");
            entity.Property(e => e.FechaEgreso).HasColumnType("datetime");
            entity.Property(e => e.FechaExpedFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalPeriodoFactura)
                .HasComment("Se registra el último día del mes en que se expide la factura")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso)
                .HasComment("DD/MM/YYYY")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaInicioPeriodoFactura)
                .HasComment("Se registra el primer día del mes en que se expide la factura")
                .HasColumnType("datetime");
            entity.Property(e => e.Finalidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("01 = Atención del parto (puerperio) 02 = Atención del recién nacido 03 = Atención en planificación familiar 04 = Detección de alteraciones De crecimiento y desarrollo Del menor de diez años 05 = Detección de alteración del desarrollo joven 06 = Detección de alteraciones del embarazo 07 = Detección de alteraciones del adulto 08 = Detección de alteraciones de agudeza visual 09 = Detección de enfermedad profesional <<10 = No aplica>>");
            entity.Property(e => e.Finalidadetalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("finalidadetalle");
            entity.Property(e => e.IdAtencion).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NumeroFactura)
                .IsUnicode(false)
                .HasComment("20 alfaanumérico (Generación autom o manual)");
            entity.Property(e => e.Tipodiagnostico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipodiagnostico");

            entity.HasOne(d => d.IdAtencionNavigation).WithMany(p => p.HistoriaGenerals)
                .HasForeignKey(d => d.IdAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoriaGeneral_Atencion1");
        });

        modelBuilder.Entity<HistoriaProcedimiento>(entity =>
        {
            entity.ToTable("HistoriaProcedimiento");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodigoCups)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodigoCUPS");
            entity.Property(e => e.Finalidad)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IdHistoria).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.IdHistoriaNavigation).WithMany(p => p.HistoriaProcedimientos)
                .HasForeignKey(d => d.IdHistoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoriaProcedimiento_HistoriaGeneral");
        });

        modelBuilder.Entity<HistoricoUsuario>(entity =>
        {
            entity.ToTable("HistoricoUsuario");

            entity.HasIndex(e => e.NumeroDocumento, "UK_NumDocHistoricoUsuario").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BarrioVereda)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoEps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoEPS");
            entity.Property(e => e.CodigoIps)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodigoIPS");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Discapacidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Estrato)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.GrupoEtnico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdUsuario).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Municipio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreEps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreEPS");
            entity.Property(e => e.NombreIps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreIPS");
            entity.Property(e => e.NombresAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombresMadre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombresPadre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Regimen)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoPadres)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoResidencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoIdentificacionIps)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TipoIdentificacionIPS");
            entity.Property(e => e.Zona)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.HistoricoUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoUsuario_Usuario");
        });

        modelBuilder.Entity<Medico>(entity =>
        {
            entity.ToTable("Medico");

            entity.HasIndex(e => e.NumeroDocumento, "UK_NumDocMedico").IsUnique();

            entity.HasIndex(e => e.RegistroMedico, "UK_RegMedico").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Firma).HasColumnType("image");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistroMedico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.User).WithMany(p => p.Medicos)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Medico_User");
        });

        modelBuilder.Entity<ReporteBai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReporteBai");

            entity.Property(e => e.Cie10).IsUnicode(false);
            entity.Property(e => e.DiagnosticoCie10)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DiagnosticoSintomatico).IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResumenHistorium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ResumenHistoria");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.IdAtencion).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Orden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("orden");
            entity.Property(e => e.SeccionPpal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(502)
                .IsUnicode(false)
                .HasColumnName("titulo");
            entity.Property(e => e.Valor)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<RipsAc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RipsAc");

            entity.Property(e => e.CausaExt).IsUnicode(false);
            entity.Property(e => e.CodigoPrestador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CuotaModera)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Cups)
                .IsUnicode(false)
                .HasColumnName("CUPS");
            entity.Property(e => e.DxPpal).IsUnicode(false);
            entity.Property(e => e.DxRel1).IsUnicode(false);
            entity.Property(e => e.DxRel2).IsUnicode(false);
            entity.Property(e => e.DxRel3).IsUnicode(false);
            entity.Property(e => e.FechaAtencion).HasColumnType("datetime");
            entity.Property(e => e.FechaCons)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Finalidad).IsUnicode(false);
            entity.Property(e => e.NumAutoriz)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Numerofactura).IsUnicode(false);
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoDxPpal).IsUnicode(false);
            entity.Property(e => e.ValorConsulta)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ValorNetoPagar)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RipsAf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RipsAf");

            entity.Property(e => e.CodigoEps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoEPS");
            entity.Property(e => e.CodigoPrestador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExpedFactura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FecFinFactura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FecIniFactura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaAtencion).HasColumnType("datetime");
            entity.Property(e => e.Nit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.NombreEps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreEPS");
            entity.Property(e => e.NumContrato)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NumPoliza)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PlanBeneficios)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoIdentifi)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ValorComision)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ValorCopago)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ValorDescuento)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ValorNetoPagar)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RipsDiario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RipsDiario");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.CausaExt).IsUnicode(false);
            entity.Property(e => e.CodigoCie10).IsUnicode(false);
            entity.Property(e => e.CodigoEntidadAdm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cups).IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DiagnosticoPrincipal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Eps)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Finalidad).IsUnicode(false);
            entity.Property(e => e.Medico)
                .HasMaxLength(203)
                .IsUnicode(false);
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(41)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Procedimiento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramaProceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("programa_proceso");
            entity.Property(e => e.Semestre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoDiagnostico).IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoStakeholder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_stakeholder");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RipsU>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RipsUs");

            entity.Property(e => e.CodigoEps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoEPS");
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Regimen)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Email, "UK_Email").IsUnique();

            entity.HasIndex(e => e.UserName, "UK_UserName").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Firma).HasMaxLength(300);
            entity.Property(e => e.Intentos).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.HasIndex(e => e.NumeroDocumento, "UK_NumDocUsuario").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AceptacionConsentimiento)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AceptacionDatosPersonales)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BarrioVereda)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoEps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoEPS");
            entity.Property(e => e.CodigoIps)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodigoIPS");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Discapacidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Estrato)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.GrupoEtnico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Municipio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreEps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreEPS");
            entity.Property(e => e.NombreIps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreIPS");
            entity.Property(e => e.NombresAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombresMadre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombresPadre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentescoAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Posicion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Recuperacion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("recuperacion");
            entity.Property(e => e.Regimen)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoPadres)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoResidencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoIdentificacionIps)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TipoIdentificacionIPS");
            entity.Property(e => e.Zona)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewAtention>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAtention");

            entity.Property(e => e.Atn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Fechatext)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fechatext");
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdUsuario).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(105)
                .IsUnicode(false);
            entity.Property(e => e.ProfesionalMed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TipoAtencion).IsUnicode(false);
        });

        modelBuilder.Entity<ViewAtentionRemision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAtentionRemisions");

            entity.Property(e => e.Atn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Fechatext)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fechatext");
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdUsuario).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(105)
                .IsUnicode(false);
            entity.Property(e => e.ProfesionalMed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RemisionEps).HasColumnName("remision_eps");
            entity.Property(e => e.RemisionSisvecos).HasColumnName("remision_sisvecos");
            entity.Property(e => e.RemisionSivim).HasColumnName("remision_sivim");
            entity.Property(e => e.TipoAtencion).IsUnicode(false);
        });

        modelBuilder.Entity<ViewAtn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAtn");

            entity.Property(e => e.Atn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(207)
                .IsUnicode(false);
            entity.Property(e => e.ProfesionalMed).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TipoAtencion).IsUnicode(false);
        });

        modelBuilder.Entity<ViewAtnPsicoPedagogium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAtnPsicoPedagogia");

            entity.Property(e => e.Avances).IsUnicode(false);
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compromisos).IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EvaluacionProceso).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdCampo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdHistoria).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ItemConsulta).IsUnicode(false);
            entity.Property(e => e.MotivoConsulta).IsUnicode(false);
            entity.Property(e => e.No).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NombreDelEstudiante)
                .HasMaxLength(203)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).IsUnicode(false);
        });

        modelBuilder.Entity<ViewLugare>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Lugares");

            entity.Property(e => e.Lugar)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("lugar");
        });

        modelBuilder.Entity<ViewReportAttention>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReportAttentions");

            entity.Property(e => e.CodigoCie10).IsUnicode(false);
            entity.Property(e => e.DiagnosticoPrincipal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DiagnosticoSintomatico).IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(23)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Medico)
                .HasMaxLength(202)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewReporteMorbilidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewReporteMorbilidad");

            entity.Property(e => e.Codigo)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaAtencion).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.TipoHistoriaEspecialidad).IsUnicode(false);
        });
        modelBuilder.HasSequence("DomainSequence").StartsAt(18331L);
        modelBuilder.HasSequence("FacturaSequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
