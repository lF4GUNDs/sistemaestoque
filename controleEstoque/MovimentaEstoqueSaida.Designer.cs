namespace controleEstoque
{
    partial class MovimentaEstoqueSaida
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
            dataGridViewMovimentaSaida = new DataGridView();
            groupBoxButton02 = new GroupBox();
            btnVoltar = new Button();
            btmExel = new Button();
            btnPDF = new Button();
            groupBoxButton01 = new GroupBox();
            labelAte = new Label();
            dateTime2 = new DateTimePicker();
            dateTime1 = new DateTimePicker();
            labelPeriodo = new Label();
            buttonTodos = new Button();
            buttonPesquisar = new Button();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            comboBoxProduto = new ComboBox();
            labelProduto = new Label();
            comboBoxFuncionario = new ComboBox();
            labelFuncionario = new Label();
            groupBoxPrincipal.SuspendLayout();
            groupBoxTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimentaSaida).BeginInit();
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
            groupBoxPrincipal.Size = new Size(1141, 747);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Relatório Movimentação Saída";
            // 
            // groupBoxTabela
            // 
            groupBoxTabela.Controls.Add(dataGridViewMovimentaSaida);
            groupBoxTabela.Dock = DockStyle.Fill;
            groupBoxTabela.Location = new Point(3, 118);
            groupBoxTabela.Name = "groupBoxTabela";
            groupBoxTabela.Size = new Size(1135, 548);
            groupBoxTabela.TabIndex = 2;
            groupBoxTabela.TabStop = false;
            groupBoxTabela.Text = "Tabela";
            // 
            // dataGridViewMovimentaSaida
            // 
            dataGridViewMovimentaSaida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovimentaSaida.Dock = DockStyle.Fill;
            dataGridViewMovimentaSaida.Location = new Point(3, 21);
            dataGridViewMovimentaSaida.Name = "dataGridViewMovimentaSaida";
            dataGridViewMovimentaSaida.RowTemplate.Height = 25;
            dataGridViewMovimentaSaida.Size = new Size(1129, 524);
            dataGridViewMovimentaSaida.TabIndex = 0;
            // 
            // groupBoxButton02
            // 
            groupBoxButton02.Controls.Add(btnVoltar);
            groupBoxButton02.Controls.Add(btmExel);
            groupBoxButton02.Controls.Add(btnPDF);
            groupBoxButton02.Dock = DockStyle.Bottom;
            groupBoxButton02.Location = new Point(3, 666);
            groupBoxButton02.Name = "groupBoxButton02";
            groupBoxButton02.Size = new Size(1135, 78);
            groupBoxButton02.TabIndex = 1;
            groupBoxButton02.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BackColor = Color.DarkGray;
            btnVoltar.Image = Properties.Resources.voltar;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(3, 23);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(5, 0, 0, 0);
            btnVoltar.Size = new Size(159, 43);
            btnVoltar.TabIndex = 9;
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
            btmExel.Location = new Point(1020, 23);
            btmExel.Margin = new Padding(4);
            btmExel.Name = "btmExel";
            btmExel.Size = new Size(44, 43);
            btmExel.TabIndex = 8;
            btmExel.UseVisualStyleBackColor = true;
            btmExel.Click += btmExel_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Image = Properties.Resources.pdf24;
            btnPDF.Location = new Point(1081, 23);
            btnPDF.Margin = new Padding(4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(44, 43);
            btnPDF.TabIndex = 7;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // groupBoxButton01
            // 
            groupBoxButton01.Controls.Add(labelAte);
            groupBoxButton01.Controls.Add(dateTime2);
            groupBoxButton01.Controls.Add(dateTime1);
            groupBoxButton01.Controls.Add(buttonTodos);
            groupBoxButton01.Controls.Add(labelPeriodo);
            groupBoxButton01.Controls.Add(buttonPesquisar);
            groupBoxButton01.Controls.Add(comboBoxCategoria);
            groupBoxButton01.Controls.Add(labelCategoria);
            groupBoxButton01.Controls.Add(comboBoxProduto);
            groupBoxButton01.Controls.Add(labelProduto);
            groupBoxButton01.Controls.Add(comboBoxFuncionario);
            groupBoxButton01.Controls.Add(labelFuncionario);
            groupBoxButton01.Dock = DockStyle.Top;
            groupBoxButton01.Location = new Point(3, 21);
            groupBoxButton01.Name = "groupBoxButton01";
            groupBoxButton01.Size = new Size(1135, 97);
            groupBoxButton01.TabIndex = 0;
            groupBoxButton01.TabStop = false;
            // 
            // labelAte
            // 
            labelAte.AutoSize = true;
            labelAte.Location = new Point(724, 59);
            labelAte.Name = "labelAte";
            labelAte.Size = new Size(26, 17);
            labelAte.TabIndex = 15;
            labelAte.Text = "até";
            // 
            // dateTime2
            // 
            dateTime2.Location = new Point(756, 53);
            dateTime2.Name = "dateTime2";
            dateTime2.Size = new Size(201, 25);
            dateTime2.TabIndex = 14;
            dateTime2.ValueChanged += dateTime2_ValueChanged;
            dateTime2.DropDown += dateTime2_DropDown;
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(517, 53);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(201, 25);
            dateTime1.TabIndex = 13;
            dateTime1.ValueChanged += dateTime1_ValueChanged;
            dateTime1.DropDown += dateTime1_DropDown;
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.Location = new Point(446, 56);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(54, 17);
            labelPeriodo.TabIndex = 12;
            labelPeriodo.Text = "Período";
            // 
            // buttonTodos
            // 
            buttonTodos.Location = new Point(883, 11);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(121, 29);
            buttonTodos.TabIndex = 11;
            buttonTodos.Text = "Todos";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(756, 12);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(121, 29);
            buttonPesquisar.TabIndex = 10;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(517, 15);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(201, 25);
            comboBoxCategoria.TabIndex = 5;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(446, 21);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(65, 17);
            labelCategoria.TabIndex = 4;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(87, 53);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(353, 25);
            comboBoxProduto.TabIndex = 3;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(26, 56);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(55, 17);
            labelProduto.TabIndex = 2;
            labelProduto.Text = "Produto";
            // 
            // comboBoxFuncionario
            // 
            comboBoxFuncionario.FormattingEnabled = true;
            comboBoxFuncionario.Location = new Point(87, 16);
            comboBoxFuncionario.Name = "comboBoxFuncionario";
            comboBoxFuncionario.Size = new Size(353, 25);
            comboBoxFuncionario.TabIndex = 1;
            comboBoxFuncionario.SelectedIndexChanged += comboBoxFuncionario_SelectedIndexChanged;
            // 
            // labelFuncionario
            // 
            labelFuncionario.AutoSize = true;
            labelFuncionario.Location = new Point(6, 19);
            labelFuncionario.Name = "labelFuncionario";
            labelFuncionario.Size = new Size(75, 17);
            labelFuncionario.TabIndex = 0;
            labelFuncionario.Text = "Funcionário";
            // 
            // MovimentaEstoqueSaida
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1141, 747);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovimentaEstoqueSaida";
            Text = "MovimentaEstoqueSaida";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimentaSaida).EndInit();
            groupBoxButton02.ResumeLayout(false);
            groupBoxButton01.ResumeLayout(false);
            groupBoxButton01.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxTabela;
        private DataGridView dataGridViewMovimentaSaida;
        private GroupBox groupBoxButton02;
        private GroupBox groupBoxButton01;
        private ComboBox comboBoxCategoria;
        private Label labelCategoria;
        private ComboBox comboBoxProduto;
        private Label labelProduto;
        private ComboBox comboBoxFuncionario;
        private Label labelFuncionario;
        private Button btnPDF;
        private Button btmExel;
        private Button btnVoltar;
        private Button buttonTodos;
        private Button buttonPesquisar;
        private DateTimePicker dateTime2;
        private DateTimePicker dateTime1;
        private Label labelPeriodo;
        private Label labelAte;
    }
}