namespace controleEstoque
{
    partial class FuncionariosForms
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
            groupBoxTabelaFuncionario = new GroupBox();
            dataGridViewFuncionario = new DataGridView();
            grupBoxBtn2 = new GroupBox();
            btnEditar = new Button();
            btnNovoProduto = new Button();
            btnVoltar = new Button();
            groupBoxBtn = new GroupBox();
            labelFuncionarios = new Label();
            btnTodos = new Button();
            comboBoxFuncionario = new ComboBox();
            btnPesquisa = new Button();
            groupBoxPrincipal.SuspendLayout();
            groupBoxTabelaFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).BeginInit();
            grupBoxBtn2.SuspendLayout();
            groupBoxBtn.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Controls.Add(groupBoxTabelaFuncionario);
            groupBoxPrincipal.Controls.Add(grupBoxBtn2);
            groupBoxPrincipal.Controls.Add(groupBoxBtn);
            groupBoxPrincipal.Dock = DockStyle.Fill;
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(812, 573);
            groupBoxPrincipal.TabIndex = 1;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Campo Funcionário";
            // 
            // groupBoxTabelaFuncionario
            // 
            groupBoxTabelaFuncionario.Controls.Add(dataGridViewFuncionario);
            groupBoxTabelaFuncionario.Dock = DockStyle.Fill;
            groupBoxTabelaFuncionario.Location = new Point(3, 89);
            groupBoxTabelaFuncionario.Name = "groupBoxTabelaFuncionario";
            groupBoxTabelaFuncionario.Size = new Size(806, 425);
            groupBoxTabelaFuncionario.TabIndex = 6;
            groupBoxTabelaFuncionario.TabStop = false;
            groupBoxTabelaFuncionario.Text = "Tabela Funcionario";
            // 
            // dataGridViewFuncionario
            // 
            dataGridViewFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionario.Dock = DockStyle.Fill;
            dataGridViewFuncionario.Location = new Point(3, 21);
            dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            dataGridViewFuncionario.RowTemplate.Height = 25;
            dataGridViewFuncionario.Size = new Size(800, 401);
            dataGridViewFuncionario.TabIndex = 0;
            // 
            // grupBoxBtn2
            // 
            grupBoxBtn2.Controls.Add(btnEditar);
            grupBoxBtn2.Controls.Add(btnNovoProduto);
            grupBoxBtn2.Controls.Add(btnVoltar);
            grupBoxBtn2.Dock = DockStyle.Bottom;
            grupBoxBtn2.Location = new Point(3, 514);
            grupBoxBtn2.Name = "grupBoxBtn2";
            grupBoxBtn2.Padding = new Padding(30, 3, 3, 3);
            grupBoxBtn2.Size = new Size(806, 56);
            grupBoxBtn2.TabIndex = 5;
            grupBoxBtn2.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.DarkGray;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(165, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(4, 0, 0, 0);
            btnEditar.Size = new Size(159, 43);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovoProduto.BackColor = Color.LimeGreen;
            btnNovoProduto.FlatAppearance.BorderSize = 0;
            btnNovoProduto.Image = Properties.Resources.adicionar;
            btnNovoProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoProduto.Location = new Point(644, 10);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Padding = new Padding(3, 0, 0, 0);
            btnNovoProduto.Size = new Size(159, 43);
            btnNovoProduto.TabIndex = 2;
            btnNovoProduto.Text = "Novo";
            btnNovoProduto.UseVisualStyleBackColor = false;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BackColor = Color.DarkGray;
            btnVoltar.Image = Properties.Resources.voltar;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(0, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(4, 0, 0, 0);
            btnVoltar.Size = new Size(159, 43);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // groupBoxBtn
            // 
            groupBoxBtn.Controls.Add(labelFuncionarios);
            groupBoxBtn.Controls.Add(btnTodos);
            groupBoxBtn.Controls.Add(comboBoxFuncionario);
            groupBoxBtn.Controls.Add(btnPesquisa);
            groupBoxBtn.Dock = DockStyle.Top;
            groupBoxBtn.Location = new Point(3, 21);
            groupBoxBtn.Name = "groupBoxBtn";
            groupBoxBtn.Size = new Size(806, 68);
            groupBoxBtn.TabIndex = 4;
            groupBoxBtn.TabStop = false;
            // 
            // labelFuncionarios
            // 
            labelFuncionarios.AutoSize = true;
            labelFuncionarios.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFuncionarios.Location = new Point(6, 30);
            labelFuncionarios.Name = "labelFuncionarios";
            labelFuncionarios.Size = new Size(74, 13);
            labelFuncionarios.TabIndex = 1;
            labelFuncionarios.Text = "Funcionários";
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(676, 24);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(124, 25);
            btnTodos.TabIndex = 3;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // comboBoxFuncionario
            // 
            comboBoxFuncionario.FormattingEnabled = true;
            comboBoxFuncionario.Location = new Point(86, 24);
            comboBoxFuncionario.Name = "comboBoxFuncionario";
            comboBoxFuncionario.Size = new Size(372, 25);
            comboBoxFuncionario.TabIndex = 0;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(504, 24);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(124, 25);
            btnPesquisa.TabIndex = 2;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // FuncionariosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 573);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionariosForms";
            Text = "FuncionariosForms";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxTabelaFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).EndInit();
            grupBoxBtn2.ResumeLayout(false);
            groupBoxBtn.ResumeLayout(false);
            groupBoxBtn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxBtn;
        private Label labelFuncionarios;
        private Button btnTodos;
        private ComboBox comboBoxFuncionario;
        private Button btnPesquisa;
        private GroupBox grupBoxBtn2;
        private Button btnEditar;
        private Button btnNovoProduto;
        private Button btnVoltar;
        private GroupBox groupBoxTabelaFuncionario;
        private DataGridView dataGridViewFuncionario;
        private Button pdfBtn;
    }
}