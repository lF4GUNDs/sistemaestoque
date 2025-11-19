namespace controleEstoque
{
    partial class usuarioForm
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            labelUsuario = new Label();
            labelSenha = new Label();
            pictureBoxLogin = new PictureBox();
            btnEntrar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsuario.Location = new Point(205, 39);
            textBoxUsuario.Margin = new Padding(2);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(146, 25);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSenha.Location = new Point(204, 89);
            textBoxSenha.Margin = new Padding(2);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(147, 25);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(135, 42);
            labelUsuario.Margin = new Padding(2, 0, 2, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(53, 17);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(135, 92);
            labelSenha.Margin = new Padding(2, 0, 2, 0);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(43, 17);
            labelSenha.TabIndex = 3;
            labelSenha.Text = "Senha";
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.login;
            pictureBoxLogin.Location = new Point(9, 24);
            pictureBoxLogin.Margin = new Padding(2);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(98, 99);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 5;
            pictureBoxLogin.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(204, 124);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(58, 27);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(293, 124);
            btnSair.Margin = new Padding(2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(58, 27);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // usuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 181);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBoxLogin);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usuarioForm";
            Text = "usuario";
            Load += usuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label labelUsuario;
        private Label labelSenha;
        private PictureBox pictureBoxLogin;
        private Button btnEntrar;
        private Button btnSair;
    }
}