namespace controleEstoque
{
    partial class EditarProdutoForm
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
            groupBoxEditandoProduto = new GroupBox();
            textBoxId = new TextBox();
            labelId = new Label();
            btnBuscar = new Button();
            comboBoxProduto = new ComboBox();
            labelBuscaProduto = new Label();
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
            groupBoxcastroProdutoAreaButton = new GroupBox();
            btnAdionarMedida = new Button();
            adicinarCategoria = new Button();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            groupBoxEditandoProduto.SuspendLayout();
            groupBoxcastroProdutoAreaButton.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxEditandoProduto
            // 
            groupBoxEditandoProduto.Anchor = AnchorStyles.None;
            groupBoxEditandoProduto.Controls.Add(textBoxId);
            groupBoxEditandoProduto.Controls.Add(labelId);
            groupBoxEditandoProduto.Controls.Add(btnBuscar);
            groupBoxEditandoProduto.Controls.Add(comboBoxProduto);
            groupBoxEditandoProduto.Controls.Add(labelBuscaProduto);
            groupBoxEditandoProduto.Controls.Add(labelObservacao);
            groupBoxEditandoProduto.Controls.Add(textBoxObservacao);
            groupBoxEditandoProduto.Controls.Add(textBoxEstoqueMinimo);
            groupBoxEditandoProduto.Controls.Add(label5);
            groupBoxEditandoProduto.Controls.Add(comboBoxUnicadeMediaProduto);
            groupBoxEditandoProduto.Controls.Add(label4);
            groupBoxEditandoProduto.Controls.Add(comboBoxCategoriaProduto);
            groupBoxEditandoProduto.Controls.Add(label3);
            groupBoxEditandoProduto.Controls.Add(label2);
            groupBoxEditandoProduto.Controls.Add(label1);
            groupBoxEditandoProduto.Controls.Add(textBoxCodigoProduto);
            groupBoxEditandoProduto.Controls.Add(textBoxNome);
            groupBoxEditandoProduto.FlatStyle = FlatStyle.System;
            groupBoxEditandoProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxEditandoProduto.Location = new Point(0, 0);
            groupBoxEditandoProduto.Name = "groupBoxEditandoProduto";
            groupBoxEditandoProduto.Size = new Size(1040, 575);
            groupBoxEditandoProduto.TabIndex = 1;
            groupBoxEditandoProduto.TabStop = false;
            groupBoxEditandoProduto.Text = "Editar  Produto";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(391, 137);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(85, 27);
            textBoxId.TabIndex = 16;
            textBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(353, 140);
            labelId.Name = "labelId";
            labelId.Size = new Size(24, 20);
            labelId.TabIndex = 15;
            labelId.Text = "ID";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(681, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 28);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(178, 55);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(392, 28);
            comboBoxProduto.TabIndex = 13;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // labelBuscaProduto
            // 
            labelBuscaProduto.AutoSize = true;
            labelBuscaProduto.Location = new Point(15, 55);
            labelBuscaProduto.Name = "labelBuscaProduto";
            labelBuscaProduto.Size = new Size(109, 20);
            labelBuscaProduto.TabIndex = 12;
            labelBuscaProduto.Text = "Buscar Produto";
            labelBuscaProduto.Click += labelBuscaProduto_Click;
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Location = new Point(15, 360);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(87, 20);
            labelObservacao.TabIndex = 11;
            labelObservacao.Text = "Observação";
            // 
            // textBoxObservacao
            // 
            textBoxObservacao.Location = new Point(178, 357);
            textBoxObservacao.Name = "textBoxObservacao";
            textBoxObservacao.Size = new Size(713, 27);
            textBoxObservacao.TabIndex = 10;
            // 
            // textBoxEstoqueMinimo
            // 
            textBoxEstoqueMinimo.Location = new Point(178, 278);
            textBoxEstoqueMinimo.Name = "textBoxEstoqueMinimo";
            textBoxEstoqueMinimo.Size = new Size(121, 27);
            textBoxEstoqueMinimo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 281);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 8;
            label5.Text = "Estoque Minimo ";
            // 
            // comboBoxUnicadeMediaProduto
            // 
            comboBoxUnicadeMediaProduto.FormattingEnabled = true;
            comboBoxUnicadeMediaProduto.Location = new Point(681, 206);
            comboBoxUnicadeMediaProduto.Name = "comboBoxUnicadeMediaProduto";
            comboBoxUnicadeMediaProduto.Size = new Size(210, 28);
            comboBoxUnicadeMediaProduto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 209);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 6;
            label4.Text = "Unidade de Medida ";
            // 
            // comboBoxCategoriaProduto
            // 
            comboBoxCategoriaProduto.FormattingEnabled = true;
            comboBoxCategoriaProduto.Location = new Point(178, 206);
            comboBoxCategoriaProduto.Name = "comboBoxCategoriaProduto";
            comboBoxCategoriaProduto.Size = new Size(121, 28);
            comboBoxCategoriaProduto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 209);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 140);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 140);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 2;
            label1.Text = "Código Produto";
            // 
            // textBoxCodigoProduto
            // 
            textBoxCodigoProduto.Location = new Point(178, 137);
            textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            textBoxCodigoProduto.Size = new Size(121, 27);
            textBoxCodigoProduto.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(576, 137);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(315, 27);
            textBoxNome.TabIndex = 0;
            // 
            // groupBoxcastroProdutoAreaButton
            // 
            groupBoxcastroProdutoAreaButton.Anchor = AnchorStyles.None;
            groupBoxcastroProdutoAreaButton.Controls.Add(btnAdionarMedida);
            groupBoxcastroProdutoAreaButton.Controls.Add(adicinarCategoria);
            groupBoxcastroProdutoAreaButton.Controls.Add(buttonCancelar);
            groupBoxcastroProdutoAreaButton.Controls.Add(buttonConfirmar);
            groupBoxcastroProdutoAreaButton.FlatStyle = FlatStyle.System;
            groupBoxcastroProdutoAreaButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxcastroProdutoAreaButton.Location = new Point(0, 502);
            groupBoxcastroProdutoAreaButton.Name = "groupBoxcastroProdutoAreaButton";
            groupBoxcastroProdutoAreaButton.Size = new Size(1040, 73);
            groupBoxcastroProdutoAreaButton.TabIndex = 2;
            groupBoxcastroProdutoAreaButton.TabStop = false;
            // 
            // btnAdionarMedida
            // 
            btnAdionarMedida.Location = new Point(214, 25);
            btnAdionarMedida.Name = "btnAdionarMedida";
            btnAdionarMedida.Size = new Size(176, 39);
            btnAdionarMedida.TabIndex = 3;
            btnAdionarMedida.Text = "Adicionar Medida";
            btnAdionarMedida.UseVisualStyleBackColor = true;
            btnAdionarMedida.Click += btnAdionarMedida_Click;
            // 
            // adicinarCategoria
            // 
            adicinarCategoria.Location = new Point(6, 25);
            adicinarCategoria.Name = "adicinarCategoria";
            adicinarCategoria.Size = new Size(176, 39);
            adicinarCategoria.TabIndex = 2;
            adicinarCategoria.Text = "Adicionar Categoria";
            adicinarCategoria.UseVisualStyleBackColor = true;
            adicinarCategoria.Click += adicinarCategoria_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.IndianRed;
            buttonCancelar.Location = new Point(619, 15);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(157, 49);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.Lime;
            buttonConfirmar.Location = new Point(806, 15);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(157, 49);
            buttonConfirmar.TabIndex = 0;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // EditarProdutoForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1040, 575);
            Controls.Add(groupBoxcastroProdutoAreaButton);
            Controls.Add(groupBoxEditandoProduto);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarProdutoForm";
            Text = "EditarProdutoForm";
            groupBoxEditandoProduto.ResumeLayout(false);
            groupBoxEditandoProduto.PerformLayout();
            groupBoxcastroProdutoAreaButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEditandoProduto;
        private Label labelObservacao;
        private TextBox textBoxObservacao;
        private TextBox textBoxEstoqueMinimo;
        private Label label5;
        private ComboBox comboBoxUnicadeMediaProduto;
        private Label label4;
        private ComboBox comboBoxCategoriaProduto;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCodigoProduto;
        private TextBox textBoxNome;
        private ComboBox comboBoxProduto;
        private Label labelBuscaProduto;
        private GroupBox groupBoxcastroProdutoAreaButton;
        private Button btnAdionarMedida;
        private Button adicinarCategoria;
        private Button buttonCancelar;
        private Button buttonConfirmar;
        private Button btnBuscar;
        private TextBox textBoxId;
        private Label labelId;
    }
}