using controleEstoque.entity;
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
    public partial class EditarFornecedor : Form
    {
        FornecedorService forneservic = new FornecedorService();
        private IList<Fornecedor> listaFornecedor;
        public EditarFornecedor()
        {
            InitializeComponent();
            inicializa();
            popularComboboxFuncionario();
        }

        private void inicializa()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void popularComboboxFuncionario()
        {
            comboBoxFornecedor.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            listaFornecedor = forneservic.buscarListaDeFornecedor();

            for (int i = 0; i < listaFornecedor.Count; i++)
            {
                comboBoxFornecedor.Items.Insert(i, listaFornecedor[i].nome + "-" + listaFornecedor[i].id);
            }
        }

        private void preencherCamposEditar()
        {
            Fornecedor fornecedor = listaFornecedor.FirstOrDefault(p => p.id == int.Parse(comboBoxFornecedor.Text.Split("-")[1].Trim()));
            if (listaFornecedor.Count > 0)
            {
                textBoxId.Text = Convert.ToString(fornecedor.id);
                textBoxcpf_cnpj.Text = fornecedor.cpf_cnpj;
                textBoxNome.Text = fornecedor.nome;
                textBoxEndereco.Text = fornecedor.endreco;
                textBoxBairro.Text = fornecedor.bairro;
                textBoxCidade.Text = fornecedor.cidade;
                textBoxTelefone.Text = fornecedor.telefone;
                textBoxEmail.Text = fornecedor.email;
                textBoxContato.Text = fornecedor.contato;
                textBoxData.Text = fornecedor.dataCadastro;
            }
            else
            {
                MessageBox.Show("Lista de Fornecedor não carregada ");
            }
        }


        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Left > 0 && textBoxBairro.Left > 0 && textBoxEndereco.Left > 0 && textBoxCidade.Left > 0
                && textBoxTelefone.Left > 0)
            {
                String id = textBoxId.Text;
                String cpf_cnpj = textBoxcpf_cnpj.Text;
                String nome = textBoxNome.Text;
                String endereco = textBoxEndereco.Text;
                String bairoo = textBoxBairro.Text;
                String cidade = textBoxCidade.Text;
                String telefone = textBoxTelefone.Text;
                String email = textBoxEmail.Text;
                String contato = textBoxContato.Text;

                forneservic.editarFornecedor(id, nome, cpf_cnpj, endereco, telefone, email, contato, bairoo, cidade);

            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            preencherCamposEditar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new FornecedorFormPrincipal());
            }
        }
    }
}
