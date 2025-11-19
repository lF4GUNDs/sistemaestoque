namespace controleEstoque
{
    partial class CadastroFornecedor
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
            groupBox1 = new GroupBox();
            cpf_cnpj = new Label();
            labelContato = new Label();
            textBoxContato = new TextBox();
            textBoxBairro = new TextBox();
            textBoxCodigoCPF = new TextBox();
            textBoxEmail = new TextBox();
            labelBairro = new Label();
            labelEmail = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEndereco = new TextBox();
            labelTelefone = new Label();
            labelEndereco = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            groupBoxButtons = new GroupBox();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            groupBoxPrincipal.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Anchor = AnchorStyles.None;
            groupBoxPrincipal.Controls.Add(groupBox1);
            groupBoxPrincipal.Controls.Add(groupBoxButtons);
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(894, 456);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Cadastro Fornecedor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cpf_cnpj);
            groupBox1.Controls.Add(labelContato);
            groupBox1.Controls.Add(textBoxContato);
            groupBox1.Controls.Add(textBoxBairro);
            groupBox1.Controls.Add(textBoxCodigoCPF);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelBairro);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(textBoxTelefone);
            groupBox1.Controls.Add(textBoxEndereco);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Controls.Add(labelEndereco);
            groupBox1.Controls.Add(textBoxCidade);
            groupBox1.Controls.Add(labelCidade);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 370);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // cpf_cnpj
            // 
            cpf_cnpj.AutoSize = true;
            cpf_cnpj.Location = new Point(6, 28);
            cpf_cnpj.Name = "cpf_cnpj";
            cpf_cnpj.Size = new Size(62, 17);
            cpf_cnpj.TabIndex = 16;
            cpf_cnpj.Text = "Cpf/CNPJ";
            cpf_cnpj.Click += cpf_cnpj_Click;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(9, 303);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(54, 17);
            labelContato.TabIndex = 27;
            labelContato.Text = "Contato";
            labelContato.Click += labelContato_Click;
            // 
            // textBoxContato
            // 
            textBoxContato.Location = new Point(88, 300);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(272, 25);
            textBoxContato.TabIndex = 28;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(88, 194);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(272, 25);
            textBoxBairro.TabIndex = 30;
            // 
            // textBoxCodigoCPF
            // 
            textBoxCodigoCPF.Enabled = false;
            textBoxCodigoCPF.Location = new Point(88, 25);
            textBoxCodigoCPF.Name = "textBoxCodigoCPF";
            textBoxCodigoCPF.Size = new Size(287, 25);
            textBoxCodigoCPF.TabIndex = 15;
            textBoxCodigoCPF.TextChanged += textBoxCodigoCPF_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(430, 250);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(337, 25);
            textBoxEmail.TabIndex = 26;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(9, 197);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(43, 17);
            labelBairro.TabIndex = 29;
            labelBairro.Text = "Bairro";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(376, 253);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 17);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(6, 86);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(48, 17);
            labelNome.TabIndex = 17;
            labelNome.Text = "Nome ";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(88, 86);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(510, 25);
            textBoxNome.TabIndex = 14;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(88, 250);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(272, 25);
            textBoxTelefone.TabIndex = 23;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(88, 141);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(510, 25);
            textBoxEndereco.TabIndex = 19;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(9, 253);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(57, 17);
            labelTelefone.TabIndex = 22;
            labelTelefone.Text = "Telefone";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(6, 141);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(63, 17);
            labelEndereco.TabIndex = 18;
            labelEndereco.Text = "Endereço";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(430, 194);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(337, 25);
            textBoxCidade.TabIndex = 20;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(366, 197);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(49, 17);
            labelCidade.TabIndex = 21;
            labelCidade.Text = "Cidade";
            labelCidade.Click += labelCidade_Click;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonCancelar);
            groupBoxButtons.Controls.Add(buttonConfirmar);
            groupBoxButtons.Dock = DockStyle.Bottom;
            groupBoxButtons.Location = new Point(3, 391);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(888, 62);
            groupBoxButtons.TabIndex = 24;
            groupBoxButtons.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.IndianRed;
            buttonCancelar.Location = new Point(562, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(157, 49);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmar.BackColor = Color.Lime;
            buttonConfirmar.Location = new Point(725, 7);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(157, 49);
            buttonConfirmar.TabIndex = 2;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // CadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(894, 456);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroFornecedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CadastroFornecedor";
            groupBoxPrincipal.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private TextBox textBoxTelefone;
        private Label labelTelefone;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxEndereco;
        private Label labelEndereco;
        private Label labelNome;
        private Label cpf_cnpj;
        private TextBox textBoxCodigoCPF;
        private TextBox textBoxNome;
        private GroupBox groupBoxButtons;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private TextBox textBoxContato;
        private Label labelContato;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private GroupBox groupBox1;
    }
}