namespace RelatorioFluids
{
    public class DosagemModel
    {
        public string DataHora { get; set; }
        public int Masseira { get; set; }
        public string Receita { get; set; }
        public decimal QtdOX328 { get; set; }
        public string LoteOX328 { get; set; }
        public decimal QtdEN328 { get; set; }
        public string LoteEN328 { get; set; }
        public decimal QtdSO102 { get; set; }
        public string LoteSO102 { get; set; }
        public decimal QtdMF3 { get; set; }
        public string LoteMF3 { get; set; }

        public static explicit operator DosagemModel(Dosagem v) => new()
        {
            DataHora= v.DataHora.ToString("dd/MM/yyyy HH:mm"),
            Masseira= v.Masseira,
            Receita= v.Receita,
            QtdOX328= v.QtdOX328,
            LoteOX328= v.LoteOX328,
            QtdEN328= v.QtdEN328,
            LoteEN328= v.LoteEN328,
            QtdSO102= v.QtdSO102,
            LoteSO102= v.LoteSO102,
            QtdMF3 = v.QtdMF3,
            LoteMF3= v.LoteMF3,
        };
    }
}
