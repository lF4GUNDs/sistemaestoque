namespace controleEstoque
{
    partial class formProdutos
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
            groupBoxPodutos = new GroupBox();
            btnTodos = new Button();
            btnPesquisa = new Button();
            labelProdutos = new Label();
            comboBoxProduto = new ComboBox();
            groupBoxTabelaProdutos = new GroupBox();
            dataGridViewProdutos = new DataGridView();
            btnEditar = new GroupBox();
            button1 = new Button();
            btnNovoProduto = new Button();
            btnVoltarProduto = new Button();
            groupBoxPodutos.SuspendLayout();
            groupBoxTabelaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            btnEditar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPodutos
            // 
            groupBoxPodutos.Controls.Add(btnTodos);
            groupBoxPodutos.Controls.Add(btnPesquisa);
            groupBoxPodutos.Controls.Add(labelProdutos);
            groupBoxPodutos.Controls.Add(comboBoxProduto);
            groupBoxPodutos.Dock = DockStyle.Top;
            groupBoxPodutos.Location = new Point(0, 0);
            groupBoxPodutos.Name = "groupBoxPodutos";
            groupBoxPodutos.Size = new Size(785, 72);
            groupBoxPodutos.TabIndex = 0;
            groupBoxPodutos.TabStop = false;
            groupBoxPodutos.Text = "Campo Produtos";
            groupBoxPodutos.Enter += groupBoxPodutos_Enter;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(653, 38);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(124, 29);
            btnTodos.TabIndex = 3;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(500, 38);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(124, 29);
            btnPesquisa.TabIndex = 2;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProdutos.Location = new Point(3, 45);
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(54, 13);
            labelProdutos.TabIndex = 1;
            labelProdutos.Text = "Produtos";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(63, 38);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(372, 25);
            comboBoxProduto.TabIndex = 0;
            comboBoxProduto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBoxTabelaProdutos
            // 
            groupBoxTabelaProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTabelaProdutos.Controls.Add(dataGridViewProdutos);
            groupBoxTabelaProdutos.Location = new Point(0, 73);
            groupBoxTabelaProdutos.Name = "groupBoxTabelaProdutos";
            groupBoxTabelaProdutos.Size = new Size(785, 335);
            groupBoxTabelaProdutos.TabIndex = 1;
            groupBoxTabelaProdutos.TabStop = false;
            groupBoxTabelaProdutos.Text = "Tabela Produtos";
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Dock = DockStyle.Fill;
            dataGridViewProdutos.Location = new Point(3, 21);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.Size = new Size(779, 311);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.Controls.Add(button1);
            btnEditar.Controls.Add(btnNovoProduto);
            btnEditar.Controls.Add(btnVoltarProduto);
            btnEditar.Location = new Point(0, 426);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(30, 3, 3, 3);
            btnEditar.Size = new Size(785, 46);
            btnEditar.TabIndex = 1;
            btnEditar.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.DarkGray;
            button1.Image = Properties.Resources.editar;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(177, 5);
            button1.Name = "button1";
            button1.Padding = new Padding(4, 0, 0, 0);
            button1.Size = new Size(159, 43);
            button1.TabIndex = 7;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovoProduto.BackColor = Color.LimeGreen;
            btnNovoProduto.FlatAppearance.BorderSize = 0;
            btnNovoProduto.Image = Properties.Resources.adicionar;
            btnNovoProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoProduto.Location = new Point(620, 3);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Padding = new Padding(3, 0, 0, 0);
            btnNovoProduto.Size = new Size(159, 43);
            btnNovoProduto.TabIndex = 2;
            btnNovoProduto.Text = "Novo";
            btnNovoProduto.UseVisualStyleBackColor = false;
            btnNovoProduto.Click += button1_Click;
            // 
            // btnVoltarProduto
            // 
            btnVoltarProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarProduto.BackColor = Color.DarkGray;
            btnVoltarProduto.Image = Properties.Resources.voltar;
            btnVoltarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltarProduto.Location = new Point(12, 5);
            btnVoltarProduto.Name = "btnVoltarProduto";
            btnVoltarProduto.Padding = new Padding(4, 0, 0, 0);
            btnVoltarProduto.Size = new Size(159, 43);
            btnVoltarProduto.TabIndex = 3;
            btnVoltarProduto.Text = "Voltar";
            btnVoltarProduto.UseVisualStyleBackColor = false;
            btnVoltarProduto.Click += btnVoltarProduto_Click;
            // 
            // formProdutos
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(785, 484);
            Controls.Add(btnEditar);
            Controls.Add(groupBoxTabelaProdutos);
            Controls.Add(groupBoxPodutos);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formProdutos";
            Text = "formProdutos";
            groupBoxPodutos.ResumeLayout(false);
            groupBoxPodutos.PerformLayout();
            groupBoxTabelaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            btnEditar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPodutos;
        private Button bntPesquiProduto;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label labelPesqProdutosData;
        private DateTimePicker dateTimePicker1;
        private Label labelProdutos;
        private ComboBox comboBoxProduto;
        private GroupBox groupBoxTabelaProdutos;
        private DataGridView dataGridViewProdutos;
        private GroupBox btnEditar;
        private Button btnNovoProduto;
        private Button btnVoltarProduto;
        private Button btnPesquisa;
        private Button btnTodos;
        private Button button1;
    }
}