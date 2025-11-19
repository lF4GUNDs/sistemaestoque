namespace controleEstoque
{
    partial class EntradaProdutosForm
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
            dataGridViewProdutos = new DataGridView();
            groupBoxButton02 = new GroupBox();
            btnCancela = new Button();
            btnVoltar = new Button();
            btnConformar = new Button();
            groupBoxButton01 = new GroupBox();
            btnAdicionar = new Button();
            labelFornecedor = new Label();
            labelQuantidade = new Label();
            labelProdutos = new Label();
            comboBoxFornecedor = new ComboBox();
            comboBoxProduto = new ComboBox();
            textBoxQuantidade = new TextBox();
            groupBoxPrincipal.SuspendLayout();
            groupBoxTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
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
            groupBoxPrincipal.Size = new Size(967, 633);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Entrada";
            // 
            // groupBoxTabela
            // 
            groupBoxTabela.Controls.Add(dataGridViewProdutos);
            groupBoxTabela.Dock = DockStyle.Fill;
            groupBoxTabela.Location = new Point(3, 130);
            groupBoxTabela.Name = "groupBoxTabela";
            groupBoxTabela.Size = new Size(961, 435);
            groupBoxTabela.TabIndex = 2;
            groupBoxTabela.TabStop = false;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Dock = DockStyle.Fill;
            dataGridViewProdutos.Location = new Point(3, 21);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.Size = new Size(955, 411);
            dataGridViewProdutos.TabIndex = 0;
            dataGridViewProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBoxButton02
            // 
            groupBoxButton02.Controls.Add(btnCancela);
            groupBoxButton02.Controls.Add(btnVoltar);
            groupBoxButton02.Controls.Add(btnConformar);
            groupBoxButton02.Dock = DockStyle.Bottom;
            groupBoxButton02.Location = new Point(3, 565);
            groupBoxButton02.Name = "groupBoxButton02";
            groupBoxButton02.Size = new Size(961, 65);
            groupBoxButton02.TabIndex = 1;
            groupBoxButton02.TabStop = false;
            // 
            // btnCancela
            // 
            btnCancela.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancela.BackColor = Color.IndianRed;
            btnCancela.Location = new Point(609, 13);
            btnCancela.Margin = new Padding(4);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(168, 46);
            btnCancela.TabIndex = 6;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BackColor = Color.DarkGray;
            btnVoltar.Image = Properties.Resources.voltar;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(10, 14);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(5, 0, 0, 0);
            btnVoltar.Size = new Size(159, 43);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnConformar
            // 
            btnConformar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConformar.BackColor = Color.LawnGreen;
            btnConformar.Location = new Point(784, 13);
            btnConformar.Name = "btnConformar";
            btnConformar.Size = new Size(168, 46);
            btnConformar.TabIndex = 0;
            btnConformar.Text = "Confirmar";
            btnConformar.UseVisualStyleBackColor = false;
            btnConformar.Click += btnConformar_Click;
            // 
            // groupBoxButton01
            // 
            groupBoxButton01.Controls.Add(btnAdicionar);
            groupBoxButton01.Controls.Add(labelFornecedor);
            groupBoxButton01.Controls.Add(labelQuantidade);
            groupBoxButton01.Controls.Add(labelProdutos);
            groupBoxButton01.Controls.Add(comboBoxFornecedor);
            groupBoxButton01.Controls.Add(comboBoxProduto);
            groupBoxButton01.Controls.Add(textBoxQuantidade);
            groupBoxButton01.Dock = DockStyle.Top;
            groupBoxButton01.Location = new Point(3, 21);
            groupBoxButton01.Name = "groupBoxButton01";
            groupBoxButton01.Size = new Size(961, 109);
            groupBoxButton01.TabIndex = 0;
            groupBoxButton01.TabStop = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(808, 64);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(144, 29);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Location = new Point(9, 25);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(75, 17);
            labelFornecedor.TabIndex = 5;
            labelFornecedor.Text = "Fornecedor";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(417, 67);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(76, 17);
            labelQuantidade.TabIndex = 4;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.Location = new Point(6, 64);
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(61, 17);
            labelProdutos.TabIndex = 3;
            labelProdutos.Text = "Produtos";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(104, 22);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(307, 25);
            comboBoxFornecedor.TabIndex = 2;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(104, 64);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(307, 25);
            comboBoxProduto.TabIndex = 1;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(514, 64);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(154, 25);
            textBoxQuantidade.TabIndex = 0;
            textBoxQuantidade.KeyPress += textBoxQuantidade_KeyPress_1;
            // 
            // EntradaProdutosForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(967, 633);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EntradaProdutosForm";
            Text = "EntradaProdutosForm";
            Load += EntradaProdutosForm_Load;
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            groupBoxButton02.ResumeLayout(false);
            groupBoxButton01.ResumeLayout(false);
            groupBoxButton01.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxTabela;
        private DataGridView dataGridViewProdutos;
        private GroupBox groupBoxButton02;
        private GroupBox groupBoxButton01;
        private TextBox textBoxQuantidade;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private Button btnConformar;
        private Button btnAdicionar;
        private Label labelFornecedor;
        private Label labelQuantidade;
        private Label labelProdutos;
        private Button btnVoltar;
        private Button btnCancela;
    }
}