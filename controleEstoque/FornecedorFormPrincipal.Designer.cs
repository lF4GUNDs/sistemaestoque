namespace controleEstoque
{
    partial class FornecedorFormPrincipal
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
            groupBoxTabelaFornecedor = new GroupBox();
            dataGridViewFornecedor = new DataGridView();
            grupBoxButton2 = new GroupBox();
            button1 = new Button();
            btnNovoProduto = new Button();
            btnVoltarProduto = new Button();
            groupBoxFornecedor = new GroupBox();
            btnTodos = new Button();
            btnPesquisa = new Button();
            labelFornecedor = new Label();
            comboBoxFornecedor = new ComboBox();
            groupBoxPrincipal.SuspendLayout();
            groupBoxTabelaFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedor).BeginInit();
            grupBoxButton2.SuspendLayout();
            groupBoxFornecedor.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(groupBoxTabelaFornecedor);
            groupBoxPrincipal.Controls.Add(grupBoxButton2);
            groupBoxPrincipal.Controls.Add(groupBoxFornecedor);
            groupBoxPrincipal.Dock = DockStyle.Fill;
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(800, 476);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Fornecedor";
            // 
            // groupBoxTabelaFornecedor
            // 
            groupBoxTabelaFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTabelaFornecedor.Controls.Add(dataGridViewFornecedor);
            groupBoxTabelaFornecedor.Location = new Point(9, 92);
            groupBoxTabelaFornecedor.Name = "groupBoxTabelaFornecedor";
            groupBoxTabelaFornecedor.Size = new Size(783, 326);
            groupBoxTabelaFornecedor.TabIndex = 3;
            groupBoxTabelaFornecedor.TabStop = false;
            groupBoxTabelaFornecedor.Text = "Tabela Fornecedor";
            // 
            // dataGridViewFornecedor
            // 
            dataGridViewFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornecedor.Dock = DockStyle.Fill;
            dataGridViewFornecedor.Location = new Point(3, 21);
            dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            dataGridViewFornecedor.RowTemplate.Height = 25;
            dataGridViewFornecedor.Size = new Size(777, 302);
            dataGridViewFornecedor.TabIndex = 0;
            // 
            // grupBoxButton2
            // 
            grupBoxButton2.Controls.Add(button1);
            grupBoxButton2.Controls.Add(btnNovoProduto);
            grupBoxButton2.Controls.Add(btnVoltarProduto);
            grupBoxButton2.Dock = DockStyle.Bottom;
            grupBoxButton2.Location = new Point(3, 424);
            grupBoxButton2.Name = "grupBoxButton2";
            grupBoxButton2.Padding = new Padding(30, 3, 3, 3);
            grupBoxButton2.Size = new Size(794, 49);
            grupBoxButton2.TabIndex = 2;
            grupBoxButton2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.DarkGray;
            button1.Image = Properties.Resources.editar;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(171, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(4, 0, 0, 0);
            button1.Size = new Size(159, 43);
            button1.TabIndex = 7;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovoProduto.BackColor = Color.LimeGreen;
            btnNovoProduto.FlatAppearance.BorderSize = 0;
            btnNovoProduto.Image = Properties.Resources.adicionar;
            btnNovoProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoProduto.Location = new Point(630, 0);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Padding = new Padding(3, 0, 0, 0);
            btnNovoProduto.Size = new Size(159, 43);
            btnNovoProduto.TabIndex = 2;
            btnNovoProduto.Text = "Novo";
            btnNovoProduto.UseVisualStyleBackColor = false;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // btnVoltarProduto
            // 
            btnVoltarProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarProduto.BackColor = Color.DarkGray;
            btnVoltarProduto.Image = Properties.Resources.voltar;
            btnVoltarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltarProduto.Location = new Point(6, 0);
            btnVoltarProduto.Name = "btnVoltarProduto";
            btnVoltarProduto.Padding = new Padding(4, 0, 0, 0);
            btnVoltarProduto.Size = new Size(159, 43);
            btnVoltarProduto.TabIndex = 3;
            btnVoltarProduto.Text = "Voltar";
            btnVoltarProduto.UseVisualStyleBackColor = false;
            btnVoltarProduto.Click += btnVoltarProduto_Click;
            // 
            // groupBoxFornecedor
            // 
            groupBoxFornecedor.Controls.Add(btnTodos);
            groupBoxFornecedor.Controls.Add(btnPesquisa);
            groupBoxFornecedor.Controls.Add(labelFornecedor);
            groupBoxFornecedor.Controls.Add(comboBoxFornecedor);
            groupBoxFornecedor.Dock = DockStyle.Top;
            groupBoxFornecedor.Location = new Point(3, 21);
            groupBoxFornecedor.Name = "groupBoxFornecedor";
            groupBoxFornecedor.Size = new Size(794, 67);
            groupBoxFornecedor.TabIndex = 1;
            groupBoxFornecedor.TabStop = false;
            groupBoxFornecedor.Text = "Campo Fornecedor";
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(661, 35);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(124, 29);
            btnTodos.TabIndex = 3;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(531, 35);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(124, 29);
            btnPesquisa.TabIndex = 2;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFornecedor.Location = new Point(9, 39);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(89, 21);
            labelFornecedor.TabIndex = 1;
            labelFornecedor.Text = "Fornecedor";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(104, 35);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(372, 25);
            comboBoxFornecedor.TabIndex = 0;
            comboBoxFornecedor.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // FornecedorFormPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 476);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FornecedorFormPrincipal";
            Text = "FornecedorFormPrincipal";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxTabelaFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedor).EndInit();
            grupBoxButton2.ResumeLayout(false);
            groupBoxFornecedor.ResumeLayout(false);
            groupBoxFornecedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxFornecedor;
        private Button btnTodos;
        private Button btnPesquisa;
        private Label labelFornecedor;
        private ComboBox comboBoxFornecedor;
        private GroupBox grupBoxButton2;
        private Button button1;
        private Button btnNovoProduto;
        private Button btnVoltarProduto;
        private GroupBox groupBoxTabelaFornecedor;
        private DataGridView dataGridViewFornecedor;
    }
}