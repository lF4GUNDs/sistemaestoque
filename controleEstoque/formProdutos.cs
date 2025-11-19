using controleEstoque.entity;
using controleEstoque.Service;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace controleEstoque
{


    public partial class formProdutos : Form
    {
        ProdutoService service = new ProdutoService();
        EstoqueService serviceEstoque = new EstoqueService();
        private List<Estoque>? listaEstoque;
        private List<Produto>? listaProdutos;
        ExportarExelPdf export = new ExportarExelPdf();

        public formProdutos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            povoarDataGride();
            popuularComboboxProduto();

        }

        private void groupBoxPodutos_Enter(object sender, EventArgs e)
        {

        }

        private void popuularComboboxProduto()
        {
            comboBoxProduto.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProduto.AutoCompleteSource = AutoCompleteSource.ListItems;

            for (int i = 0; i < listaProdutos?.Count; i++)
            {
                comboBoxProduto.Items.Insert(i, listaProdutos[i].descricao + "-" + listaProdutos[i].id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new CadastroProdutos());
            }

        }

        public void povoarDataGride()
        {
            dataGridViewProdutos.Rows.Clear();
            listaProdutos = service.buscarListaDeProdutos();
            listaEstoque = serviceEstoque.buscarEstoque();

            dataGridViewProdutos.ColumnCount = 6;
            dataGridViewProdutos.Columns[0].Name = "ID";
            dataGridViewProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[1].Name = "Codigo Produto";
            dataGridViewProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[2].Name = "Descrição";
            dataGridViewProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[3].Name = "Categoria";
            dataGridViewProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[4].Name = "Descrição de Medida";
            dataGridViewProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[5].Name = "Observação";
            dataGridViewProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            foreach (Produto produto in listaProdutos)
            {
                Estoque estoqueTemp = listaEstoque.Single(e => e.idProduto == produto.id);
                dataGridViewProdutos.Rows.Add(produto.id, produto.codigoProduto, produto.descricao, produto.categoriaDescricao, produto.unidadeMedidaDescricao, produto.observacao);
            }

        }

        public void povoarDataGridePesquisa()
        {

            if (comboBoxProduto.Text.Length > 0)
            {
                int id = int.Parse(comboBoxProduto.Text.Split('-')[1].Trim());
                dataGridViewProdutos.Rows.Clear();

                dataGridViewProdutos.ColumnCount = 6;
                dataGridViewProdutos.Columns[0].Name = "ID";
                dataGridViewProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProdutos.Columns[1].Name = "Codigo Produto";
                dataGridViewProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProdutos.Columns[2].Name = "Descrição";
                dataGridViewProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProdutos.Columns[3].Name = "Categoria";
                dataGridViewProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProdutos.Columns[4].Name = "Descrição de Medida";
                dataGridViewProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProdutos.Columns[5].Name = "Observação";
                dataGridViewProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                Produto produto = listaProdutos.Single(e => e.id == id);
                dataGridViewProdutos.Rows.Add(produto.id, produto.codigoProduto, produto.descricao, produto.categoriaDescricao, produto.unidadeMedidaDescricao, produto.observacao);


            }
            else
            {
                MessageBox.Show("Campo produto não selecionado");
            }




        }

        private void btnImprimeRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarProduto_Click(object sender, EventArgs e)
        {

            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.ActiveFormClose();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e) { }





        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            povoarDataGridePesquisa();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            povoarDataGride();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new EditarProdutoForm());
            }
        }

        private void btnEditar_Enter(object sender, EventArgs e)
        {

        }
    }
}
