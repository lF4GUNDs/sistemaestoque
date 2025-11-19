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
    public partial class SaidaDeProdutos : Form
    {
        FuncionarioService funserv = new FuncionarioService();
        private IList<Funcionario> listaFuncionarios;
        private IList<Produto>? listaPrdoutos;
        public List<Produto> produtos = new List<Produto>();
        ProdutoService service = new ProdutoService();
        EstoqueService serviceEstoque = new EstoqueService();
        public IList<Estoque> listaEstoque;
        public SaidaDeProdutos()
        {
            InitializeComponent();
            inicializa();
        }

        private void inicializa()
        {

            this.WindowState = FormWindowState.Maximized;
            popularComboboxFuncionario();
            preencherComboboxProdutos();
            buscarListaEstoque();
        }

        private void MaximizarFormulario()
        {

            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height - 40;
            Location = new System.Drawing.Point(0, 0);


        }



        public void buscarListaEstoque()
        {
            listaEstoque = serviceEstoque.buscarEstoque();
        }

        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e ponto");
            }
            if ((e.KeyChar == '.') && (((System.Windows.Forms.TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente um ponto");
            }
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
        private void preencherComboboxProdutos()
        {
            comboBoxProduto.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProduto.AutoCompleteSource = AutoCompleteSource.ListItems;

            listaPrdoutos = service.buscarListaDeProdutos();
            for (int i = 0; i < listaPrdoutos.Count; i++)
            {
                comboBoxProduto.Items.Insert(i, listaPrdoutos[i].descricao + "-" + listaPrdoutos[i].id);
            }
        }
        public void FilaEntradaProdutos()
        {

            if (listaPrdoutos != null)
            {
                Funcionario funcionario = listaFuncionarios.FirstOrDefault(f => f.id == int.Parse(comboBoxFuncionario.Text.Split('-')[1].Trim()));
                Produto produto = listaPrdoutos.FirstOrDefault(p => p.id == int.Parse(comboBoxProduto.Text.Split("-")[1].Trim()));

                int codigoProduto = produto.codigoProduto;
                string descricao = produto.descricao;
                string unidadeMendida = produto.unidadeMedidaDescricao;
                string quantidade = textBoxQuantidade.Text;
                int idProduto = produto.id;
                Produto produtoExistente = produtos.FirstOrDefault(p => p.id == idProduto);

                if (produtoExistente != null)
                {
                    MessageBox.Show("Produto já consta na lista ");

                }
                else
                {
                    dataGridListaProdutos.Rows.Clear();
                    Produto novoProduto = new Produto
                    {
                        idFuncionario = funcionario.id,
                        nome = funcionario.nome,
                        codigoProduto = codigoProduto,
                        descricao = descricao,
                        quantidade = quantidade,
                        unidadeMedidaDescricao = unidadeMendida,
                        id = idProduto,
                        observacao = textBoxObservacao.Text

                    };

                    produtos.Add(novoProduto);

                    dataGridListaProdutos.ColumnCount = 6;
                    dataGridListaProdutos.Columns[0].Name = "Nome Funcionário ";
                    dataGridListaProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridListaProdutos.Columns[1].Name = "Código Produto";
                    dataGridListaProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridListaProdutos.Columns[2].Name = "Quantidade";
                    dataGridListaProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridListaProdutos.Columns[3].Name = "Descrição Produto";
                    dataGridListaProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridListaProdutos.Columns[4].Name = "Unidade de Medida";
                    dataGridListaProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridListaProdutos.Columns[5].Name = "Observação";
                    dataGridListaProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    DataGridViewButtonColumn removerButtonColumn = new DataGridViewButtonColumn();
                    removerButtonColumn.HeaderText = "Remover";
                    removerButtonColumn.Text = "Remover";
                    removerButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridListaProdutos.Columns.Add(removerButtonColumn);


                    foreach (Produto produto2 in produtos)
                    {
                        dataGridListaProdutos.Rows.Add(produto2.nome, produto2.codigoProduto, produto2.quantidade, produto2.descricao, produto2.unidadeMedidaDescricao, produto2.observacao);
                    }

                    textBoxQuantidade.Clear();
                    comboBoxProduto.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Lista produto não carregada por completo ");
                preencherComboboxProdutos();
            }

        }

        private void atualizarDataGridView()
        {

            dataGridListaProdutos.Rows.Clear();

            dataGridListaProdutos.ColumnCount = 6;
            dataGridListaProdutos.Columns[0].Name = "Nome Funcionário ";
            dataGridListaProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridListaProdutos.Columns[1].Name = "Código Produto";
            dataGridListaProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridListaProdutos.Columns[2].Name = "Quantidade";
            dataGridListaProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridListaProdutos.Columns[3].Name = "Descrição Produto";
            dataGridListaProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridListaProdutos.Columns[4].Name = "Unidade de Medida";
            dataGridListaProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridListaProdutos.Columns[5].Name = "Observação";
            dataGridListaProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn removerButtonColumn = new DataGridViewButtonColumn();
            removerButtonColumn.HeaderText = "Remover";
            removerButtonColumn.Text = "Remover";
            removerButtonColumn.UseColumnTextForButtonValue = true;
            dataGridListaProdutos.Columns.Add(removerButtonColumn);


            foreach (Produto produto in produtos)
            {
                dataGridListaProdutos.Rows.Add(produto.nome, produto.codigoProduto, produto.quantidade, produto.descricao, produto.unidadeMedidaDescricao, produto.observacao);
            }
        }

        public void movimentaEstoqueSaida()
        {
            buscarListaEstoque();
            foreach (Produto produto in produtos)
            {
                Estoque estoque = listaEstoque.Single(e => e.idProduto == produto.id);
                double quantidade = Convert.ToDouble(produto.quantidade);
                double subtrairEstoque = estoque.quantidade - quantidade;

                int idProduto = produto.id;
                String quantidadeUnitaria = produto.quantidade;
                String idFuncionario = Convert.ToString(produto.idFuncionario);
                String observacao = produto.observacao;

                serviceEstoque.movimentaEstoqueSaida(subtrairEstoque, idProduto, quantidadeUnitaria, idFuncionario, observacao);
            }

            produtos.Clear();
            atualizarDataGridView();
            MessageBox.Show("Operação realizada com  sucesso");

        }

        private void dataGridListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridListaProdutos.Columns.Count)
            {

                DialogResult result = MessageBox.Show("Deseja excluir o produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    if (produtos != null && e.RowIndex < produtos.Count)
                    {
                        produtos.RemoveAt(e.RowIndex);

                        atualizarDataGridView();
                    }
                }

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (comboBoxProduto.Text.Length > 0 && comboBoxProduto.Text.Length > 0 && textBoxQuantidade.Text.Length > 0 && textBoxQuantidade.Text != "0")
            {
                comboBoxFuncionario.Enabled = false;
                FilaEntradaProdutos();
            }
            else
            {
                MessageBox.Show("Campos obrigatórios inválidos");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Confirma a saída ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (resultado == DialogResult.OK)
                {
                    movimentaEstoqueSaida();
                    comboBoxFuncionario.Text = "";
                    comboBoxProduto.Text = "";
                    textBoxQuantidade.Text = "";
                    dataGridListaProdutos.Rows.Clear();
                    dataGridListaProdutos.Columns.Clear();

                }

            }
            else
            {
                MessageBox.Show("Não há dados na tabela.");
            }
            comboBoxFuncionario.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            comboBoxFuncionario.Text = "";
            comboBoxProduto.Text = "";
            textBoxQuantidade.Text = "";
            textBoxObservacao.Text = "";
            dataGridListaProdutos.Rows.Clear();
            dataGridListaProdutos.Columns.Clear();
            comboBoxFuncionario.Enabled = true;
            produtos.Clear();
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
