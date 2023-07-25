using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiRealState.Models;

public partial class PaverloProjectContext : DbContext
{
    public PaverloProjectContext()
    {
    }

    public PaverloProjectContext(DbContextOptions<PaverloProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PrInmue> PrInmues { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=186.154.207.82\\SQL2017,50000;Database=Paverlo_project;User=steel;Password=St33l..2023*;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrInmue>(entity =>
        {
            entity
                //.HasNoKey()
                .ToTable("PR_INMUE")
                 .HasKey("IdeInmu");

            entity.Property(e => e.ActHora)
                .HasColumnType("datetime")
                .HasColumnName("ACT_HORA");
            entity.Property(e => e.ActUsua).HasColumnName("ACT_USUA");
            entity.Property(e => e.AirCent)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AIR_CENT");
            entity.Property(e => e.AnoCons)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ANO_CONS");
            entity.Property(e => e.ArcInmu)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ARC_INMU");
            entity.Property(e => e.AseNsor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ASE_NSOR");
            entity.Property(e => e.BanCali)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BAN_CALI");
            entity.Property(e => e.CanBalo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAN_BALO");
            entity.Property(e => e.CodEqui)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_EQUI");
            entity.Property(e => e.CuoAdmi)
                .HasColumnType("decimal(28, 4)")
                .HasColumnName("CUO_ADMI");
            entity.Property(e => e.DesProp)
                .IsUnicode(false)
                .HasColumnName("DES_PROP");
            entity.Property(e => e.DesTech)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_TECH");
            entity.Property(e => e.DetExtr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DET_EXTR");
            entity.Property(e => e.DetHumo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DET_HUMO");
            entity.Property(e => e.DirProp)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DIR_PROP");
            entity.Property(e => e.DisFech)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIS_FECH");
            entity.Property(e => e.EleTric)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ELE_TRIC");
            entity.Property(e => e.EstVivi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EST_VIVI");
            entity.Property(e => e.EtiPrec)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ETI_PREC");
            entity.Property(e => e.GarAdju)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GAR_ADJU");
            entity.Property(e => e.GarProp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GAR_PROP");
            entity.Property(e => e.GasNatu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GAS_NATU");
            entity.Property(e => e.GimNasi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GIM_NASI");
            entity.Property(e => e.GooCiud)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GOO_CIUD");
            entity.Property(e => e.GooDepa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GOO_DEPA");
            entity.Property(e => e.GooLati)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GOO_LATI");
            entity.Property(e => e.GooLong)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GOO_LONG");
            entity.Property(e => e.GooStre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GOO_STRE");
            entity.Property(e => e.IdeInmu)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDE_INMU");
            entity.Property(e => e.IdePers)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IDE_PERS");
            entity.Property(e => e.IdeVide)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IDE_VIDE");
            entity.Property(e => e.LavAnde)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LAV_ANDE");
            entity.Property(e => e.LavSeca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LAV_SECA");
            entity.Property(e => e.MatExte)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAT_EXTE");
            entity.Property(e => e.NotProp)
                .IsUnicode(false)
                .HasColumnName("NOT_PROP");
            entity.Property(e => e.NumBano)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NUM_BANO");
            entity.Property(e => e.NumDorm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NUM_DORM");
            entity.Property(e => e.NumHabi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NUM_HABI");
            entity.Property(e => e.NumPiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_PISO");
            entity.Property(e => e.PatTras)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAT_TRAS");
            entity.Property(e => e.PreAnte)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("PRE_ANTE");
            entity.Property(e => e.PreProp)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("PRE_PROP");
            entity.Property(e => e.ProBarr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_BARR");
            entity.Property(e => e.ProCiud)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_CIUD");
            entity.Property(e => e.ProDepa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_DEPA");
            entity.Property(e => e.ProLoca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_LOCA");
            entity.Property(e => e.ProPais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_PAIS");
            entity.Property(e => e.SalComu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAL_COMU");
            entity.Property(e => e.SilAcce)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SIL_ACCE");
            entity.Property(e => e.SotProp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SOT_PROP");
            entity.Property(e => e.TamFuen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAM_FUEN");
            entity.Property(e => e.TamGara)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAM_GARA");
            entity.Property(e => e.TamLote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TAM_LOTE");
            entity.Property(e => e.TasImpu)
                .HasColumnType("decimal(28, 4)")
                .HasColumnName("TAS_IMPU");
            entity.Property(e => e.TipBien)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIP_BIEN");
            entity.Property(e => e.TipEstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIP_ESTR");
            entity.Property(e => e.TipVide)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIP_VIDE");
            entity.Property(e => e.TipVivi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIP_VIVI");
            entity.Property(e => e.TitProp)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("TIT_PROP");
            entity.Property(e => e.TurVirt)
                .IsUnicode(false)
                .HasColumnName("TUR_VIRT");
            entity.Property(e => e.VenTila)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VEN_TILA");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83FA9A0D73A");

            entity.ToTable("roles");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83FCA6D159F");

            entity.ToTable("usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Rol).HasColumnName("rol");

            entity.HasOne(d => d.RolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Rol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuarios__rol__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
