namespace controleEstoque
{
    partial class MovimentaEstoqueEntradaForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxPrincipal = new GroupBox();
            groupBoxTabela = new GroupBox();
            dataGridViewEntrada = new DataGridView();
            groupBoxButton02 = new GroupBox();
            btnVoltar = new Button();
            btmExel = new Button();
            btnPDF = new Button();
            groupBoxButton01 = new GroupBox();
            dateTime2 = new DateTimePicker();
            labelAte = new Label();
            dateTime1 = new DateTimePicker();
            labelPeriodo = new Label();
            buttonTodos = new Button();
            labelCategoria = new Label();
            buttonPesquisar = new Button();
            comboBoxProduto = new ComboBox();
            comboBoxCategoria = new ComboBox();
            labelProduto = new Label();
            comboBoxFornecedor = new ComboBox();
            labelFornecedor = new Label();
            groupBoxPrincipal.SuspendLayout();
            groupBoxTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntrada).BeginInit();
            groupBoxButton02.SuspendLayout();
            groupBoxButton01.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(groupBoxTabela);
            groupBoxPrincipal.Controls.Add(groupBoxButton02);
            groupBoxPrincipal.Controls.Add(groupBoxButton01);
            groupBoxPrincipal.Dock = DockStyle.Fill;
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(1060, 582);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Relatório Movimentoção Entrada";
            // 
            // groupBoxTabela
            // 
            groupBoxTabela.Controls.Add(dataGridViewEntrada);
            groupBoxTabela.Dock = DockStyle.Fill;
            groupBoxTabela.Location = new Point(3, 126);
            groupBoxTabela.Name = "groupBoxTabela";
            groupBoxTabela.Size = new Size(1054, 388);
            groupBoxTabela.TabIndex = 2;
            groupBoxTabela.TabStop = false;
            groupBoxTabela.Text = "Tabela";
            // 
            // dataGridViewEntrada
            // 
            dataGridViewEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntrada.Dock = DockStyle.Fill;
            dataGridViewEntrada.Location = new Point(3, 21);
            dataGridViewEntrada.Name = "dataGridViewEntrada";
            dataGridViewEntrada.RowTemplate.Height = 25;
            dataGridViewEntrada.Size = new Size(1048, 364);
            dataGridViewEntrada.TabIndex = 0;
            // 
            // groupBoxButton02
            // 
            groupBoxButton02.Controls.Add(btnVoltar);
            groupBoxButton02.Controls.Add(btmExel);
            groupBoxButton02.Controls.Add(btnPDF);
            groupBoxButton02.Dock = DockStyle.Bottom;
            groupBoxButton02.Location = new Point(3, 514);
            groupBoxButton02.Name = "groupBoxButton02";
            groupBoxButton02.Size = new Size(1054, 65);
            groupBoxButton02.TabIndex = 1;
            groupBoxButton02.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BackColor = Color.DarkGray;
            btnVoltar.Image = Properties.Resources.voltar;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(7, 18);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(5, 0, 0, 0);
            btnVoltar.Size = new Size(159, 43);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btmExel
            // 
            btmExel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btmExel.FlatAppearance.BorderSize = 0;
            btmExel.FlatStyle = FlatStyle.Flat;
            btmExel.Image = Properties.Resources.excel24;
            btmExel.Location = new Point(948, 21);
            btmExel.Margin = new Padding(4);
            btmExel.Name = "btmExel";
            btmExel.Size = new Size(44, 43);
            btmExel.TabIndex = 9;
            btmExel.UseVisualStyleBackColor = true;
            btmExel.Click += btmExel_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Image = Properties.Resources.pdf24;
            btnPDF.Location = new Point(1000, 24);
            btnPDF.Margin = new Padding(4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(44, 43);
            btnPDF.TabIndex = 8;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // groupBoxButton01
            // 
            groupBoxButton01.Controls.Add(dateTime2);
            groupBoxButton01.Controls.Add(labelAte);
            groupBoxButton01.Controls.Add(dateTime1);
            groupBoxButton01.Controls.Add(labelPeriodo);
            groupBoxButton01.Controls.Add(buttonTodos);
            groupBoxButton01.Controls.Add(labelCategoria);
            groupBoxButton01.Controls.Add(buttonPesquisar);
            groupBoxButton01.Controls.Add(comboBoxProduto);
            groupBoxButton01.Controls.Add(comboBoxCategoria);
            groupBoxButton01.Controls.Add(labelProduto);
            groupBoxButton01.Controls.Add(comboBoxFornecedor);
            groupBoxButton01.Controls.Add(labelFornecedor);
            groupBoxButton01.Dock = DockStyle.Top;
            groupBoxButton01.Location = new Point(3, 21);
            groupBoxButton01.Name = "groupBoxButton01";
            groupBoxButton01.Size = new Size(1054, 105);
            groupBoxButton01.TabIndex = 0;
            groupBoxButton01.TabStop = false;
            // 
            // dateTime2
            // 
            dateTime2.Location = new Point(756, 56);
            dateTime2.Name = "dateTime2";
            dateTime2.Size = new Size(201, 25);
            dateTime2.TabIndex = 18;
            dateTime2.DropDown += dateTime2_DropDown;
            // 
            // labelAte
            // 
            labelAte.AutoSize = true;
            labelAte.Location = new Point(724, 62);
            labelAte.Name = "labelAte";
            labelAte.Size = new Size(26, 17);
            labelAte.TabIndex = 17;
            labelAte.Text = "até";
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(517, 56);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(201, 25);
            dateTime1.TabIndex = 16;
            dateTime1.DropDown += dateTime1_DropDown;
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.Location = new Point(457, 62);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(54, 17);
            labelPeriodo.TabIndex = 15;
            labelPeriodo.Text = "Período";
            // 
            // buttonTodos
            // 
            buttonTodos.Location = new Point(903, 13);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(141, 29);
            buttonTodos.TabIndex = 14;
            buttonTodos.Text = "Todos";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(446, 20);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(65, 17);
            labelCategoria.TabIndex = 7;
            labelCategoria.Text = "Categoria";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(756, 13);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(141, 29);
            buttonPesquisar.TabIndex = 13;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(87, 56);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(353, 25);
            comboBoxProduto.TabIndex = 6;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(517, 17);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(201, 25);
            comboBoxCategoria.TabIndex = 12;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(26, 59);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(55, 17);
            labelProduto.TabIndex = 5;
            labelProduto.Text = "Produto";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(87, 17);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(353, 25);
            comboBoxFornecedor.TabIndex = 3;
            comboBoxFornecedor.SelectedIndexChanged += comboBoxFornecedor_SelectedIndexChanged;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Location = new Point(9, 20);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(75, 17);
            labelFornecedor.TabIndex = 2;
            labelFornecedor.Text = "Fornecedor";
            labelFornecedor.Click += labelFornecedor_Click;
            // 
            // MovimentaEstoqueEntradaForms
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1060, 582);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovimentaEstoqueEntradaForms";
            Text = "MovimentaEstoqueEntradaForms";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntrada).EndInit();
            groupBoxButton02.ResumeLayout(false);
            groupBoxButton01.ResumeLayout(false);
            groupBoxButton01.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxButton01;
        private ComboBox comboBoxFornecedor;
        private Label labelFornecedor;
        private Label labelCategoria;
        private ComboBox comboBoxProduto;
        private Label labelProduto;
        private GroupBox groupBoxButton02;
        private Button buttonTodos;
        private Button buttonPesquisar;
        private ComboBox comboBoxCategoria;
        private GroupBox groupBoxTabela;
        private DataGridView dataGridViewEntrada;
        private Button btnPDF;
        private Button btmExel;
        private Button btnVoltar;
        private DateTimePicker dateTime2;
        private Label labelAte;
        private DateTimePicker dateTime1;
        private Label labelPeriodo;
    }
}