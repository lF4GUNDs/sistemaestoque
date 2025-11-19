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
    public partial class EstoqueForms : Form
    {
        ExportarExelPdf export = new ExportarExelPdf();
        CategoriaService categoriaService = new CategoriaService();
        ProdutoService service = new ProdutoService();
        EstoqueService serviceEstoque = new EstoqueService();
        private List<Estoque>? listaEstoque;
        private List<Produto>? listaProdutos;
        private List<Categoria>? listaCategoria;
        private Boolean codigo = false;
        private Boolean produto = false;
        private Boolean categoria = false;

        public EstoqueForms()
        {
            InitializeComponent();
            inicializar();
        }

        private void EstoqueForms_Load(object sender, EventArgs e)
        {

        }
        private void inicializar()
        {
            this.WindowState = FormWindowState.Maximized;
            listaEstoque = serviceEstoque.buscarEstoqueRelatorio();
            listaProdutos = service.buscarListaDeProdutos();
            listaCategoria = categoriaService.buscarCategoria();
            popularComboboxProduto();
            preenceherComboxCategoria();
            povoarDataGride(listaEstoque);

        }
        private void popularComboboxProduto()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            for (int i = 0; i < listaProdutos?.Count; i++)
            {
                comboBox1.Items.Insert(i, listaProdutos[i].descricao + "-" + listaProdutos[i].id);
            }
        }
        public void preenceherComboxCategoria()
        {

            for (int i = 0; i < listaCategoria?.Count; i++)
            {
                comboBoxCategoria.Items.Insert(i, listaCategoria[i].id + "-" + listaCategoria[i].descricao);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisa();
        }
        public void pesquisa()
        {
            if (produto && comboBox1.Text.Length > 0 && !categoria)
            {
                List<Estoque> listaPorIdProduto = new List<Estoque>();
                comboBoxCategoria.Text = "";
                textBoxCodigoProduto.Text = "";

                foreach (Estoque estoque in listaEstoque)
                {
                    string[] comboBox1Split = comboBox1.Text.Split('-');
                    if (comboBox1Split.Length >= 2 && estoque.idProduto == int.Parse(comboBox1Split[1].Trim()))
                    {
                        listaPorIdProduto.Add(estoque);
                        textBoxCodigoProduto.Text = estoque.codigoProduto;
                    }
                }
                povoarDataGride(listaPorIdProduto);
            }
            if (categoria && comboBoxCategoria.Text.Length > 0)
            {
                List<Estoque> listaPorCategoria = new List<Estoque>();

                foreach (Estoque estoque in listaEstoque)
                {
                    string[] comboBoxCatSplit = comboBoxCategoria.Text.Split('-');
                    if (comboBoxCatSplit.Length >= 1 && estoque.idCategoria == int.Parse(comboBoxCatSplit[0].Trim()))
                    {
                        listaPorCategoria.Add(estoque);
                    }
                }
                comboBox1.Text = "";
                textBoxCodigoProduto.Text = "";
                povoarDataGride(listaPorCategoria);
            }
        }


        public void povoarDataGride(List<Estoque> lista)
        {
            dataGridViewEstoque.Rows.Clear();

            dataGridViewEstoque.ColumnCount = 7;
            dataGridViewEstoque.Columns[0].Name = "ID";
            dataGridViewEstoque.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewEstoque.Columns[1].Name = "Código Produto";
            dataGridViewEstoque.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEstoque.Columns[2].Name = "Descrição Produto";
            dataGridViewEstoque.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEstoque.Columns[3].Name = "Unidade Medida";
            dataGridViewEstoque.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEstoque.Columns[4].Name = "Quantidade em Estoque";
            dataGridViewEstoque.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEstoque.Columns[5].Name = "Categoria";
            dataGridViewEstoque.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEstoque.Columns[6].Name = "Data Ultima Movimentação ";
            dataGridViewEstoque.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (lista.Count > 0)
            {
                foreach (Estoque estoque in lista)
                {
                    dataGridViewEstoque.Rows.Add(estoque.id, estoque.codigoProduto, estoque.descricaoProduto, estoque.descricaoUnidadeMedida, estoque.quantidade, estoque.descricaoCategoria, estoque.dataMovimentacao);
                }
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado");
            }

            codigo = false;
            produto = false;
            categoria = false;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAabixoDoMinimo_Click(object sender, EventArgs e)
        {
            abaixoEstoqueMinino();
        }
        private void abaixoEstoqueMinino()
        {
            if (listaEstoque?.Count <= 0)
            {
                MessageBox.Show("Dados não encontados");

            }
            else
            {

                dataGridViewEstoque.Rows.Clear();
                dataGridViewEstoque.ColumnCount = 7;
                dataGridViewEstoque.Columns[0].Name = "ID";
                dataGridViewEstoque.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewEstoque.Columns[1].Name = "Código Produto";
                dataGridViewEstoque.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewEstoque.Columns[2].Name = "Descrição Produto";
                dataGridViewEstoque.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewEstoque.Columns[3].Name = "Unidade Medida";
                dataGridViewEstoque.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewEstoque.Columns[4].Name = "Quantidade em Estoque";
                dataGridViewEstoque.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewEstoque.Columns[5].Name = "Categoria";
                dataGridViewEstoque.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewEstoque.Columns[6].Name = "Estoque Mínimo  ";
                dataGridViewEstoque.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                foreach (Estoque estoque in listaEstoque)
                {
                    Produto produtoTemp = listaProdutos.FirstOrDefault(p => p.id == estoque.idProduto);

                    if (produtoTemp?.estoqueMinimo > estoque.quantidade)
                    {
                        dataGridViewEstoque.Rows.Add(estoque.id, estoque.codigoProduto, estoque.descricaoProduto, estoque.descricaoUnidadeMedida, estoque.quantidade, estoque.descricaoCategoria, produtoTemp.estoqueMinimo);
                    }


                }

            }
            codigo = false;
            produto = false;
            categoria = false;


        }

        private void textBoxCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            codigo = true;
            if (codigo && textBoxCodigoProduto.Text.Length > 0)
            {
                List<Estoque> listaPorCodigo = new List<Estoque>();

                foreach (Estoque estoque in listaEstoque)
                {
                    if (estoque != null && estoque.codigoProduto.Contains(textBoxCodigoProduto.Text))
                    {
                        listaPorCodigo.Add(estoque);
                    }

                }
                comboBoxCategoria.Text = "";
                comboBox1.Text = "";
                povoarDataGride(listaPorCodigo);

            }
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            produto = true;
        }



        private void btnPDF_Click(object sender, EventArgs e)
        {
            String descricao = "Tabela Estoque ";
            String descricaoparasalval = "estoque";
            export.ExportarPDF(dataGridViewEstoque, descricao, descricaoparasalval);
        }

        private void btmExel_Click(object sender, EventArgs e)
        {
            String descricao = "Tabela Estoque  ";
            String descricaoparasalval = "estoque";
            export.SalvarExcel(dataGridViewEstoque, descricao, descricaoparasalval);
        }

        private void comboBoxCategoria_DropDown(object sender, EventArgs e)
        {
            categoria = true;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            listaEstoque = serviceEstoque.buscarEstoqueRelatorio();
            povoarDataGride(listaEstoque);
        }
    }
}
