namespace controleEstoque
{
    partial class SaidaDeProdutos
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
            groupTabela1 = new GroupBox();
            dataGridListaProdutos = new DataGridView();
            groupBoxButton2 = new GroupBox();
            btnVoltar = new Button();
            btnCancela = new Button();
            btnConfirmar = new Button();
            groupBoxButton1 = new GroupBox();
            textBoxObservacao = new TextBox();
            labelObservacao = new Label();
            btnAdicionar = new Button();
            textBoxQuantidade = new TextBox();
            labelQuantidade = new Label();
            comboBoxProduto = new ComboBox();
            labelNomeProduto = new Label();
            comboBoxFuncionario = new ComboBox();
            labelFuncionario = new Label();
            groupBoxPrincipal.SuspendLayout();
            groupTabela1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridListaProdutos).BeginInit();
            groupBoxButton2.SuspendLayout();
            groupBoxButton1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(groupTabela1);
            groupBoxPrincipal.Controls.Add(groupBoxButton2);
            groupBoxPrincipal.Controls.Add(groupBoxButton1);
            groupBoxPrincipal.Dock = DockStyle.Fill;
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(1168, 565);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Saída";
            // 
            // groupTabela1
            // 
            groupTabela1.Controls.Add(dataGridListaProdutos);
            groupTabela1.Dock = DockStyle.Fill;
            groupTabela1.Location = new Point(3, 144);
            groupTabela1.Margin = new Padding(4);
            groupTabela1.Name = "groupTabela1";
            groupTabela1.Padding = new Padding(4);
            groupTabela1.Size = new Size(1162, 362);
            groupTabela1.TabIndex = 5;
            groupTabela1.TabStop = false;
            groupTabela1.Text = "Tabela";
            // 
            // dataGridListaProdutos
            // 
            dataGridListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListaProdutos.Dock = DockStyle.Fill;
            dataGridListaProdutos.Location = new Point(4, 22);
            dataGridListaProdutos.Margin = new Padding(4);
            dataGridListaProdutos.Name = "dataGridListaProdutos";
            dataGridListaProdutos.RowTemplate.Height = 25;
            dataGridListaProdutos.Size = new Size(1154, 336);
            dataGridListaProdutos.TabIndex = 0;
            dataGridListaProdutos.CellContentClick += dataGridListaProdutos_CellContentClick;
            // 
            // groupBoxButton2
            // 
            groupBoxButton2.Controls.Add(btnVoltar);
            groupBoxButton2.Controls.Add(btnCancela);
            groupBoxButton2.Controls.Add(btnConfirmar);
            groupBoxButton2.Dock = DockStyle.Bottom;
            groupBoxButton2.Location = new Point(3, 506);
            groupBoxButton2.Name = "groupBoxButton2";
            groupBoxButton2.Size = new Size(1162, 56);
            groupBoxButton2.TabIndex = 1;
            groupBoxButton2.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BackColor = Color.DarkGray;
            btnVoltar.Image = Properties.Resources.voltar;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(4, 12);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(5, 0, 0, 0);
            btnVoltar.Size = new Size(159, 43);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCancela
            // 
            btnCancela.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancela.BackColor = Color.IndianRed;
            btnCancela.Location = new Point(787, 10);
            btnCancela.Margin = new Padding(4);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(168, 46);
            btnCancela.TabIndex = 2;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.LawnGreen;
            btnConfirmar.Location = new Point(987, 9);
            btnConfirmar.Margin = new Padding(4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(168, 46);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // groupBoxButton1
            // 
            groupBoxButton1.Controls.Add(textBoxObservacao);
            groupBoxButton1.Controls.Add(labelObservacao);
            groupBoxButton1.Controls.Add(btnAdicionar);
            groupBoxButton1.Controls.Add(textBoxQuantidade);
            groupBoxButton1.Controls.Add(labelQuantidade);
            groupBoxButton1.Controls.Add(comboBoxProduto);
            groupBoxButton1.Controls.Add(labelNomeProduto);
            groupBoxButton1.Controls.Add(comboBoxFuncionario);
            groupBoxButton1.Controls.Add(labelFuncionario);
            groupBoxButton1.Dock = DockStyle.Top;
            groupBoxButton1.Location = new Point(3, 21);
            groupBoxButton1.Name = "groupBoxButton1";
            groupBoxButton1.Size = new Size(1162, 123);
            groupBoxButton1.TabIndex = 0;
            groupBoxButton1.TabStop = false;
            // 
            // textBoxObservacao
            // 
            textBoxObservacao.Location = new Point(701, 68);
            textBoxObservacao.Margin = new Padding(4);
            textBoxObservacao.Name = "textBoxObservacao";
            textBoxObservacao.Size = new Size(303, 25);
            textBoxObservacao.TabIndex = 10;
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Location = new Point(615, 71);
            labelObservacao.Margin = new Padding(4, 0, 4, 0);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(78, 17);
            labelObservacao.TabIndex = 9;
            labelObservacao.Text = "Observação";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(1049, 65);
            btnAdicionar.Margin = new Padding(4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(103, 29);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(477, 68);
            textBoxQuantidade.Margin = new Padding(4);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(130, 25);
            textBoxQuantidade.TabIndex = 7;
            textBoxQuantidade.TextChanged += textBoxQuantidade_TextChanged;
            textBoxQuantidade.KeyPress += textBoxQuantidade_KeyPress;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(393, 71);
            labelQuantidade.Margin = new Padding(4, 0, 4, 0);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(76, 17);
            labelQuantidade.TabIndex = 6;
            labelQuantidade.Text = "Quantidade";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(101, 68);
            comboBoxProduto.Margin = new Padding(4);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(284, 25);
            comboBoxProduto.TabIndex = 5;
            // 
            // labelNomeProduto
            // 
            labelNomeProduto.AutoSize = true;
            labelNomeProduto.Location = new Point(10, 73);
            labelNomeProduto.Margin = new Padding(4, 0, 4, 0);
            labelNomeProduto.Name = "labelNomeProduto";
            labelNomeProduto.Size = new Size(55, 17);
            labelNomeProduto.TabIndex = 4;
            labelNomeProduto.Text = "Produto";
            // 
            // comboBoxFuncionario
            // 
            comboBoxFuncionario.FormattingEnabled = true;
            comboBoxFuncionario.Location = new Point(101, 21);
            comboBoxFuncionario.Margin = new Padding(4);
            comboBoxFuncionario.Name = "comboBoxFuncionario";
            comboBoxFuncionario.Size = new Size(284, 25);
            comboBoxFuncionario.TabIndex = 3;
            // 
            // labelFuncionario
            // 
            labelFuncionario.AutoSize = true;
            labelFuncionario.Location = new Point(7, 25);
            labelFuncionario.Margin = new Padding(4, 0, 4, 0);
            labelFuncionario.Name = "labelFuncionario";
            labelFuncionario.Size = new Size(75, 17);
            labelFuncionario.TabIndex = 2;
            labelFuncionario.Text = "Funcionário";
            // 
            // SaidaDeProdutos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1168, 565);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaidaDeProdutos";
            Text = "SaidaDeProdutos";
            groupBoxPrincipal.ResumeLayout(false);
            groupTabela1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridListaProdutos).EndInit();
            groupBoxButton2.ResumeLayout(false);
            groupBoxButton1.ResumeLayout(false);
            groupBoxButton1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxButton1;
        private ComboBox comboBoxFuncionario;
        private Label labelFuncionario;
        private GroupBox groupBoxButton2;
        private Button btnConfirmar;
        private GroupBox groupTabela1;
        private DataGridView dataGridListaProdutos;
        private ComboBox comboBoxProduto;
        private Label labelNomeProduto;
        private TextBox textBoxObservacao;
        private Label labelObservacao;
        private Button btnAdicionar;
        private TextBox textBoxQuantidade;
        private Label labelQuantidade;
        private Button btnCancela;
        private Button btnVoltar;
    }
}