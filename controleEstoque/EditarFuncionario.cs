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
    public partial class EditarFuncionario : Form
    {
        FuncionarioService funserv = new FuncionarioService();
        private IList<Funcionario> listaFuncionarios;
        public EditarFuncionario()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            this.WindowState = FormWindowState.Maximized;
            popularComboboxFuncionario();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            editarFuncionario();
        }

        private void popularComboboxFuncionario()
        {
            comboBoxFuncionario.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFuncionario.AutoCompleteSource = AutoCompleteSource.ListItems;
            listaFuncionarios = funserv.buscarListaDeFuncionario();

            for (int i = 0; i < listaFuncionarios.Count; i++)
            {
                comboBoxFuncionario.Items.Insert(i, listaFuncionarios[i].nome + "-" + listaFuncionarios[i].id);
            }
        }

        private void preencherCamposEditar()
        {
            Funcionario funcionario = listaFuncionarios.FirstOrDefault(p => p.id == int.Parse(comboBoxFuncionario.Text.Split("-")[1].Trim()));
            if (listaFuncionarios.Count > 0)
            {
                textBoxId.Text = Convert.ToString(funcionario.id);
                textBoxcpf_cnpj.Text = funcionario.cpf_cnpj;
                textBoxData.Text = funcionario.dataCadastro;
                textBoxNome.Text = funcionario.nome;
                textBoxCargo.Text = funcionario.cargo;
                textBoxCidade.Text = funcionario.cidade;
                textBoxContato.Text = funcionario.contato;

            }
            else
            {
                MessageBox.Show("Lista de Funcionarios não carregada ");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            preencherCamposEditar();
        }

        private void labelFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void labelCpf_Cnpj_Click(object sender, EventArgs e)
        {

        }

        private void editarFuncionario()
        {
            String id = textBoxId.Text;
            String cpf_cnpj = textBoxcpf_cnpj.Text;
            String dataCadastro = textBoxData.Text;
            String nome = textBoxNome.Text;
            String cargo = textBoxCargo.Text;
            String cidade = textBoxCidade.Text;
            String contato = textBoxContato.Text;

            if (nome.Length > 0 && cargo.Length > 0 && cidade.Length > 0 && contato.Length > 0)
            {
                funserv.editarFuncionario(id, cpf_cnpj, dataCadastro, nome, cargo, cidade, contato);
                comboBoxFuncionario.Items.Clear();
                comboBoxFuncionario.Text = " ";
                popularComboboxFuncionario();
            }
            else
            {
                MessageBox.Show(" A campos vazios");
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
