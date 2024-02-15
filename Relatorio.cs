using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace RelatorioFluids
{
    public partial class Relatorio : Form
    {
        private readonly Repositorio repositorio;
        private List<Dosagem> dosagems;
        private System.Windows.Forms.Timer timer;
        private DateTime dtDataInicioOld;
        private DateTime dtDataFimOld;
        private int masseiraOld;
        private string txtReceitaOld;
        private string txtLoteOX328Old;
        private string txtLoteEN328Old;
        private string txtLoteSO102Old;
        private string txtLoteMF3Old;

        public Relatorio()
        {
            InitializeComponent();
            repositorio = new Repositorio();
            Init();
        }

        public void Init()
        {
            repositorio.Database.Migrate();

            dtDataFim.Value = DateTime.UtcNow.AddHours(-3);
            dtDataInicio.Value = DateTime.UtcNow.AddHours(-3).AddYears(-1);

            FiltrarDados();

            InitTick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltrarDados();
        }

        private void FiltrarDados()
        {
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
            dosagems = listDados;

            dtDataInicioOld = dtDataInicio.Value;
            dtDataFimOld = dtDataFim.Value;
            masseiraOld = (int)masseira.Value;
            txtReceitaOld = txtReceita.Text;
            txtLoteOX328Old = txtLoteOX328.Text;
            txtLoteEN328Old = txtLoteEN328.Text;
            txtLoteSO102Old = txtLoteSO102.Text;
            txtLoteMF3Old = txtLoteMF3.Text;
        }

        private void ExportarExcel()
        {
            var fileTemplate = new FileInfo("Template_Relatorio.xlsx");
            var file = new FileInfo("file.xlsx");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using var package = new ExcelPackage(file, fileTemplate);
            var worksheets = package.Workbook.Worksheets.ToList();

            List<DosagemModel> dosagemModel = dosagems.Select(x => (DosagemModel)x).ToList();
            worksheets[0].Cells[2, 1].LoadFromCollection(dosagemModel, false);

            SaveFileModal(package.GetAsByteArray());
        }

        private static void SaveFileModal(byte[] file)
        {
            SaveFileDialog saveFileDialog1 = new()
            {
                // Define os filtros de arquivo
                FileName = "Relatorio Fluids.xlsx",
                Filter = "Arquivos de Excel|*.xlsx|Todos os arquivos|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            // Exibe o diálogo de salvar arquivo
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho do arquivo selecionado
                string caminhoArquivo = saveFileDialog1.FileName;

                // Agora você pode salvar seu arquivo no local especificado pelo 'caminhoArquivo'
                // Exemplo:
                File.WriteAllBytes(caminhoArquivo, file);
            }
        }

        private void InitTick()
        {
            // Inicialize e configure o Timer
            timer = new()
            {
                Interval = 2500 // Intervalo em milissegundos (2.5 segundo)
            };
            timer.Tick += Timer_Tick; // Associa o evento Tick com a função Timer_Tick
            timer.Start(); // Inicia o Timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var listDados = repositorio.LerDados(
                dataInicio: dtDataInicioOld,
                dataFim: dtDataFimOld,
                masseira: (int)masseiraOld,
                receita: txtReceitaOld,
                loteOX328: txtLoteOX328Old,
                loteEN328: txtLoteEN328Old,
                loteSO102: txtLoteSO102Old,
                loteMF3: txtLoteMF3Old);
            dataGridView1.DataSource = listDados;
            dosagems = listDados;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtDataFim.Value = DateTime.UtcNow.AddHours(-3);
            dtDataInicio.Value = DateTime.UtcNow.AddHours(-3).AddYears(-1);

            masseira.Value = 0;
            txtReceita.Text = "";
            txtLoteOX328.Text = "";
            txtLoteEN328.Text = "";
            txtLoteSO102.Text = "";
            txtLoteMF3.Text = "";

            FiltrarDados();
        }
    }
}