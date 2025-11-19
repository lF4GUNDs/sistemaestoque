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
    public partial class FuncionariosForms : Form
    {
        FuncionarioService funserv = new FuncionarioService();
        private IList<Funcionario> listaFuncionarios;

        public FuncionariosForms()
        {
            InitializeComponent();
            inicializa();
        }

        private void inicializa()
        {
            this.WindowState = FormWindowState.Maximized;
            popularComboboxFuncionario();
            povoarDataGride();
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

        public void povoarDataGride()
        {
            dataGridViewFuncionario.Rows.Clear();


            dataGridViewFuncionario.ColumnCount = 7;
            dataGridViewFuncionario.Columns[0].Name = "ID";
            dataGridViewFuncionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFuncionario.Columns[1].Name = "Nome";
            dataGridViewFuncionario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFuncionario.Columns[2].Name = "CPF/CNPJ";
            dataGridViewFuncionario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFuncionario.Columns[3].Name = "Cidade";
            dataGridViewFuncionario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFuncionario.Columns[4].Name = "Cargo";
            dataGridViewFuncionario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFuncionario.Columns[5].Name = "Contato";
            dataGridViewFuncionario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFuncionario.Columns[6].Name = "Data Cadastro";
            dataGridViewFuncionario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            foreach (Funcionario funcionario in listaFuncionarios)
            {

                dataGridViewFuncionario.Rows.Add(funcionario.id, funcionario.nome, funcionario.cpf_cnpj, funcionario.cidade, funcionario.cargo, funcionario.contato, funcionario.dataCadastro);
            }

        }

        public void povoarDataGridePesquisar()
        {

            if (comboBoxFuncionario.Text.Length > 0)
            {
                int id = int.Parse(comboBoxFuncionario.Text.Split('-')[1].Trim());
                dataGridViewFuncionario.Rows.Clear();

                dataGridViewFuncionario.ColumnCount = 7;
                dataGridViewFuncionario.Columns[0].Name = "ID";
                dataGridViewFuncionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewFuncionario.Columns[1].Name = "Nome";
                dataGridViewFuncionario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewFuncionario.Columns[2].Name = "CPF/CNPJ";
                dataGridViewFuncionario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionario.Columns[3].Name = "Cidade";
                dataGridViewFuncionario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionario.Columns[4].Name = "Cargo";
                dataGridViewFuncionario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionario.Columns[5].Name = "Contato";
                dataGridViewFuncionario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionario.Columns[6].Name = "Data Cadastro";
                dataGridViewFuncionario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                Funcionario funcionario = listaFuncionarios.Single(e => e.id == id);
                dataGridViewFuncionario.Rows.Add(funcionario.id, funcionario.nome, funcionario.cpf_cnpj, funcionario.cidade, funcionario.cargo, funcionario.contato, funcionario.dataCadastro);


            }
            else
            {
                MessageBox.Show("Campo funcionário não selecionado");
            }

        }



        private void btnVoltarProduto_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new CadastroFuncionario());
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            povoarDataGridePesquisar();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            povoarDataGride();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new EditarFuncionario());
            }
        }
    }
}
