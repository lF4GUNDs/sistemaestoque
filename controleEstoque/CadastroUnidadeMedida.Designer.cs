namespace controleEstoque
{
    partial class CadastroUnidadeMedida
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridViewUnidade = new DataGridView();
            btnConfirma = new Button();
            btnCancela = new Button();
            textBoxUnidade = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnidade).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnConfirma);
            groupBox1.Controls.Add(btnCancela);
            groupBox1.Controls.Add(textBoxUnidade);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 409);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionando Unidades de Medida";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewUnidade);
            groupBox2.Location = new Point(6, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 300);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Unidade de medida Cadastradas";
            // 
            // dataGridViewUnidade
            // 
            dataGridViewUnidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnidade.Dock = DockStyle.Fill;
            dataGridViewUnidade.Location = new Point(3, 21);
            dataGridViewUnidade.Name = "dataGridViewUnidade";
            dataGridViewUnidade.RowTemplate.Height = 25;
            dataGridViewUnidade.Size = new Size(360, 276);
            dataGridViewUnidade.TabIndex = 0;
            // 
            // btnConfirma
            // 
            btnConfirma.BackColor = Color.LimeGreen;
            btnConfirma.Location = new Point(297, 369);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 26);
            btnConfirma.TabIndex = 3;
            btnConfirma.Text = "Confirmar";
            btnConfirma.UseVisualStyleBackColor = false;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = Color.Red;
            btnCancela.Location = new Point(12, 369);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(75, 26);
            btnCancela.TabIndex = 2;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += button1_Click;
            // 
            // textBoxUnidade
            // 
            textBoxUnidade.Location = new Point(168, 29);
            textBoxUnidade.Name = "textBoxUnidade";
            textBoxUnidade.Size = new Size(204, 25);
            textBoxUnidade.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(163, 17);
            label1.TabIndex = 0;
            label1.Text = "Nova Unidade de Meidida";
            label1.Click += label1_Click;
            // 
            // CadastroUnidadeMedida
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 409);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroUnidadeMedida";
            Text = "CadastroUnidadeMedida";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxUnidade;
        private Label label1;
        private Button btnCancela;
        private GroupBox groupBox2;
        private DataGridView dataGridViewUnidade;
        private Button btnConfirma;
    }
}