using Microsoft.EntityFrameworkCore;

namespace RelatorioFluids {
    public partial class Relatorio : Form {
        private readonly Repositorio repositorio;

        public Relatorio() {
            InitializeComponent();
            repositorio = new Repositorio();
            Init();
        }

        public void Init() {
            repositorio.Database.Migrate();

            dtDataFim.Value = DateTime.UtcNow.AddHours(-3);
            dtDataInicio.Value = DateTime.UtcNow.AddHours(-3).AddYears(-1);

            FiltrarDados();
        }

        private void button1_Click(object sender, EventArgs e) {
            FiltrarDados();
        }

        private void FiltrarDados() {
            var listDados = repositorio.LerDados(
                dataInicio: dtDataInicio.Value,
                dataFim: dtDataFim.Value,
                masseira: (int)masseira.Value,
                receita: txtReceita.Text,
                loteOX328: txtLoteOX328.Text,
                loteEN328: txtLoteEN328.Text,
                loteSO102: txtLoteSO102.Text,
                loteMF3: txtLoteMF3.Text);
            dataGridView1.DataSource = listDados;
        }
    }
}