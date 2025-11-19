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
    public partial class CadastroFuncionario : Form
    {
        ValidaCpfCnpj validaCpfCnpj = new ValidaCpfCnpj();
        FuncionarioService funservice = new FuncionarioService();
        public CadastroFuncionario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public enum TipoDocumento
        {
            CPF,
            CNPJ
        }

        private void catrandoFuncionario()
        {
            String cpf_cnpj = textBoxCodigoCPF.Text;
            String nome = textBoxNome.Text;
            String cargo = textBoxCargo.Text;
            String contato = textBoxContato.Text;
            String cidade = textBoxCidade.Text;
            Boolean valida = true;

            try
            {
                if (cpf_cnpj.Length == 11)
                {
                      valida = validaCpfCnpj.ValidarDocumento(cpf_cnpj, (ValidaCpfCnpj.TipoDocumento)TipoDocumento.CPF);
                }

                if (cpf_cnpj.Length == 14)
                {
                       valida = validaCpfCnpj.ValidarDocumento(cpf_cnpj, (ValidaCpfCnpj.TipoDocumento)TipoDocumento.CNPJ);
                }

                if (!valida)
                {
                    MessageBox.Show("CPF ou CNPJ inválidos");
                }
                else
                {
                    funservice.cadastrarFuncionario(nome, cargo, contato, cidade, cpf_cnpj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Funcionario " + ex.Message);
            }

        }

        private void groupBoxCadastrandoProduto_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length > 0)
            {
                catrandoFuncionario();
            }
            else
            {
                MessageBox.Show("Campo nome é obrigatório");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new FuncionariosForms());
            }
        }
    }
}
