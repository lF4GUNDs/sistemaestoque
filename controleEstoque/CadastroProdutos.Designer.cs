namespace controleEstoque
{
    partial class CadastroProdutos
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
            groupBoxCadastrandoProduto = new GroupBox();
            groupButton = new GroupBox();
            buttonConfirmar = new Button();
            buttonCancelar = new Button();
            btnAdionarMedida = new Button();
            adicinarCategoria = new Button();
            labelObservacao = new Label();
            textBoxObservacao = new TextBox();
            textBoxEstoqueMinimo = new TextBox();
            label5 = new Label();
            comboBoxUnicadeMediaProduto = new ComboBox();
            label4 = new Label();
            comboBoxCategoriaProduto = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxCodigoProduto = new TextBox();
            textBoxNome = new TextBox();
            groupBoxPrincipal = new GroupBox();
            groupBoxCadastrandoProduto.SuspendLayout();
            groupButton.SuspendLayout();
            groupBoxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCadastrandoProduto
            // 
            groupBoxCadastrandoProduto.Controls.Add(groupButton);
            groupBoxCadastrandoProduto.Controls.Add(labelObservacao);
            groupBoxCadastrandoProduto.Controls.Add(textBoxObservacao);
            groupBoxCadastrandoProduto.Controls.Add(textBoxEstoqueMinimo);
            groupBoxCadastrandoProduto.Controls.Add(label5);
            groupBoxCadastrandoProduto.Controls.Add(comboBoxUnicadeMediaProduto);
            groupBoxCadastrandoProduto.Controls.Add(label4);
            groupBoxCadastrandoProduto.Controls.Add(comboBoxCategoriaProduto);
            groupBoxCadastrandoProduto.Controls.Add(label3);
            groupBoxCadastrandoProduto.Controls.Add(label2);
            groupBoxCadastrandoProduto.Controls.Add(label1);
            groupBoxCadastrandoProduto.Controls.Add(textBoxCodigoProduto);
            groupBoxCadastrandoProduto.Controls.Add(textBoxNome);
            groupBoxCadastrandoProduto.Dock = DockStyle.Fill;
            groupBoxCadastrandoProduto.FlatStyle = FlatStyle.System;
            groupBoxCadastrandoProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCadastrandoProduto.Location = new Point(3, 25);
            groupBoxCadastrandoProduto.Name = "groupBoxCadastrandoProduto";
            groupBoxCadastrandoProduto.Size = new Size(927, 627);
            groupBoxCadastrandoProduto.TabIndex = 0;
            groupBoxCadastrandoProduto.TabStop = false;
            groupBoxCadastrandoProduto.Text = "Cadastrando  Produto";
            groupBoxCadastrandoProduto.Enter += groupBoxCadastrandoProduto_Enter;
            // 
            // groupButton
            // 
            groupButton.Controls.Add(buttonConfirmar);
            groupButton.Controls.Add(buttonCancelar);
            groupButton.Controls.Add(btnAdionarMedida);
            groupButton.Controls.Add(adicinarCategoria);
            groupButton.Dock = DockStyle.Bottom;
            groupButton.Location = new Point(3, 539);
            groupButton.Name = "groupButton";
            groupButton.Size = new Size(921, 85);
            groupButton.TabIndex = 1;
            groupButton.TabStop = false;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmar.BackColor = Color.Lime;
            buttonConfirmar.Location = new Point(758, 26);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(157, 49);
            buttonConfirmar.TabIndex = 0;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.IndianRed;
            buttonCancelar.Location = new Point(595, 26);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(157, 49);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // btnAdionarMedida
            // 
            btnAdionarMedida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdionarMedida.Location = new Point(179, 26);
            btnAdionarMedida.Name = "btnAdionarMedida";
            btnAdionarMedida.Size = new Size(157, 49);
            btnAdionarMedida.TabIndex = 3;
            btnAdionarMedida.Text = "Adicionar Medida";
            btnAdionarMedida.UseVisualStyleBackColor = true;
            btnAdionarMedida.Click += btnAdionarMedida_Click;
            // 
            // adicinarCategoria
            // 
            adicinarCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            adicinarCategoria.Location = new Point(6, 26);
            adicinarCategoria.Name = "adicinarCategoria";
            adicinarCategoria.Size = new Size(157, 49);
            adicinarCategoria.TabIndex = 2;
            adicinarCategoria.Text = "Adicionar Categoria";
            adicinarCategoria.UseVisualStyleBackColor = true;
            adicinarCategoria.Click += button1_Click;
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Location = new Point(6, 266);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(87, 20);
            labelObservacao.TabIndex = 11;
            labelObservacao.Text = "Observação";
            // 
            // textBoxObservacao
            // 
            textBoxObservacao.Location = new Point(169, 263);
            textBoxObservacao.Name = "textBoxObservacao";
            textBoxObservacao.Size = new Size(713, 27);
            textBoxObservacao.TabIndex = 10;
            // 
            // textBoxEstoqueMinimo
            // 
            textBoxEstoqueMinimo.Location = new Point(169, 184);
            textBoxEstoqueMinimo.Name = "textBoxEstoqueMinimo";
            textBoxEstoqueMinimo.Size = new Size(121, 27);
            textBoxEstoqueMinimo.TabIndex = 9;
            textBoxEstoqueMinimo.TextChanged += textBoxEstoqueMinimo_TextChanged;
            textBoxEstoqueMinimo.KeyPress += textBoxEstoqueMinimo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 187);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 8;
            label5.Text = "Estoque Minimo ";
            // 
            // comboBoxUnicadeMediaProduto
            // 
            comboBoxUnicadeMediaProduto.FormattingEnabled = true;
            comboBoxUnicadeMediaProduto.Location = new Point(672, 112);
            comboBoxUnicadeMediaProduto.Name = "comboBoxUnicadeMediaProduto";
            comboBoxUnicadeMediaProduto.Size = new Size(210, 28);
            comboBoxUnicadeMediaProduto.TabIndex = 7;
            comboBoxUnicadeMediaProduto.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 115);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 6;
            label4.Text = "Unidade de Medida ";
            // 
            // comboBoxCategoriaProduto
            // 
            comboBoxCategoriaProduto.FormattingEnabled = true;
            comboBoxCategoriaProduto.Location = new Point(169, 112);
            comboBoxCategoriaProduto.Name = "comboBoxCategoriaProduto";
            comboBoxCategoriaProduto.Size = new Size(121, 28);
            comboBoxCategoriaProduto.TabIndex = 5;
            comboBoxCategoriaProduto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 41);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 2;
            label1.Text = "Código Produto";
            // 
            // textBoxCodigoProduto
            // 
            textBoxCodigoProduto.Location = new Point(169, 43);
            textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            textBoxCodigoProduto.Size = new Size(121, 27);
            textBoxCodigoProduto.TabIndex = 1;
            textBoxCodigoProduto.KeyPress += textBoxCodigoProduto_KeyPress;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(581, 38);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(301, 27);
            textBoxNome.TabIndex = 0;
            // 
            // groupBoxPrincipal
            // 
            groupBoxPrincipal.Anchor = AnchorStyles.None;
            groupBoxPrincipal.Controls.Add(groupBoxCadastrandoProduto);
            groupBoxPrincipal.Location = new Point(0, 0);
            groupBoxPrincipal.Name = "groupBoxPrincipal";
            groupBoxPrincipal.Size = new Size(933, 655);
            groupBoxPrincipal.TabIndex = 2;
            groupBoxPrincipal.TabStop = false;
            // 
            // CadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(933, 655);
            Controls.Add(groupBoxPrincipal);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroProdutos";
            Text = "CadastroProdutos";
            groupBoxCadastrandoProduto.ResumeLayout(false);
            groupBoxCadastrandoProduto.PerformLayout();
            groupButton.ResumeLayout(false);
            groupBoxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCadastrandoProduto;
        private Label label4;
        private ComboBox comboBoxCategoriaProduto;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCodigoProduto;
        private TextBox textBoxNome;
        private ComboBox comboBoxUnicadeMediaProduto;
        private Label label5;
        private TextBox textBoxEstoqueMinimo;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private Button adicinarCategoria;
        private Button btnAdionarMedida;
        private Label labelObservacao;
        private TextBox textBoxObservacao;
        private GroupBox groupButton;
        private GroupBox groupBoxPrincipal;
    }
}