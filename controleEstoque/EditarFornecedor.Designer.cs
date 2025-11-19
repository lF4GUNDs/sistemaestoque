namespace controleEstoque
{
    partial class EditarFornecedor
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
            btnBuscar = new Button();
            textBoxData = new TextBox();
            labelData = new Label();
            comboBoxFornecedor = new ComboBox();
            labelFornecedor = new Label();
            textBoxId = new TextBox();
            labelId = new Label();
            groupBoxButton = new GroupBox();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            textBoxContato = new TextBox();
            labelContato = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelefone = new TextBox();
            labelTelefone = new Label();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            textBoxEndereco = new TextBox();
            labelEndereco = new Label();
            labelNome = new Label();
            cpf_cnpj = new Label();
            textBoxcpf_cnpj = new TextBox();
            textBoxNome = new TextBox();
            groupBoxPrincipal.SuspendLayout();
            groupBoxButton.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Anchor = AnchorStyles.None;
            groupBoxPrincipal.Controls.Add(btnBuscar);
            groupBoxPrincipal.Controls.Add(textBoxData);
            groupBoxPrincipal.Controls.Add(labelData);
            groupBoxPrincipal.Controls.Add(comboBoxFornecedor);
            groupBoxPrincipal.Controls.Add(labelFornecedor);
            groupBoxPrincipal.Controls.Add(textBoxId);
            groupBoxPrincipal.Controls.Add(labelId);
            groupBoxPrincipal.Controls.Add(groupBoxButton);
            groupBoxPrincipal.Controls.Add(textBoxBairro);
            groupBoxPrincipal.Controls.Add(labelBairro);
            groupBoxPrincipal.Controls.Add(textBoxContato);
            groupBoxPrincipal.Controls.Add(labelContato);
            groupBoxPrincipal.Controls.Add(textBoxEmail);
            groupBoxPrincipal.Controls.Add(labelEmail);
            groupBoxPrincipal.Controls.Add(textBoxTelefone);
            groupBoxPrincipal.Controls.Add(labelTelefone);
            groupBoxPrincipal.Controls.Add(labelCidade);
            groupBoxPrincipal.Controls.Add(textBoxCidade);
            groupBoxPrincipal.Controls.Add(textBoxEndereco);
            groupBoxPrincipal.Controls.Add(labelEndereco);
            groupBoxPrincipal.Controls.Add(labelNome);
            groupBoxPrincipal.Controls.Add(cpf_cnpj);
            groupBoxPrincipal.Controls.Add(textBoxcpf_cnpj);
            groupBoxPrincipal.Controls.Add(textBoxNome);
            groupBoxPrincipal.Location = new Point(1, 7);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(889, 609);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Editar Fornecedor";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(640, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 28);
            btnBuscar.TabIndex = 54;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBoxData
            // 
            textBoxData.Enabled = false;
            textBoxData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxData.Location = new Point(650, 133);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(175, 27);
            textBoxData.TabIndex = 53;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(536, 136);
            labelData.Name = "labelData";
            labelData.Size = new Size(92, 17);
            labelData.TabIndex = 52;
            labelData.Text = "Data Cadastro";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(133, 41);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(448, 25);
            comboBoxFornecedor.TabIndex = 51;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Location = new Point(21, 41);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(75, 17);
            labelFornecedor.TabIndex = 50;
            labelFornecedor.Text = "Fornecedor";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(424, 133);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(90, 25);
            textBoxId.TabIndex = 49;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(393, 136);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 17);
            labelId.TabIndex = 48;
            labelId.Text = "ID";
            // 
            // groupBoxButton
            // 
            groupBoxButton.Anchor = AnchorStyles.None;
            groupBoxButton.Controls.Add(buttonCancelar);
            groupBoxButton.Controls.Add(buttonConfirmar);
            groupBoxButton.Location = new Point(3, 553);
            groupBoxButton.Name = "groupBoxButton";
            groupBoxButton.Size = new Size(883, 53);
            groupBoxButton.TabIndex = 47;
            groupBoxButton.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.IndianRed;
            buttonCancelar.Location = new Point(533, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(157, 49);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmar.BackColor = Color.Lime;
            buttonConfirmar.Location = new Point(720, 4);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(157, 49);
            buttonConfirmar.TabIndex = 4;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(146, 339);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(272, 25);
            textBoxBairro.TabIndex = 46;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(58, 342);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(43, 17);
            labelBairro.TabIndex = 45;
            labelBairro.Text = "Bairro";
            // 
            // textBoxContato
            // 
            textBoxContato.Location = new Point(146, 500);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(272, 25);
            textBoxContato.TabIndex = 44;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(45, 503);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(54, 17);
            labelContato.TabIndex = 43;
            labelContato.Text = "Contato";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(488, 415);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(337, 25);
            textBoxEmail.TabIndex = 42;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(434, 418);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 17);
            labelEmail.TabIndex = 41;
            labelEmail.Text = "Email";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(146, 415);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(272, 25);
            textBoxTelefone.TabIndex = 40;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(43, 418);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(57, 17);
            labelTelefone.TabIndex = 39;
            labelTelefone.Text = "Telefone";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(424, 347);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(49, 17);
            labelCidade.TabIndex = 38;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(488, 339);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(337, 25);
            textBoxCidade.TabIndex = 37;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(146, 269);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(510, 25);
            textBoxEndereco.TabIndex = 36;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(36, 272);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(63, 17);
            labelEndereco.TabIndex = 35;
            labelEndereco.Text = "Endereço";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(53, 213);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(48, 17);
            labelNome.TabIndex = 34;
            labelNome.Text = "Nome ";
            // 
            // cpf_cnpj
            // 
            cpf_cnpj.AutoSize = true;
            cpf_cnpj.Location = new Point(34, 136);
            cpf_cnpj.Name = "cpf_cnpj";
            cpf_cnpj.Size = new Size(62, 17);
            cpf_cnpj.TabIndex = 33;
            cpf_cnpj.Text = "Cpf/CNPJ";
            // 
            // textBoxcpf_cnpj
            // 
            textBoxcpf_cnpj.Enabled = false;
            textBoxcpf_cnpj.Location = new Point(146, 133);
            textBoxcpf_cnpj.Name = "textBoxcpf_cnpj";
            textBoxcpf_cnpj.Size = new Size(213, 25);
            textBoxcpf_cnpj.TabIndex = 32;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(146, 205);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(510, 25);
            textBoxNome.TabIndex = 31;
            // 
            // EditarFornecedor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(890, 622);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarFornecedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditarFornecedor";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxPrincipal.PerformLayout();
            groupBoxButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private GroupBox groupBoxButton;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private TextBox textBoxContato;
        private Label labelContato;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxTelefone;
        private Label labelTelefone;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxEndereco;
        private Label labelEndereco;
        private Label labelNome;
        private Label cpf_cnpj;
        private TextBox textBoxcpf_cnpj;
        private TextBox textBoxNome;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private ComboBox comboBoxFornecedor;
        private Label labelFornecedor;
        private TextBox textBoxId;
        private Label labelId;
        private TextBox textBoxData;
        private Label labelData;
        private Button btnBuscar;
    }
}