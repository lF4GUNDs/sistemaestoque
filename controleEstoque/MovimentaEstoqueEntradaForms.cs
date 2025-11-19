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
using static ClosedXML.Excel.XLPredefinedFormat;
using DateTime = System.DateTime;

namespace controleEstoque
{
    public partial class MovimentaEstoqueEntradaForms : Form
    {
        FornecedorService fornserv = new FornecedorService();
        ProdutoService service = new ProdutoService();
        CategoriaService categoriaService = new CategoriaService();
        MovimentaEstoqueService mvServe = new MovimentaEstoqueService();
        ExportarExelPdf export = new ExportarExelPdf();

        private List<Fornecedor> listaFornecedor;
        private List<Produto>? listaProdutos;
        private List<Categoria>? listaCategoria;
        private List<MovimentaEstoque> listaEntrada;
        private Boolean dataAlteradadateTime1 = false;
        private Boolean dataAlteradadateTime2 = false;
        private Boolean fornecedor = false;
        private Boolean produto = false;
        private Boolean categoriaValida = false;

        public MovimentaEstoqueEntradaForms()
        {
            InitializeComponent();
            inicializa();
        }

        private void inicializa()
        {
            this.WindowState = FormWindowState.Maximized;
            popularComboboxFuncionario();
            popularComboboxProduto();
            preenceherComboxCategoria();
            buscarListaEntrada();

        }

        private void buscarListaEntrada()
        {
            Boolean abilita = false;
            String sql = "";
            listaEntrada = mvServe.buscarListaMovimentaEstoqueEntrada(abilita, sql);
            povoarDataGride();
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            buscarListaEntrada();
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
        private void popularComboboxProduto()
        {
            comboBoxProduto.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            listaProdutos = service.buscarListaDeProdutos();

            for (int i = 0; i < listaProdutos?.Count; i++)
            {
                comboBoxProduto.Items.Insert(i, listaProdutos[i].descricao + "-" + listaProdutos[i].id);
            }
        }

        public void preenceherComboxCategoria()
        {
            listaCategoria = categoriaService.buscarCategoria();

            for (int i = 0; i < listaCategoria?.Count; i++)
            {
                comboBoxCategoria.Items.Insert(i, listaCategoria[i].id + "-" + listaCategoria[i].descricao);
            }
        }

        public void pesquisar()
        {
            String idFornecedor = "";
            String idProduto = "";
            String categoria = "";
            String sql = "";
            String adicionaSql = "";
            String dateTime01 = dateTime1.Value.ToString("yyyy-MM-dd");
            String dateTime02 = dateTime2.Value.ToString("yyyy-MM-dd");
            dateTime02 = dateTime2.Value.AddDays(1).ToString("yyyy-MM-dd");


            if (fornecedor)
            {
                idFornecedor = comboBoxFornecedor.Text.Split('-')[1].Trim();
            }
            if (produto)
            {
                idProduto = comboBoxProduto.Text.Split('-')[1].Trim();
            }
            if (categoriaValida)
            {
                categoria = comboBoxCategoria.Text.Split('-')[0].Trim();
            }

            if (!fornecedor && !produto && !categoriaValida && !dataAlteradadateTime1 && !dataAlteradadateTime2)
            {

                MessageBox.Show("Nenhum campo selecionado para pesquisa");

            }
            else
            {
                if (!fornecedor && !produto && !categoriaValida && dataAlteradadateTime1 || dataAlteradadateTime2)
                {

                    adicionaSql = " where mc.dataMovimentacao between '" + dateTime01 + "' and '" + dateTime02 + "'";

                }
                else
                {

                    if (fornecedor)
                    {
                        if (fornecedor && produto && !categoriaValida)
                        {
                            adicionaSql = " where mc.idFornecedor =  " + idFornecedor + " and mc.IdProduto = " + idProduto + "";
                        }

                        if (fornecedor && !produto && categoriaValida)
                        {
                            adicionaSql = " where mc.idFORNECEDOR =  " + idFornecedor + " and p.idCategoria = " + categoria + "";
                        }

                        if (!produto && !categoriaValida)
                        {
                            adicionaSql = " where mc.idFornecedor = " + idFornecedor + "";
                        }


                    }
                    else


                    if (!fornecedor && produto && !categoriaValida)
                    {


                        adicionaSql = " where mc.IdProduto = " + idProduto + "";

                    }
                    if (!fornecedor && !produto && categoriaValida)
                    {
                        adicionaSql = " where p.idCategoria =" + categoria + "";
                    }

                    if (dataAlteradadateTime1 || dataAlteradadateTime2)
                    {
                        if (dateTime01 == dateTime02)
                        {
                            adicionaSql = adicionaSql + " and mc.dataMovimentacao between '" + dateTime01 + "' and '" + dateTime02 + "'";
                        }


                    }
                    if (!fornecedor && produto && categoriaValida)
                    {
                        MessageBox.Show("Campo funcionário e campo categoria traz dados ambíguos");
                    }


                }

                Boolean abilita = true;
                sql = adicionaSql;
                listaEntrada = mvServe.buscarListaMovimentaEstoqueEntrada(abilita, sql);

                dataGridViewEntrada.Rows.Clear();
                povoarDataGride();
                comboBoxFornecedor.Text = "";
                comboBoxProduto.Text = "";
                comboBoxCategoria.Text = "";
                dataAlteradadateTime1 = false;
                dataAlteradadateTime2 = false;
                fornecedor = false;
                produto = false;
                categoriaValida = false;
                abilita = false;


            }


        }

        private void labelFornecedor_Click(object sender, EventArgs e)
        {

        }

        public void povoarDataGride()
        {
            dataGridViewEntrada.Rows.Clear();


            dataGridViewEntrada.ColumnCount = 7;
            dataGridViewEntrada.Columns[0].Name = "Nome";
            dataGridViewEntrada.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewEntrada.Columns[1].Name = "Código Produto";
            dataGridViewEntrada.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEntrada.Columns[2].Name = "Descrição Produto";
            dataGridViewEntrada.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEntrada.Columns[3].Name = "Unidade Medida";
            dataGridViewEntrada.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEntrada.Columns[4].Name = "Entrada";
            dataGridViewEntrada.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEntrada.Columns[5].Name = "Categoria";
            dataGridViewEntrada.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEntrada.Columns[6].Name = "Data Movimentação";
            dataGridViewEntrada.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;





            foreach (MovimentaEstoque mvc in listaEntrada)
            {

                dataGridViewEntrada.Rows.Add(mvc.nomeFornecedor, mvc.codigoProduto, mvc.descricaoProduto, mvc.descricaoUnidadeMedida, mvc.quantidade, mvc.descricaoCategoria, mvc.dataMovimentacao);
            }

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            fornecedor = true;
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            produto = true;
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriaValida = true;
        }

        private void dateTime1_DropDown(object sender, EventArgs e)
        {
            dataAlteradadateTime1 = true;
        }

        private void dateTime2_DropDown(object sender, EventArgs e)
        {
            dataAlteradadateTime2 = true;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            String descricao = "Tabela de Movimentação Entrada ";
            String descricaoparasalval = "entrada";
            export.ExportarPDF(dataGridViewEntrada, descricao, descricaoparasalval);
        }

        private void btmExel_Click(object sender, EventArgs e)
        {
            String descricao = "Tabela de Movimentação Entrada ";
            String descricaoparasalval = "entrada";
            export.SalvarExcel(dataGridViewEntrada, descricao, descricaoparasalval);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
