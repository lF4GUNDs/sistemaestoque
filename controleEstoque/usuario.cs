using controleEstoque.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleEstoque
{
    public partial class usuarioForm : Form
    {
        ValidaCadastraUsuario usua = new ValidaCadastraUsuario();
        private Boolean validaUsuario = false;
        public usuarioForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text != "" && textBoxSenha.Text != "")
            {
                String usuarioLog = textBoxUsuario.Text;
                String senha = textBoxSenha.Text;
                validaUsuario = usua.validaUsuario(usuarioLog, senha);

                if (validaUsuario)
                {
                    formPrincipal form = new formPrincipal();
                    form.Show();
                    form.ususariologado(usuarioLog);
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto");
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios inválidos");
            }

        }
        public void fecharFormulario()
        {
                        
                DialogResult resultado = MessageBox.Show("Deseja sair do sistema?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    
                    Application.Exit();
                }
              
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            fecharFormulario();
        }
    }
}
