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
    public partial class FornecedorFormPrincipal : Form
    {
        FornecedorService fornserv = new FornecedorService();
        private IList<Fornecedor> listaFornecedor;

        public FornecedorFormPrincipal()
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

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void popularComboboxFuncionario()
        {
            comboBoxFornecedor.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            listaFornecedor = fornserv.buscarListaDeFornecedor();

            for (int i = 0; i < listaFornecedor.Count; i++)
            {
                comboBoxFornecedor.Items.Insert(i, listaFornecedor[i].nome + "-" + listaFornecedor[i].id);
            }
        }

        public void povoarDataGride()
        {
            dataGridViewFornecedor.Rows.Clear();

            dataGridViewFornecedor.ColumnCount = 7;
            dataGridViewFornecedor.Columns[0].Name = "ID";
            dataGridViewFornecedor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFornecedor.Columns[1].Name = "Nome";
            dataGridViewFornecedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFornecedor.Columns[2].Name = "CPF/CNPJ";
            dataGridViewFornecedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFornecedor.Columns[3].Name = "Telefone";
            dataGridViewFornecedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFornecedor.Columns[4].Name = "Contato";
            dataGridViewFornecedor.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFornecedor.Columns[5].Name = "Email";
            dataGridViewFornecedor.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFornecedor.Columns[6].Name = "Cidade";
            dataGridViewFornecedor.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            foreach (Fornecedor fornecedor in listaFornecedor)
            {

                dataGridViewFornecedor.Rows.Add(fornecedor.id, fornecedor.nome, fornecedor.cpf_cnpj, fornecedor.telefone, fornecedor.contato, fornecedor.email, fornecedor.cidade);
            }

        }

        public void povoarDataGridePesquisar()
        {

            if (comboBoxFornecedor.Text.Length > 0)
            {
                int id = int.Parse(comboBoxFornecedor.Text.Split('-')[1].Trim());
                dataGridViewFornecedor.Rows.Clear();

                dataGridViewFornecedor.ColumnCount = 7;
                dataGridViewFornecedor.Columns[0].Name = "ID";
                dataGridViewFornecedor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewFornecedor.Columns[1].Name = "Nome";
                dataGridViewFornecedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewFornecedor.Columns[2].Name = "CPF/CNPJ";
                dataGridViewFornecedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFornecedor.Columns[3].Name = "Telefone";
                dataGridViewFornecedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFornecedor.Columns[4].Name = "Contato";
                dataGridViewFornecedor.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFornecedor.Columns[5].Name = "Email";
                dataGridViewFornecedor.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFornecedor.Columns[6].Name = "Cidade";
                dataGridViewFornecedor.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                Fornecedor fornecedor = listaFornecedor.Single(e => e.id == id);
                dataGridViewFornecedor.Rows.Add(fornecedor.id, fornecedor.nome, fornecedor.cpf_cnpj, fornecedor.telefone, fornecedor.contato, fornecedor.email, fornecedor.cidade);


            }
            else
            {
                MessageBox.Show("Campo fornecedor não selecionado");
            }
        }


        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new CadastroFornecedor());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new EditarFornecedor());
            }
        }

        private void btnVoltarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            povoarDataGridePesquisar();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            povoarDataGride();
        }
    }
}
