namespace controleEstoque
{
    partial class CadastroFuncionario
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
            groupBoxcastroProdutoAreaButton = new GroupBox();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            groupBox1 = new GroupBox();
            l = new Label();
            textBoxContato = new TextBox();
            textBoxCodigoCPF = new TextBox();
            labelContato = new Label();
            labelNome = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxNome = new TextBox();
            labelCargo = new Label();
            textBoxCargo = new TextBox();
            groupBoxPrincipal.SuspendLayout();
            groupBoxcastroProdutoAreaButton.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Anchor = AnchorStyles.None;
            groupBoxPrincipal.Controls.Add(groupBoxcastroProdutoAreaButton);
            groupBoxPrincipal.Controls.Add(groupBox1);
            groupBoxPrincipal.FlatStyle = FlatStyle.System;
            groupBoxPrincipal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(797, 405);
            groupBoxPrincipal.TabIndex = 1;
            groupBoxPrincipal.TabStop = false;
            groupBoxPrincipal.Text = "Cadastro  Funcionário";
            // 
            // groupBoxcastroProdutoAreaButton
            // 
            groupBoxcastroProdutoAreaButton.Controls.Add(buttonCancelar);
            groupBoxcastroProdutoAreaButton.Controls.Add(buttonConfirmar);
            groupBoxcastroProdutoAreaButton.Dock = DockStyle.Bottom;
            groupBoxcastroProdutoAreaButton.FlatStyle = FlatStyle.System;
            groupBoxcastroProdutoAreaButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxcastroProdutoAreaButton.Location = new Point(3, 341);
            groupBoxcastroProdutoAreaButton.Name = "groupBoxcastroProdutoAreaButton";
            groupBoxcastroProdutoAreaButton.Size = new Size(791, 61);
            groupBoxcastroProdutoAreaButton.TabIndex = 2;
            groupBoxcastroProdutoAreaButton.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.IndianRed;
            buttonCancelar.Location = new Point(436, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(157, 49);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmar.BackColor = Color.Lime;
            buttonConfirmar.Location = new Point(623, 5);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(157, 49);
            buttonConfirmar.TabIndex = 0;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(l);
            groupBox1.Controls.Add(textBoxContato);
            groupBox1.Controls.Add(textBoxCodigoCPF);
            groupBox1.Controls.Add(labelContato);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(textBoxCidade);
            groupBox1.Controls.Add(labelCidade);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(labelCargo);
            groupBox1.Controls.Add(textBoxCargo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 379);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(3, 19);
            l.Name = "l";
            l.Size = new Size(70, 20);
            l.TabIndex = 2;
            l.Text = "Cpf/CNPJ";
            l.Click += label1_Click;
            // 
            // textBoxContato
            // 
            textBoxContato.Location = new Point(75, 234);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(504, 27);
            textBoxContato.TabIndex = 13;
            // 
            // textBoxCodigoCPF
            // 
            textBoxCodigoCPF.Location = new Point(75, 16);
            textBoxCodigoCPF.Name = "textBoxCodigoCPF";
            textBoxCodigoCPF.Size = new Size(287, 27);
            textBoxCodigoCPF.TabIndex = 1;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(7, 241);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(62, 20);
            labelContato.TabIndex = 12;
            labelContato.Text = "Contato";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(7, 70);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(54, 20);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome ";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(75, 181);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(665, 27);
            textBoxCidade.TabIndex = 10;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(7, 184);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 11;
            labelCidade.Text = "Cidade";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(75, 67);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(665, 27);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Location = new Point(7, 126);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(53, 20);
            labelCargo.TabIndex = 8;
            labelCargo.Text = "Cargo ";
            // 
            // textBoxCargo
            // 
            textBoxCargo.Location = new Point(75, 119);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(665, 27);
            textBoxCargo.TabIndex = 9;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(797, 405);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroFuncionario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CadastroFuncionario";
            groupBoxPrincipal.ResumeLayout(false);
            groupBoxcastroProdutoAreaButton.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrincipal;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxCargo;
        private Label labelCargo;
        private Label labelNome;
        private Label l;
        private TextBox textBoxCodigoCPF;
        private TextBox textBoxNome;
        private GroupBox groupBoxcastroProdutoAreaButton;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private TextBox textBoxContato;
        private Label labelContato;
        private GroupBox groupBox1;
    }
}