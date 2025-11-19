namespace controleEstoque
{
    partial class formPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSideMenu = new Panel();
            btnRelatorioSaida = new Button();
            btnRelatorioEntrada = new Button();
            btnProduto = new Button();
            btnFornecedor = new Button();
            btnEstoque = new Button();
            btnFuncionario = new Button();
            btnSaida = new Button();
            bntEntrada = new Button();
            btnHome = new Button();
            labelUsuario = new Label();
            panelLogo = new Panel();
            labelEstoque = new Label();
            pictureLogo = new PictureBox();
            panelTopo = new Panel();
            pictureBox1 = new PictureBox();
            labelHora = new Label();
            btnMinimizar = new Button();
            btnSair = new Button();
            panelCentral = new Panel();
            panelForm = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSideMenu.BackColor = SystemColors.ScrollBar;
            panelSideMenu.Controls.Add(btnRelatorioSaida);
            panelSideMenu.Controls.Add(btnRelatorioEntrada);
            panelSideMenu.Controls.Add(btnProduto);
            panelSideMenu.Controls.Add(btnFornecedor);
            panelSideMenu.Controls.Add(btnEstoque);
            panelSideMenu.Controls.Add(btnFuncionario);
            panelSideMenu.Controls.Add(btnSaida);
            panelSideMenu.Controls.Add(bntEntrada);
            panelSideMenu.Controls.Add(btnHome);
            panelSideMenu.Location = new Point(0, 85);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(162, 566);
            panelSideMenu.TabIndex = 0;
            // 
            // btnRelatorioSaida
            // 
            btnRelatorioSaida.FlatAppearance.BorderColor = Color.White;
            btnRelatorioSaida.FlatAppearance.BorderSize = 0;
            btnRelatorioSaida.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnRelatorioSaida.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnRelatorioSaida.FlatStyle = FlatStyle.Flat;
            btnRelatorioSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorioSaida.ForeColor = Color.Black;
            btnRelatorioSaida.Image = Properties.Resources.relatorio2;
            btnRelatorioSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorioSaida.Location = new Point(0, 458);
            btnRelatorioSaida.Name = "btnRelatorioSaida";
            btnRelatorioSaida.Padding = new Padding(20, 0, 0, 0);
            btnRelatorioSaida.Size = new Size(162, 55);
            btnRelatorioSaida.TabIndex = 7;
            btnRelatorioSaida.Text = "Relatório Saída";
            btnRelatorioSaida.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorioSaida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorioSaida.UseVisualStyleBackColor = true;
            btnRelatorioSaida.Click += btnRelatorios_Click;
            // 
            // btnRelatorioEntrada
            // 
            btnRelatorioEntrada.FlatAppearance.BorderColor = Color.White;
            btnRelatorioEntrada.FlatAppearance.BorderSize = 0;
            btnRelatorioEntrada.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnRelatorioEntrada.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnRelatorioEntrada.FlatStyle = FlatStyle.Flat;
            btnRelatorioEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorioEntrada.ForeColor = Color.Black;
            btnRelatorioEntrada.Image = Properties.Resources.relatorio2;
            btnRelatorioEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorioEntrada.Location = new Point(0, 397);
            btnRelatorioEntrada.Name = "btnRelatorioEntrada";
            btnRelatorioEntrada.Padding = new Padding(20, 0, 0, 0);
            btnRelatorioEntrada.Size = new Size(162, 55);
            btnRelatorioEntrada.TabIndex = 11;
            btnRelatorioEntrada.Text = "Relatório Entrada";
            btnRelatorioEntrada.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorioEntrada.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorioEntrada.UseVisualStyleBackColor = true;
            btnRelatorioEntrada.Click += btnRelatorioEntrada_Click;
            // 
            // btnProduto
            // 
            btnProduto.Dock = DockStyle.Top;
            btnProduto.FlatAppearance.BorderColor = Color.White;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnProduto.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduto.ForeColor = Color.Black;
            btnProduto.Image = Properties.Resources.produto32px;
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.Location = new Point(0, 275);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(25, 0, 0, 0);
            btnProduto.Size = new Size(162, 55);
            btnProduto.TabIndex = 3;
            btnProduto.Text = "Produto";
            btnProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click_1;
            // 
            // btnFornecedor
            // 
            btnFornecedor.Dock = DockStyle.Top;
            btnFornecedor.FlatAppearance.BorderColor = Color.White;
            btnFornecedor.FlatAppearance.BorderSize = 0;
            btnFornecedor.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnFornecedor.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnFornecedor.FlatStyle = FlatStyle.Flat;
            btnFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFornecedor.ForeColor = Color.Black;
            btnFornecedor.Image = Properties.Resources.funcionario32px;
            btnFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedor.Location = new Point(0, 220);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(23, 0, 0, 0);
            btnFornecedor.Size = new Size(162, 55);
            btnFornecedor.TabIndex = 10;
            btnFornecedor.Text = "Fornecededor";
            btnFornecedor.TextAlign = ContentAlignment.MiddleRight;
            btnFornecedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFornecedor.UseVisualStyleBackColor = true;
            btnFornecedor.Click += btnCliente_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.FlatAppearance.BorderColor = Color.White;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstoque.ForeColor = Color.Black;
            btnEstoque.Image = Properties.Resources.relatorio2;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(0, 336);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Padding = new Padding(20, 0, 0, 0);
            btnEstoque.Size = new Size(162, 55);
            btnEstoque.TabIndex = 12;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Dock = DockStyle.Top;
            btnFuncionario.FlatAppearance.BorderColor = Color.White;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnFuncionario.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionario.ForeColor = Color.Black;
            btnFuncionario.Image = Properties.Resources.funcionario32px;
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.Location = new Point(0, 165);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Padding = new Padding(25, 0, 0, 0);
            btnFuncionario.Size = new Size(162, 55);
            btnFuncionario.TabIndex = 4;
            btnFuncionario.Text = "Funcionários";
            btnFuncionario.TextAlign = ContentAlignment.MiddleRight;
            btnFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnSaida
            // 
            btnSaida.Dock = DockStyle.Top;
            btnSaida.FlatAppearance.BorderColor = Color.White;
            btnSaida.FlatAppearance.BorderSize = 0;
            btnSaida.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnSaida.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnSaida.FlatStyle = FlatStyle.Flat;
            btnSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaida.ForeColor = Color.Black;
            btnSaida.Image = Properties.Resources.seta_esquerda;
            btnSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaida.Location = new Point(0, 110);
            btnSaida.Name = "btnSaida";
            btnSaida.Padding = new Padding(20, 0, 0, 0);
            btnSaida.Size = new Size(162, 55);
            btnSaida.TabIndex = 13;
            btnSaida.Text = "Saída";
            btnSaida.TextAlign = ContentAlignment.MiddleLeft;
            btnSaida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // bntEntrada
            // 
            bntEntrada.Dock = DockStyle.Top;
            bntEntrada.FlatAppearance.BorderColor = Color.White;
            bntEntrada.FlatAppearance.BorderSize = 0;
            bntEntrada.FlatAppearance.MouseDownBackColor = Color.Blue;
            bntEntrada.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            bntEntrada.FlatStyle = FlatStyle.Flat;
            bntEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntEntrada.ForeColor = Color.Black;
            bntEntrada.Image = Properties.Resources.seta_direita;
            bntEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            bntEntrada.Location = new Point(0, 55);
            bntEntrada.Name = "bntEntrada";
            bntEntrada.Padding = new Padding(20, 0, 0, 0);
            bntEntrada.Size = new Size(162, 55);
            bntEntrada.TabIndex = 5;
            bntEntrada.Text = "Entrada";
            bntEntrada.TextAlign = ContentAlignment.MiddleLeft;
            bntEntrada.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntEntrada.UseVisualStyleBackColor = true;
            bntEntrada.Click += bntEntrada_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnHome.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Black;
            btnHome.Image = Properties.Resources.home32px1;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(25, 0, 0, 0);
            btnHome.Size = new Size(162, 55);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click_1;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(430, 12);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 14;
            labelUsuario.Text = "Usuário";
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(labelEstoque);
            panelLogo.Controls.Add(pictureLogo);
            panelLogo.Location = new Point(0, 12);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 56);
            panelLogo.TabIndex = 0;
            // 
            // labelEstoque
            // 
            labelEstoque.AutoSize = true;
            labelEstoque.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstoque.ForeColor = Color.Black;
            labelEstoque.Location = new Point(75, 13);
            labelEstoque.Name = "labelEstoque";
            labelEstoque.Size = new Size(119, 37);
            labelEstoque.TabIndex = 1;
            labelEstoque.Text = "Estoque";
            labelEstoque.TextAlign = ContentAlignment.MiddleLeft;
            labelEstoque.Click += labelEstoque_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Dock = DockStyle.Left;
            pictureLogo.Image = Properties.Resources.estoque4;
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(71, 56);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // panelTopo
            // 
            panelTopo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTopo.BackColor = SystemColors.ScrollBar;
            panelTopo.Controls.Add(pictureBox1);
            panelTopo.Controls.Add(labelUsuario);
            panelTopo.Controls.Add(labelHora);
            panelTopo.Controls.Add(btnMinimizar);
            panelTopo.Controls.Add(btnSair);
            panelTopo.Location = new Point(200, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.Size = new Size(772, 68);
            panelTopo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(398, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // labelHora
            // 
            labelHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHora.AutoSize = true;
            labelHora.Location = new Point(535, 12);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(38, 15);
            labelHora.TabIndex = 10;
            labelHora.Text = "Horas";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimizar.ForeColor = Color.OliveDrab;
            btnMinimizar.Image = Properties.Resources.minimizar;
            btnMinimizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinimizar.Location = new Point(646, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(10, 0, 0, 0);
            btnMinimizar.Size = new Size(62, 31);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.Text = "Min";
            btnMinimizar.TextAlign = ContentAlignment.MiddleLeft;
            btnMinimizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSair.FlatAppearance.BorderColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnSair.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.OliveDrab;
            btnSair.Image = Properties.Resources.sair2;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(700, 3);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 0, 0);
            btnSair.Size = new Size(62, 31);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCentral.BorderStyle = BorderStyle.FixedSingle;
            panelCentral.Controls.Add(panelForm);
            panelCentral.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            panelCentral.ForeColor = Color.White;
            panelCentral.Location = new Point(161, 65);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(811, 586);
            panelCentral.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.BackColor = SystemColors.ButtonFace;
            panelForm.Dock = DockStyle.Fill;
            panelForm.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelForm.ForeColor = Color.Black;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(809, 584);
            panelForm.TabIndex = 0;
            panelForm.Paint += panelForm_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(984, 663);
            Controls.Add(panelCentral);
            Controls.Add(panelTopo);
            Controls.Add(panelLogo);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPrincipal";
            Text = "Sistema Estoque";
            Load += Form1_Load;
            ResizeEnd += formPrincipal_ResizeEnd;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelTopo.ResumeLayout(false);
            panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox pictureLogo;
        private Panel panelTopo;
        private Panel panelCentral;
        private Button btnHome;
        private Label labelEstoque;
        private Button btnRelatorioSaida;
        private Button bntEntrada;
        private Button btnFuncionario;
        private Button btnProduto;
        private Button btnSair;
        private Panel panelForm;
        private Button btnMinimizar;
        private Button btnFornecedor;
        private Button btnEstoque;
        private Button btnRelatorioEntrada;
        private Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnSaida;
        private Label labelUsuario;
        private PictureBox pictureBox1;
    }
}