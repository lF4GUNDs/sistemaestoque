namespace controleEstoque
{
    partial class EditarFuncionario
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
            comboBoxFuncionario = new ComboBox();
            labelFuncionario = new Label();
            textBoxId = new TextBox();
            labelId = new Label();
            groupBoxButoon = new GroupBox();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            textBoxContato = new TextBox();
            labelContato = new Label();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            textBoxCargo = new TextBox();
            labelCargo = new Label();
            labelNome = new Label();
            labelCpf_Cnpj = new Label();
            textBoxcpf_cnpj = new TextBox();
            textBoxNome = new TextBox();
            groupBoxPrincipal.SuspendLayout();
            groupBoxButoon.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Anchor = AnchorStyles.None;
            groupBoxPrincipal.Controls.Add(btnBuscar);
            groupBoxPrincipal.Controls.Add(textBoxData);
            groupBoxPrincipal.Controls.Add(labelData);
            groupBoxPrincipal.Controls.Add(comboBoxFuncionario);
            groupBoxPrincipal.Controls.Add(labelFuncionario);
            groupBoxPrincipal.Controls.Add(textBoxId);
            groupBoxPrincipal.Controls.Add(labelId);
            groupBoxPrincipal.Controls.Add(groupBoxButoon);
            groupBoxPrincipal.Controls.Add(textBoxContato);
            groupBoxPrincipal.Controls.Add(labelContato);
            groupBoxPrincipal.Controls.Add(labelCidade);
            groupBoxPrincipal.Controls.Add(textBoxCidade);
            groupBoxPrincipal.Controls.Add(textBoxCargo);
            groupBoxPrincipal.Controls.Add(labelCargo);
            groupBoxPrincipal.Controls.Add(labelNome);
            groupBoxPrincipal.Controls.Add(labelCpf_Cnpj);
            groupBoxPrincipal.Controls.Add(textBoxcpf_cnpj);
            groupBoxPrincipal.Controls.Add(textBoxNome);
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(881, 495);
            groupBoxPrincipal.TabIndex = 0;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Editar Funcionário";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(620, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 29);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBoxData
            // 
            textBoxData.Enabled = false;
            textBoxData.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxData.Location = new Point(633, 92);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(138, 25);
            textBoxData.TabIndex = 30;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(498, 95);
            labelData.Name = "labelData";
            labelData.Size = new Size(111, 17);
            labelData.TabIndex = 29;
            labelData.Text = "Data de Cadastro";
            // 
            // comboBoxFuncionario
            // 
            comboBoxFuncionario.FormattingEnabled = true;
            comboBoxFuncionario.Location = new Point(106, 51);
            comboBoxFuncionario.Name = "comboBoxFuncionario";
            comboBoxFuncionario.Size = new Size(459, 25);
            comboBoxFuncionario.TabIndex = 28;
            // 
            // labelFuncionario
            // 
            labelFuncionario.AutoSize = true;
            labelFuncionario.Location = new Point(12, 55);
            labelFuncionario.Name = "labelFuncionario";
            labelFuncionario.Size = new Size(75, 17);
            labelFuncionario.TabIndex = 27;
            labelFuncionario.Text = "Funcionário";
            labelFuncionario.Click += labelFuncionario_Click;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(106, 92);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(87, 25);
            textBoxId.TabIndex = 26;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(57, 95);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 17);
            labelId.TabIndex = 25;
            labelId.Text = "ID";
            // 
            // groupBoxButoon
            // 
            groupBoxButoon.Controls.Add(buttonCancelar);
            groupBoxButoon.Controls.Add(buttonConfirmar);
            groupBoxButoon.Dock = DockStyle.Bottom;
            groupBoxButoon.Location = new Point(3, 428);
            groupBoxButoon.Name = "groupBoxButoon";
            groupBoxButoon.Size = new Size(875, 64);
            groupBoxButoon.TabIndex = 24;
            groupBoxButoon.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.IndianRed;
            buttonCancelar.Location = new Point(532, 15);
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
            buttonConfirmar.Location = new Point(709, 15);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(157, 49);
            buttonConfirmar.TabIndex = 2;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // textBoxContato
            // 
            textBoxContato.Location = new Point(106, 398);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(321, 25);
            textBoxContato.TabIndex = 23;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(26, 401);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(54, 17);
            labelContato.TabIndex = 22;
            labelContato.Text = "Contato";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(26, 318);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(49, 17);
            labelCidade.TabIndex = 21;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(106, 315);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(665, 25);
            textBoxCidade.TabIndex = 20;
            // 
            // textBoxCargo
            // 
            textBoxCargo.Location = new Point(106, 239);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(665, 25);
            textBoxCargo.TabIndex = 19;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Location = new Point(26, 242);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(48, 17);
            labelCargo.TabIndex = 18;
            labelCargo.Text = "Cargo ";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(32, 167);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(48, 17);
            labelNome.TabIndex = 17;
            labelNome.Text = "Nome ";
            // 
            // labelCpf_Cnpj
            // 
            labelCpf_Cnpj.AutoSize = true;
            labelCpf_Cnpj.Location = new Point(218, 95);
            labelCpf_Cnpj.Name = "labelCpf_Cnpj";
            labelCpf_Cnpj.Size = new Size(62, 17);
            labelCpf_Cnpj.TabIndex = 16;
            labelCpf_Cnpj.Text = "Cpf/CNPJ";
            labelCpf_Cnpj.Click += labelCpf_Cnpj_Click;
            // 
            // textBoxcpf_cnpj
            // 
            textBoxcpf_cnpj.Enabled = false;
            textBoxcpf_cnpj.Location = new Point(300, 92);
            textBoxcpf_cnpj.Name = "textBoxcpf_cnpj";
            textBoxcpf_cnpj.Size = new Size(192, 25);
            textBoxcpf_cnpj.TabIndex = 15;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(106, 167);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(665, 25);
            textBoxNome.TabIndex = 14;
            // 
            // EditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(881, 495);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarFuncionario";
            Text = "EditarFuncionario";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxPrincipal.PerformLayout();
            groupBoxButoon.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private TextBox textBoxContato;
        private Label labelContato;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxCargo;
        private Label labelCargo;
        private Label labelNome;
        private Label labelCpf_Cnpj;
        private TextBox textBoxcpf_cnpj;
        private TextBox textBoxNome;
        private GroupBox groupBoxButoon;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private TextBox textBoxData;
        private Label labelData;
        private ComboBox comboBoxFuncionario;
        private Label labelFuncionario;
        private TextBox textBoxId;
        private Label labelId;
        private Button btnBuscar;
    }
}