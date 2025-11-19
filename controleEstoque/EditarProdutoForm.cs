using controleEstoque.entity;
using controleEstoque.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleEstoque
{
    public partial class EditarProdutoForm : Form
    {
        CategoriaService categoriaService = new CategoriaService();
        UnidadeMedidaService uniMeSer = new UnidadeMedidaService();
        ProdutoService service = new ProdutoService();
        private List<Produto>? listaProdutos;
        public IList<Categoria>? listaCategoria;
        public IList<UnidadeMedida>? listaUnidade;
        public EditarProdutoForm()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            this.WindowState = FormWindowState.Maximized;
            preencherComboboxProdutos();
            preenceherComboxCategoria();
            preenceherComboxUnidadeMedida();
        }

        private void labelBuscaProduto_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void preencherComboboxProdutos()
        {
            comboBoxProduto.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProduto.AutoCompleteSource = AutoCompleteSource.ListItems;

            listaProdutos = service.buscarListaDeProdutos();
            for (int i = 0; i < listaProdutos.Count; i++)
            {
                comboBoxProduto.Items.Insert(i, listaProdutos[i].descricao + "-" + listaProdutos[i].id);
            }
        }

        public void preenceherComboxCategoria()
        {
            listaCategoria = categoriaService.buscarCategoria();

            for (int i = 0; i < listaCategoria?.Count; i++)
            {
                comboBoxCategoriaProduto.Items.Insert(i, listaCategoria[i].id + "-" + listaCategoria[i].descricao);
            }
        }

        public void preenceherComboxUnidadeMedida()
        {
            listaUnidade = uniMeSer.buscarUnidadeMedida();

            for (int i = 0; i < listaUnidade.Count; i++)
            {
                comboBoxUnicadeMediaProduto.Items.Insert(i, listaUnidade[i].id + "-" + listaUnidade[i].descricao);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            preencherCamposEditar();
        }

        private void editaProduto()
        {

            if (!checarCodigoAntesEditar())
            {
                string codigoProduto = textBoxCodigoProduto.Text;
                string descricao = textBoxNome.Text;
                string categoria = (comboBoxCategoriaProduto.Text.Split("-")[0].Trim());
                string unidadeMedida = (comboBoxUnicadeMediaProduto.Text.Split('-')[0].Trim());
                string estoqueMinimo = textBoxEstoqueMinimo.Text;
                string observacao = textBoxObservacao.Text;
                string id = textBoxId.Text;

                service.editarProduto(id, codigoProduto, descricao, categoria, unidadeMedida, estoqueMinimo, observacao);


            }
            else
            {
                MessageBox.Show("Código Produto já Cadastrado");
            }

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBoxUnicadeMediaProduto.Text.Length > 0 && comboBoxCategoriaProduto.Text.Length > 0)
            {
                editaProduto();
                listaProdutos = service.buscarListaDeProdutos();

            }
            else
            {
                MessageBox.Show("Preencher Campos Obrigatorios");
            }
        }
        private void preencherCamposEditar()
        {
            Produto produto = listaProdutos.FirstOrDefault(p => p.id == int.Parse(comboBoxProduto.Text.Split("-")[1].Trim()));
            if (listaProdutos.Count > 0)
            {
                textBoxCodigoProduto.Text = Convert.ToString(produto.codigoProduto);
                textBoxNome.Text = produto.descricao;
                comboBoxCategoriaProduto.Text = produto.idCategoria +"-"+ produto.categoriaDescricao;
                comboBoxUnicadeMediaProduto.Text = produto.idUnidadeMedida +"-"+ produto.unidadeMedidaDescricao;
                textBoxEstoqueMinimo.Text = Convert.ToString(produto.estoqueMinimo);
                textBoxObservacao.Text = produto.observacao;
                textBoxId.Text = Convert.ToString(produto.id);
            }
            else
            {
                MessageBox.Show("Lista de Produtos não carregada ");
            }
        }

        private bool checarCodigoAntesEditar()
        {
            string codigoProduto = textBoxCodigoProduto.Text;


            Produto produto = listaProdutos.FirstOrDefault(p => p.id == int.Parse(comboBoxProduto.Text.Split("-")[1].Trim()));


            if (produto != null && Convert.ToDouble(codigoProduto) == produto.codigoProduto)
            {
                return false;
            }

            bool codigoJaCadastrado = service.CheckProductCode(codigoProduto);

            return codigoJaCadastrado;
        }

        private void adicinarCategoria_Click(object sender, EventArgs e)
        {
            AdicionarCategoria form = new AdicionarCategoria();
            form.Show();
        }

        private void btnAdionarMedida_Click(object sender, EventArgs e)
        {
            CadastroUnidadeMedida form = new CadastroUnidadeMedida();
            form.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new formProdutos());
            }
        }
    }
}
