namespace RelatorioFluids {
    partial class Relatorio {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            txtReceita = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLoteMF3 = new TextBox();
            txtLoteSO102 = new TextBox();
            txtLoteEN328 = new TextBox();
            masseira = new NumericUpDown();
            dtDataFim = new DateTimePicker();
            dtDataInicio = new DateTimePicker();
            txtLoteOX328 = new TextBox();
            labelLoteOX328 = new Label();
            labelDataFim = new Label();
            labelDateInicio = new Label();
            labelMasseira = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            DataHora = new DataGridViewTextBoxColumn();
            masseiraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Receita = new DataGridViewTextBoxColumn();
            qtdOX328DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loteOX328DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtdEN328DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loteEN328DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtdSO102DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loteSO102DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtdMF3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loteMF3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dosagemBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)masseira).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dosagemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1350, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtReceita);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLoteMF3);
            panel1.Controls.Add(txtLoteSO102);
            panel1.Controls.Add(txtLoteEN328);
            panel1.Controls.Add(masseira);
            panel1.Controls.Add(dtDataFim);
            panel1.Controls.Add(dtDataInicio);
            panel1.Controls.Add(txtLoteOX328);
            panel1.Controls.Add(labelLoteOX328);
            panel1.Controls.Add(labelDataFim);
            panel1.Controls.Add(labelDateInicio);
            panel1.Controls.Add(labelMasseira);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 89);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 55);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 21;
            label4.Text = "Fim";
            // 
            // txtReceita
            // 
            txtReceita.Location = new Point(260, 51);
            txtReceita.Name = "txtReceita";
            txtReceita.Size = new Size(186, 23);
            txtReceita.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 27);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 19;
            label5.Text = "Receita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1134, 27);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 17;
            label3.Text = "Lote MF3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(954, 27);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 16;
            label2.Text = "Lote SO102";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(775, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 15;
            label1.Text = "Lote EN328";
            // 
            // txtLoteMF3
            // 
            txtLoteMF3.Location = new Point(1134, 51);
            txtLoteMF3.Name = "txtLoteMF3";
            txtLoteMF3.Size = new Size(85, 23);
            txtLoteMF3.TabIndex = 14;
            // 
            // txtLoteSO102
            // 
            txtLoteSO102.Location = new Point(954, 51);
            txtLoteSO102.Name = "txtLoteSO102";
            txtLoteSO102.Size = new Size(85, 23);
            txtLoteSO102.TabIndex = 13;
            // 
            // txtLoteEN328
            // 
            txtLoteEN328.Location = new Point(775, 51);
            txtLoteEN328.Name = "txtLoteEN328";
            txtLoteEN328.Size = new Size(85, 23);
            txtLoteEN328.TabIndex = 12;
            // 
            // masseira
            // 
            masseira.BackColor = SystemColors.HighlightText;
            masseira.Location = new Point(203, 51);
            masseira.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            masseira.Name = "masseira";
            masseira.ReadOnly = true;
            masseira.Size = new Size(41, 23);
            masseira.TabIndex = 11;
            // 
            // dtDataFim
            // 
            dtDataFim.Checked = false;
            dtDataFim.CustomFormat = "dd/MM/yyyy HH:mm";
            dtDataFim.Format = DateTimePickerFormat.Custom;
            dtDataFim.Location = new Point(49, 51);
            dtDataFim.Name = "dtDataFim";
            dtDataFim.Size = new Size(133, 23);
            dtDataFim.TabIndex = 10;
            dtDataFim.Value = new DateTime(2024, 2, 2, 19, 4, 41, 0);
            // 
            // dtDataInicio
            // 
            dtDataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtDataInicio.Format = DateTimePickerFormat.Custom;
            dtDataInicio.Location = new Point(49, 23);
            dtDataInicio.Name = "dtDataInicio";
            dtDataInicio.Size = new Size(133, 23);
            dtDataInicio.TabIndex = 9;
            // 
            // txtLoteOX328
            // 
            txtLoteOX328.Location = new Point(596, 51);
            txtLoteOX328.Name = "txtLoteOX328";
            txtLoteOX328.Size = new Size(85, 23);
            txtLoteOX328.TabIndex = 8;
            // 
            // labelLoteOX328
            // 
            labelLoteOX328.AutoSize = true;
            labelLoteOX328.Location = new Point(596, 27);
            labelLoteOX328.Name = "labelLoteOX328";
            labelLoteOX328.Size = new Size(67, 15);
            labelLoteOX328.TabIndex = 4;
            labelLoteOX328.Text = "Lote OX328";
            // 
            // labelDataFim
            // 
            labelDataFim.AutoSize = true;
            labelDataFim.Location = new Point(7, 27);
            labelDataFim.Name = "labelDataFim";
            labelDataFim.Size = new Size(36, 15);
            labelDataFim.TabIndex = 3;
            labelDataFim.Text = "Inicio";
            // 
            // labelDateInicio
            // 
            labelDateInicio.AutoSize = true;
            labelDateInicio.Location = new Point(49, 6);
            labelDateInicio.Name = "labelDateInicio";
            labelDateInicio.Size = new Size(60, 15);
            labelDateInicio.TabIndex = 2;
            labelDateInicio.Text = "Data Hora";
            // 
            // labelMasseira
            // 
            labelMasseira.AutoSize = true;
            labelMasseira.Location = new Point(197, 27);
            labelMasseira.Name = "labelMasseira";
            labelMasseira.Size = new Size(53, 15);
            labelMasseira.TabIndex = 1;
            labelMasseira.Text = "Masseira";
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1241, 39);
            button1.Name = "button1";
            button1.Size = new Size(82, 35);
            button1.TabIndex = 0;
            button1.Text = "FILTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataHora, masseiraDataGridViewTextBoxColumn, Receita, qtdOX328DataGridViewTextBoxColumn, loteOX328DataGridViewTextBoxColumn, qtdEN328DataGridViewTextBoxColumn, loteEN328DataGridViewTextBoxColumn, qtdSO102DataGridViewTextBoxColumn, loteSO102DataGridViewTextBoxColumn, qtdMF3DataGridViewTextBoxColumn, loteMF3DataGridViewTextBoxColumn });
            dataGridView1.DataSource = dosagemBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(3, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1344, 460);
            dataGridView1.TabIndex = 1;
            // 
            // DataHora
            // 
            DataHora.DataPropertyName = "DataHora";
            DataHora.HeaderText = "Data Hora";
            DataHora.Name = "DataHora";
            DataHora.ReadOnly = true;
            DataHora.Width = 150;
            // 
            // masseiraDataGridViewTextBoxColumn
            // 
            masseiraDataGridViewTextBoxColumn.DataPropertyName = "Masseira";
            masseiraDataGridViewTextBoxColumn.HeaderText = "Masseira";
            masseiraDataGridViewTextBoxColumn.Name = "masseiraDataGridViewTextBoxColumn";
            masseiraDataGridViewTextBoxColumn.ReadOnly = true;
            masseiraDataGridViewTextBoxColumn.Width = 60;
            // 
            // Receita
            // 
            Receita.DataPropertyName = "Receita";
            Receita.HeaderText = "Receita";
            Receita.Name = "Receita";
            Receita.ReadOnly = true;
            Receita.Width = 250;
            // 
            // qtdOX328DataGridViewTextBoxColumn
            // 
            qtdOX328DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            qtdOX328DataGridViewTextBoxColumn.DataPropertyName = "QtdOX328";
            dataGridViewCellStyle1.Format = "F3";
            dataGridViewCellStyle1.NullValue = null;
            qtdOX328DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            qtdOX328DataGridViewTextBoxColumn.HeaderText = "Qtd OX328";
            qtdOX328DataGridViewTextBoxColumn.Name = "qtdOX328DataGridViewTextBoxColumn";
            qtdOX328DataGridViewTextBoxColumn.ReadOnly = true;
            qtdOX328DataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            qtdOX328DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            qtdOX328DataGridViewTextBoxColumn.Width = 90;
            // 
            // loteOX328DataGridViewTextBoxColumn
            // 
            loteOX328DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            loteOX328DataGridViewTextBoxColumn.DataPropertyName = "LoteOX328";
            loteOX328DataGridViewTextBoxColumn.HeaderText = "Lote OX328";
            loteOX328DataGridViewTextBoxColumn.Name = "loteOX328DataGridViewTextBoxColumn";
            loteOX328DataGridViewTextBoxColumn.ReadOnly = true;
            loteOX328DataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            loteOX328DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            loteOX328DataGridViewTextBoxColumn.Width = 90;
            // 
            // qtdEN328DataGridViewTextBoxColumn
            // 
            qtdEN328DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            qtdEN328DataGridViewTextBoxColumn.DataPropertyName = "QtdEN328";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            qtdEN328DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            qtdEN328DataGridViewTextBoxColumn.HeaderText = "Qtd EN328";
            qtdEN328DataGridViewTextBoxColumn.Name = "qtdEN328DataGridViewTextBoxColumn";
            qtdEN328DataGridViewTextBoxColumn.ReadOnly = true;
            qtdEN328DataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            qtdEN328DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            qtdEN328DataGridViewTextBoxColumn.Width = 90;
            // 
            // loteEN328DataGridViewTextBoxColumn
            // 
            loteEN328DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            loteEN328DataGridViewTextBoxColumn.DataPropertyName = "LoteEN328";
            loteEN328DataGridViewTextBoxColumn.HeaderText = "Lote EN328";
            loteEN328DataGridViewTextBoxColumn.Name = "loteEN328DataGridViewTextBoxColumn";
            loteEN328DataGridViewTextBoxColumn.ReadOnly = true;
            loteEN328DataGridViewTextBoxColumn.Width = 90;
            // 
            // qtdSO102DataGridViewTextBoxColumn
            // 
            qtdSO102DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            qtdSO102DataGridViewTextBoxColumn.DataPropertyName = "QtdSO102";
            dataGridViewCellStyle3.Format = "N3";
            qtdSO102DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            qtdSO102DataGridViewTextBoxColumn.HeaderText = "Qtd SO102";
            qtdSO102DataGridViewTextBoxColumn.Name = "qtdSO102DataGridViewTextBoxColumn";
            qtdSO102DataGridViewTextBoxColumn.ReadOnly = true;
            qtdSO102DataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            qtdSO102DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            qtdSO102DataGridViewTextBoxColumn.Width = 90;
            // 
            // loteSO102DataGridViewTextBoxColumn
            // 
            loteSO102DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            loteSO102DataGridViewTextBoxColumn.DataPropertyName = "LoteSO102";
            loteSO102DataGridViewTextBoxColumn.HeaderText = "Lote SO102";
            loteSO102DataGridViewTextBoxColumn.Name = "loteSO102DataGridViewTextBoxColumn";
            loteSO102DataGridViewTextBoxColumn.ReadOnly = true;
            loteSO102DataGridViewTextBoxColumn.Width = 90;
            // 
            // qtdMF3DataGridViewTextBoxColumn
            // 
            qtdMF3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            qtdMF3DataGridViewTextBoxColumn.DataPropertyName = "QtdMF3";
            dataGridViewCellStyle4.Format = "N3";
            qtdMF3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            qtdMF3DataGridViewTextBoxColumn.HeaderText = "Qtd MF3";
            qtdMF3DataGridViewTextBoxColumn.Name = "qtdMF3DataGridViewTextBoxColumn";
            qtdMF3DataGridViewTextBoxColumn.ReadOnly = true;
            qtdMF3DataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            qtdMF3DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            qtdMF3DataGridViewTextBoxColumn.Width = 90;
            // 
            // loteMF3DataGridViewTextBoxColumn
            // 
            loteMF3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            loteMF3DataGridViewTextBoxColumn.DataPropertyName = "LoteMF3";
            loteMF3DataGridViewTextBoxColumn.HeaderText = "Lote MF3";
            loteMF3DataGridViewTextBoxColumn.Name = "loteMF3DataGridViewTextBoxColumn";
            loteMF3DataGridViewTextBoxColumn.ReadOnly = true;
            loteMF3DataGridViewTextBoxColumn.Width = 90;
            // 
            // dosagemBindingSource
            // 
            dosagemBindingSource.DataSource = typeof(Dosagem);
            // 
            // Relatorio
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1350, 561);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Relatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório Fluids";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)masseira).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dosagemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private TextBox txtLoteOX328;
        private Label labelLoteOX328;
        private Label labelDataFim;
        private Label labelDateInicio;
        private Label labelMasseira;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLoteMF3;
        private TextBox txtLoteSO102;
        private TextBox txtLoteEN328;
        private NumericUpDown masseira;
        private DateTimePicker dtDataFim;
        private DateTimePicker dtDataInicio;
        private DataGridView dataGridView1;
        private BindingSource dosagemBindingSource;
        private DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private TextBox txtReceita;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn DataHora;
        private DataGridViewTextBoxColumn masseiraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Receita;
        private DataGridViewTextBoxColumn qtdOX328DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loteOX328DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtdEN328DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loteEN328DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtdSO102DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loteSO102DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtdMF3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loteMF3DataGridViewTextBoxColumn;
    }
}