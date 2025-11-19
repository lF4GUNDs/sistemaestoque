namespace controleEstoque
{
    partial class AdicionarCategoria
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
            dataGridViewCategoriaCadastradas = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBoxCategoria = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoriaCadastradas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxCategoria);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 409);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionando Categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewCategoriaCadastradas);
            groupBox2.Location = new Point(12, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 295);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categoria Cadastradas";
            // 
            // dataGridViewCategoriaCadastradas
            // 
            dataGridViewCategoriaCadastradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoriaCadastradas.Location = new Point(6, 25);
            dataGridViewCategoriaCadastradas.Name = "dataGridViewCategoriaCadastradas";
            dataGridViewCategoriaCadastradas.RowTemplate.Height = 25;
            dataGridViewCategoriaCadastradas.Size = new Size(340, 263);
            dataGridViewCategoriaCadastradas.TabIndex = 0;
            dataGridViewCategoriaCadastradas.CellContentClick += dataGridViewCategoriaCadastradas_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(283, 369);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 3;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(6, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 2;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 1;
            label1.Text = "Nova Categoria";
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(131, 22);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(233, 25);
            textBoxCategoria.TabIndex = 0;
            textBoxCategoria.TextChanged += textBoxCategoria_TextChanged;
            // 
            // AdicionarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 409);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdicionarCategoria";
            Text = "AdicionarCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoriaCadastradas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBoxCategoria;
        private GroupBox groupBox2;
        private DataGridView dataGridViewCategoriaCadastradas;
    }
}