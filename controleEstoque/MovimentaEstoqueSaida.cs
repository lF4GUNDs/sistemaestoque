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
    public partial class MovimentaEstoqueSaida : Form
    {
        ProdutoService service = new ProdutoService();
        FuncionarioService funserv = new FuncionarioService();
        CategoriaService categoriaService = new CategoriaService();
        MovimentaEstoqueService mvsServe = new MovimentaEstoqueService();
        ExportarExelPdf export = new ExportarExelPdf();

        private List<Categoria>? listaCategoria;
        private List<Funcionario> listaFuncionarios;
        private List<Produto>? listaProdutos;
        private List<MovimentaEstoque> listaSaida;
        private Boolean dataAlteradadateTime1 = false;
        private Boolean dataAlteradadateTime2 = false;
        private Boolean funcionario = false;
        private Boolean produto = false;
        private Boolean categoriaValida = false;
        public MovimentaEstoqueSaida()
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
            buscaListaSaida();
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

        public void buscaListaSaida()
        {
            Boolean abilita = false;
            String sql = "";
            listaSaida = mvsServe.buscarListaMovimentaEstoqueSaida(abilita, sql);
        }

        public void pesquisar()
        {
            String idFuncionario = "";
            String idProduto = "";
            String categoria = "";
            String sql = "";
            String adicionaSql = "";
            String dateTime01 = dateTime1.Value.ToString("yyyy-MM-dd");
            String dateTime02 = dateTime2.Value.ToString("yyyy-MM-dd");
            dateTime02 = dateTime2.Value.AddDays(1).ToString("yyyy-MM-dd");

            if (funcionario)
            {
                idFuncionario = comboBoxFuncionario.Text.Split('-')[1].Trim();
            }
            if (produto)
            {
                idProduto = comboBoxProduto.Text.Split('-')[1].Trim();
            }
            if (categoriaValida)
            {
                categoria = comboBoxCategoria.Text.Split('-')[0].Trim();
            }

            if (!funcionario && !produto && !categoriaValida && !dataAlteradadateTime1 && !dataAlteradadateTime2)
            {

                MessageBox.Show("Nenhum campo selecionado para pesquisa");

            }
            else
            {
                if (!funcionario && !produto && !categoriaValida && dataAlteradadateTime1 || dataAlteradadateTime2)
                {

                    adicionaSql = " where mv.dataMovimentacao between '" + dateTime01 + "' and '" + dateTime02 + "'";

                }
                else
                {

                    if (funcionario)
                    {
                        if (funcionario && produto && !categoriaValida)
                        {
                            adicionaSql = " where mv.idFuncionario =  " + idFuncionario + " and mv.idProduto = " + idProduto + "";
                        }

                        if (funcionario && !produto && categoriaValida)
                        {
                            adicionaSql = " where mv.idFuncionario =  " + idFuncionario + " and p.idCategoria = " + categoria + "";
                        }

                        if (!produto && !categoriaValida)
                        {
                            adicionaSql = " where mv.idFuncionario = " + idFuncionario + "";
                        }


                    }
                    else


                    if (!funcionario && produto && !categoriaValida)
                    {


                        adicionaSql = " where mv.idProduto = " + idProduto + "";

                    }
                    if (!funcionario && !produto && categoriaValida)
                    {
                        adicionaSql = " where p.idCategoria =" + categoria + "";
                    }

                    if (dataAlteradadateTime1 || dataAlteradadateTime2)
                    {
                        if (dateTime01 == dateTime02)
                        {

                            adicionaSql = adicionaSql + " and mv.dataMovimentacao between '" + dateTime01 + "' and '" + dateTime02 + "'";

                        }


                    }
                    if (!funcionario && produto && categoriaValida)
                    {
                        MessageBox.Show("Campo funcionário e campo categoria traz dados ambíguos");
                    }


                }

                Boolean abilita = true;
                sql = adicionaSql;
                listaSaida = mvsServe.buscarListaMovimentaEstoqueSaida(abilita, sql);


                //  listaSaida = mvsServe.buscarListaMovimentaEstoqueSaidaPesquisa(sql);
                dataGridViewMovimentaSaida.Rows.Clear();
                povoarDataGride();
                comboBoxFuncionario.Text = "";
                comboBoxProduto.Text = "";
                comboBoxCategoria.Text = "";
                dataAlteradadateTime1 = false;
                dataAlteradadateTime2 = false;
                funcionario = false;
                produto = false;
                categoriaValida = false;
                abilita = false;

            }


        }


        public void povoarDataGride()
        {
            dataGridViewMovimentaSaida.Rows.Clear();


            dataGridViewMovimentaSaida.ColumnCount = 8;
            dataGridViewMovimentaSaida.Columns[0].Name = "Nome";
            dataGridViewMovimentaSaida.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMovimentaSaida.Columns[1].Name = "Código Produto";
            dataGridViewMovimentaSaida.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMovimentaSaida.Columns[2].Name = "Descrição Produto";
            dataGridViewMovimentaSaida.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMovimentaSaida.Columns[3].Name = "Unidade Medida";
            dataGridViewMovimentaSaida.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMovimentaSaida.Columns[4].Name = "Saídas";
            dataGridViewMovimentaSaida.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMovimentaSaida.Columns[5].Name = "Categoria";
            dataGridViewMovimentaSaida.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMovimentaSaida.Columns[6].Name = "Data Movimentação";
            dataGridViewMovimentaSaida.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMovimentaSaida.Columns[7].Name = "Observação ";
            dataGridViewMovimentaSaida.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




            foreach (MovimentaEstoque mvs in listaSaida)
            {

                dataGridViewMovimentaSaida.Rows.Add(mvs.nomeFuncionario, mvs.codigoProduto, mvs.descricaoProduto, mvs.descricaoUnidadeMedida, mvs.quantidade, mvs.descricaoCategoria, mvs.dataMovimentacao, mvs.observacao);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcionario = true;
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            produto = true;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            buscaListaSaida();
            povoarDataGride();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            String descricao = "Tabela de Movimentação Saída ";
            String descricaoparasalval = "saidas";
            export.ExportarPDF(dataGridViewMovimentaSaida, descricao, descricaoparasalval);
        }

        private void btmExel_Click(object sender, EventArgs e)
        {
            String descricao = "Tabela de Movimentação Saída  ";
            String descricaoparasalval = "saidas";
            export.SalvarExcel(dataGridViewMovimentaSaida, descricao, descricaoparasalval);
        }

        private void dateTime1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dateTime2_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
