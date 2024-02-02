using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelatorioFluids
{
    public class Dosagem
    {
        public int Id { get; set; }

        [DefaultValue("GETDATE() AT TIME ZONE 'E. South America Standard Time'"), Required]
        public DateTime DataHora { get; set; }

        [Required]
        public int Masseira { get; set; }

        [Column(TypeName = "nvarchar(40)"), Required]
        public string Receita { get; set; }

        [Column(TypeName = "decimal(10,3)"), Required]
        public decimal QtdOX328 { get; set; }

        [Column(TypeName = "nvarchar(20)"), Required]
        public string LoteOX328 { get; set; }

        [Column(TypeName = "decimal(10,3)"), Required]
        public decimal QtdEN328 { get; set; }

        [Column(TypeName = "nvarchar(20)"), Required]
        public string LoteEN328 { get; set; }

        [Column(TypeName = "decimal(10,3)"), Required]
        public decimal QtdSO102 { get; set; }

        [Column(TypeName = "nvarchar(20)"), Required]
        public string LoteSO102 { get; set; }

        [Column(TypeName = "decimal(10,3)"), Required]
        public decimal QtdMF3 { get; set; }

        [Column(TypeName = "nvarchar(20)"), Required]
        public string LoteMF3 { get; set; }
    }
}
