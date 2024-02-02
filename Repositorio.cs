using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace RelatorioFluids
{
    public class Repositorio : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura a string de conexão
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["ConnectionString"]);
        }

        public DbSet<Dosagem> Dosagem { get; set; }

        public List<Dosagem> LerDados(
            DateTime dataInicio,
            DateTime dataFim,
            int masseira,
            string receita,
            string loteOX328,
            string loteEN328,
            string loteSO102,
            string loteMF3)
        {
            var query = Dosagem.Where(x => 
                x.DataHora >= dataInicio
                && x.DataHora <= dataFim
                && (masseira == 0 || x.Masseira == masseira)
                && (string.IsNullOrWhiteSpace(receita)   || x.Receita.ToUpper().Contains(receita.ToUpper()))
                && (string.IsNullOrWhiteSpace(loteOX328) || x.LoteOX328.ToUpper().Contains(loteOX328.ToUpper()))
                && (string.IsNullOrWhiteSpace(loteEN328) || x.LoteEN328.ToUpper().Contains(loteEN328.ToUpper()))
                && (string.IsNullOrWhiteSpace(loteSO102) || x.LoteSO102.ToUpper().Contains(loteSO102.ToUpper()))
                && (string.IsNullOrWhiteSpace(loteMF3)   || x.LoteMF3.ToUpper().Contains(loteMF3.ToUpper())))
            .OrderBy(x => x.DataHora);

            var gg = query.ToQueryString();

            return query.ToList();
        }
    }
}
