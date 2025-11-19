namespace controleEstoque
{
    partial class EstoqueForms
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
            dataGridViewEstoque = new DataGridView();
            groupBoxButton02 = new GroupBox();
            btnTodos = new Button();
            btnVoltar = new Button();
            btmExel = new Button();
            btnPDF = new Button();
            btnAabixoDoMinimo = new Button();
            groupBoxButton01 = new GroupBox();
            comboBoxCategoria = new ComboBox();
            Categoria = new Label();
            btnPesquisar = new Button();
            comboBox1 = new ComboBox();
            labelProduto = new Label();
            textBoxCodigoProduto = new TextBox();
            labelCodigo = new Label();
            groupBoxPrincipal.SuspendLayout();
            groupBoxTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
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
            groupBoxPrincipal.Size = new Size(1080, 533);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Estoque";
            // 
            // groupBoxTabela
            // 
            groupBoxTabela.Controls.Add(dataGridViewEstoque);
            groupBoxTabela.Dock = DockStyle.Fill;
            groupBoxTabela.Location = new Point(3, 89);
            groupBoxTabela.Name = "groupBoxTabela";
            groupBoxTabela.Size = new Size(1074, 383);
            groupBoxTabela.TabIndex = 2;
            groupBoxTabela.TabStop = false;
            groupBoxTabela.Text = "Tabela";
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Dock = DockStyle.Fill;
            dataGridViewEstoque.Location = new Point(3, 21);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.RowTemplate.Height = 25;
            dataGridViewEstoque.Size = new Size(1068, 359);
            dataGridViewEstoque.TabIndex = 0;
            // 
            // groupBoxButton02
            // 
            groupBoxButton02.Controls.Add(btnTodos);
            groupBoxButton02.Controls.Add(btnVoltar);
            groupBoxButton02.Controls.Add(btmExel);
            groupBoxButton02.Controls.Add(btnPDF);
            groupBoxButton02.Controls.Add(btnAabixoDoMinimo);
            groupBoxButton02.Dock = DockStyle.Bottom;
            groupBoxButton02.Location = new Point(3, 472);
            groupBoxButton02.Name = "groupBoxButton02";
            groupBoxButton02.Size = new Size(1074, 58);
            groupBoxButton02.TabIndex = 1;
            groupBoxButton02.TabStop = false;
            // 
            // btnTodos
            // 
            btnTodos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTodos.Location = new Point(849, 14);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(122, 38);
            btnTodos.TabIndex = 6;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BackColor = Color.DarkGray;
            btnVoltar.Image = Properties.Resources.voltar;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(10, 11);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(5, 0, 0, 0);
            btnVoltar.Size = new Size(159, 43);
            btnVoltar.TabIndex = 11;
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
            btmExel.Location = new Point(971, 13);
            btmExel.Margin = new Padding(4);
            btmExel.Name = "btmExel";
            btmExel.Size = new Size(44, 43);
            btmExel.TabIndex = 10;
            btmExel.UseVisualStyleBackColor = true;
            btmExel.Click += btmExel_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Image = Properties.Resources.pdf24;
            btnPDF.Location = new Point(1020, 11);
            btnPDF.Margin = new Padding(4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(44, 43);
            btnPDF.TabIndex = 9;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnAabixoDoMinimo
            // 
            btnAabixoDoMinimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAabixoDoMinimo.Location = new Point(692, 13);
            btnAabixoDoMinimo.Name = "btnAabixoDoMinimo";
            btnAabixoDoMinimo.Size = new Size(151, 38);
            btnAabixoDoMinimo.TabIndex = 5;
            btnAabixoDoMinimo.Text = "Abaixo do Minímo";
            btnAabixoDoMinimo.UseVisualStyleBackColor = true;
            btnAabixoDoMinimo.Click += btnAabixoDoMinimo_Click;
            // 
            // groupBoxButton01
            // 
            groupBoxButton01.Controls.Add(comboBoxCategoria);
            groupBoxButton01.Controls.Add(Categoria);
            groupBoxButton01.Controls.Add(btnPesquisar);
            groupBoxButton01.Controls.Add(comboBox1);
            groupBoxButton01.Controls.Add(labelProduto);
            groupBoxButton01.Controls.Add(textBoxCodigoProduto);
            groupBoxButton01.Controls.Add(labelCodigo);
            groupBoxButton01.Dock = DockStyle.Top;
            groupBoxButton01.Location = new Point(3, 21);
            groupBoxButton01.Name = "groupBoxButton01";
            groupBoxButton01.Size = new Size(1074, 68);
            groupBoxButton01.TabIndex = 0;
            groupBoxButton01.TabStop = false;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(733, 16);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(174, 25);
            comboBoxCategoria.TabIndex = 5;
            comboBoxCategoria.DropDown += comboBoxCategoria_DropDown;
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Location = new Point(644, 19);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(65, 17);
            Categoria.TabIndex = 4;
            Categoria.Text = "Categoria";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(940, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(95, 25);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 25);
            comboBox1.TabIndex = 3;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(256, 19);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(55, 17);
            labelProduto.TabIndex = 2;
            labelProduto.Text = "Produto";
            // 
            // textBoxCodigoProduto
            // 
            textBoxCodigoProduto.Location = new Point(117, 16);
            textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            textBoxCodigoProduto.Size = new Size(133, 25);
            textBoxCodigoProduto.TabIndex = 1;
            textBoxCodigoProduto.TextChanged += textBoxCodigoProduto_TextChanged;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(9, 19);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(102, 17);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código Produto";
            // 
            // EstoqueForms
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1080, 533);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EstoqueForms";
            Text = "EstoqueForms";
            Load += EstoqueForms_Load;
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            groupBoxButton02.ResumeLayout(false);
            groupBoxButton01.ResumeLayout(false);
            groupBoxButton01.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxTabela;
        private GroupBox groupBoxButton02;
        private GroupBox groupBoxButton01;
        private Button btnPesquisar;
        private ComboBox comboBox1;
        private Label labelProduto;
        private TextBox textBoxCodigoProduto;
        private Label labelCodigo;
        private Button btnAabixoDoMinimo;
        private Button btnPDF;
        private Button btmExel;
        private Button btnVoltar;
        private Label Categoria;
        private DataGridView dataGridViewEstoque;
        private ComboBox comboBoxCategoria;
        private Button btnTodos;
    }
}