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
    public partial class EntradaProdutosForm : Form
    {
        public List<Produto> produtos = new List<Produto>();
        public IList<Produto>? listaPrdoutos;
        public IList<Fornecedor> listaFornecedores;
        public IList<Estoque> listaEstoque;
        ProdutoService service = new ProdutoService();
        FornecedorService serviceFornecedor = new FornecedorService();
        EstoqueService serviceEstoque = new EstoqueService();
        public EntradaProdutosForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            inicializa();
        }

        public void inicializa()
        {
            preencherComboboxProdutos();
            preencherComboboxFornecedor();
            buscarListaEstoque();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void FilaEntradaProdutos()
        {

            if (listaPrdoutos != null)
            {
                if (comboBoxProduto.Text.Length > 0 && comboBoxProduto.Text.Length > 0 && textBoxQuantidade.Text.Length > 0)
                {
                    Produto codigo = listaPrdoutos.FirstOrDefault(p => p.id == int.Parse(comboBoxProduto.Text.Split("-")[1].Trim()));
                    //  int codigoProduto = int.Parse(comboBoxProduto.Text.Split('-')[0].Trim());
                    int codigoProduto = codigo.codigoProduto;
                    string descricao = codigo.descricao;
                    string unidadeMendida = codigo.unidadeMedidaDescricao;
                    string quantidade = textBoxQuantidade.Text;
                    int idProduto = codigo.id;
                    Produto produtoExistente = produtos.FirstOrDefault(p => p.id == idProduto);

                    if (produtoExistente != null)
                    {
                        MessageBox.Show("Produto já consta na lista ");

                    }
                    else
                    {
                        dataGridViewProdutos.Rows.Clear();

                        Produto novoProduto = new Produto
                        {

                            codigoProduto = codigoProduto,
                            descricao = descricao,
                            quantidade = quantidade,
                            unidadeMedidaDescricao = unidadeMendida,
                            id = idProduto
                        };

                        produtos.Add(novoProduto);

                        dataGridViewProdutos.ColumnCount = 4;
                        dataGridViewProdutos.Columns[0].Name = "Código Produto";
                        dataGridViewProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridViewProdutos.Columns[1].Name = "Quantidade";
                        dataGridViewProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridViewProdutos.Columns[2].Name = "Descrição Produto";
                        dataGridViewProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridViewProdutos.Columns[3].Name = "Unidade de Medida";
                        dataGridViewProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                        DataGridViewButtonColumn removerButtonColumn = new DataGridViewButtonColumn();
                        removerButtonColumn.HeaderText = "Remover";
                        removerButtonColumn.Text = "Remover";
                        removerButtonColumn.UseColumnTextForButtonValue = true;
                        dataGridViewProdutos.Columns.Add(removerButtonColumn);


                        foreach (Produto produto in produtos)
                        {
                            dataGridViewProdutos.Rows.Add(produto.codigoProduto, produto.quantidade, produto.descricao, produto.unidadeMedidaDescricao);
                        }
                        textBoxQuantidade.Clear();
                        comboBoxProduto.Text = " ";

                    }
                }
                else
                {
                    MessageBox.Show("Campos obrigatórios não preenchido");

                }
            }
            else
            {
                MessageBox.Show("Lista produto não carregada por completo ");
                preencherComboboxProdutos();
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

        private void preencherComboboxFornecedor()
        {
            comboBoxFornecedor.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;

            listaFornecedores = serviceFornecedor.buscarListaDeFornecedor();
            for (int i = 0; i < listaFornecedores.Count; i++)
            {
                comboBoxFornecedor.Items.Insert(i, listaFornecedores[i].nome + "-" + listaFornecedores[i].id);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (comboBoxFornecedor.Text.Length > 0 && comboBoxProduto.Text.Length > 0 && textBoxQuantidade.Text.Length > 0 && textBoxQuantidade.Text != "0")
            {
                FilaEntradaProdutos();
            }
            else
            {
                MessageBox.Show("Campos obrigatórios inválidos");
            }
        }



        private void atualizarDataGridView()
        {
            dataGridViewProdutos.Rows.Clear();
            dataGridViewProdutos.ColumnCount = 4;
            dataGridViewProdutos.Columns[0].Name = "Código Produto";
            dataGridViewProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[1].Name = "Quantidade";
            dataGridViewProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProdutos.Columns[2].Name = "Descrição Produto";
            dataGridViewProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProdutos.Columns[3].Name = "Unidade de Medida";
            dataGridViewProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewButtonColumn removerButtonColumn = new DataGridViewButtonColumn();
            removerButtonColumn.HeaderText = "Remover";
            removerButtonColumn.Text = "Remover";
            removerButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewProdutos.Columns.Add(removerButtonColumn);


            foreach (Produto produto in produtos)
            {
                dataGridViewProdutos.Rows.Add(produto.codigoProduto, produto.quantidade, produto.descricao, produto.unidadeMedidaDescricao);
            }
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void buscarListaEstoque()
        {
            listaEstoque = serviceEstoque.buscarEstoque();
        }

        public void movimentaEstoqueEntrada()
        {
            buscarListaEstoque();
            foreach (Produto produto in produtos)
            {
                Estoque estoque = listaEstoque.Single(e => e.idProduto == produto.id);
                double quatidade = Convert.ToDouble(produto.quantidade);
                double adicinarEstoque = quatidade + estoque.quantidade;
                int idProduto = produto.id;
                String quantidadeUnitaria = produto.quantidade;
                String idFornecedor = comboBoxFornecedor.Text.Split("-")[1].Trim();

                serviceEstoque.movimentaEstoqueCompras(adicinarEstoque, idProduto, quantidadeUnitaria, idFornecedor);
            }

            produtos.Clear();
            atualizarDataGridView();
            MessageBox.Show("Operação realizada com  sucesso");



        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Confirma a entrada?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (resultado == DialogResult.OK)
                {
                    movimentaEstoqueEntrada();
                    comboBoxFornecedor.Text = "";
                    comboBoxProduto.Text = "";
                    textBoxQuantidade.Text = "";
                    dataGridViewProdutos.Rows.Clear();
                    dataGridViewProdutos.Columns.Clear();
                }

            }
            else
            {
                MessageBox.Show("Não há dados na tabela.");
            }
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
                MessageBox.Show("Este campo aceita somente uma ponto");
            }
        }

        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EntradaProdutosForm_Load(object sender, EventArgs e)
        {

        }

        private void labelNomeProduto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridViewProdutos.Columns.Count)
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

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxProduto.Text.Length > 0 && comboBoxFornecedor.Text.Length > 0 && textBoxQuantidade.Text.Length > 0 && textBoxQuantidade.Text != "0")
            {
                FilaEntradaProdutos();
                comboBoxFornecedor.Enabled = false;
            }
            else
            {
                MessageBox.Show("Campos obrigatórios inválidos");
            }
        }

        private void btnConformar_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Confirma a entrada?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    movimentaEstoqueEntrada();
                    comboBoxFornecedor.Text = "";
                    comboBoxProduto.Text = "";
                    textBoxQuantidade.Text = "";
                    dataGridViewProdutos.Rows.Clear();
                    dataGridViewProdutos.Columns.Clear();
                   
                }
            }
            else
            {
                MessageBox.Show("Não há dados na tabela.");
               
            }
            comboBoxFornecedor.Enabled = true;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            comboBoxFornecedor.Text = "";
            comboBoxProduto.Text = "";
            textBoxQuantidade.Text = "";
            dataGridViewProdutos.Rows.Clear();
            dataGridViewProdutos.Columns.Clear();
            comboBoxProduto.Enabled = true;
            produtos.Clear();
            comboBoxFornecedor.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }

}
