using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiRealState.Models;

public partial class PrInmue
{
    
    [Key] public int IdeInmu { get; set; }

    public string TitProp { get; set; } = null!;

    public string? DesProp { get; set; }

    public decimal? PreProp { get; set; }

    public string? EtiPrec { get; set; }

    public decimal? PreAnte { get; set; }

    public decimal? TasImpu { get; set; }

    public decimal? CuoAdmi { get; set; }

    public string? TipVivi { get; set; }

    public string? TipBien { get; set; }

    public string? EstVivi { get; set; }

    public string? ArcInmu { get; set; }

    public string? TipVide { get; set; }

    public string? IdeVide { get; set; }

    public string? TurVirt { get; set; }

    public string? DirProp { get; set; }

    public string? ProPais { get; set; }

    public string? ProDepa { get; set; }

    public string? ProCiud { get; set; }

    public string? ProLoca { get; set; }

    public string? ProBarr { get; set; }

    public string? GooLati { get; set; }

    public string? GooLong { get; set; }

    public string? GooDepa { get; set; }

    public string? GooCiud { get; set; }

    public string? GooStre { get; set; }

    public string? TamFuen { get; set; }

    public string? TamLote { get; set; }

    public string? NumHabi { get; set; }

    public string? NumDorm { get; set; }

    public string? NumBano { get; set; }

    public string? IdePers { get; set; }

    public string? GarProp { get; set; }

    public string? AnoCons { get; set; }

    public string? TamGara { get; set; }

    public string? DisFech { get; set; }

    public string? SotProp { get; set; }

    public string? DetExtr { get; set; }

    public string? DesTech { get; set; }

    public string? MatExte { get; set; }

    public string? TipEstr { get; set; }

    public string? NumPiso { get; set; }

    public string? NotProp { get; set; }

    public string? CodEqui { get; set; }

    public string? GimNasi { get; set; }

    public string? SalComu { get; set; }

    public string? LavAnde { get; set; }

    public string? PatTras { get; set; }

    public string? CanBalo { get; set; }

    public string? GarAdju { get; set; }

    public string? BanCali { get; set; }

    public string? AirCent { get; set; }

    public string? EleTric { get; set; }

    public string? GasNatu { get; set; }

    public string? VenTila { get; set; }

    public string? SilAcce { get; set; }

    public string? AseNsor { get; set; }

    public string? DetHumo { get; set; }

    public string? LavSeca { get; set; }

    public int? ActUsua { get; set; }

    public DateTime? ActHora { get; set; }
}
