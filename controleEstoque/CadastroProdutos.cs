using controleEstoque.entity;
using controleEstoque.Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace controleEstoque
{
    public partial class CadastroProdutos : Form
    {
        Conexao con = new Conexao();
        CategoriaService categoriaService = new CategoriaService();
        UnidadeMedidaService uniMeSer = new UnidadeMedidaService();

        public IList<Categoria>? listaCategoria;
        public IList<UnidadeMedida>? listaUnidade;

        public CadastroProdutos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            preenceherComboxCategoria();
            preenceherComboxUnidadeMedida();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarCategoria form = new AdicionarCategoria();
            form.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (ConferirTextBox())
            {
                cadastrarProduto();
            }

            if (CheckProductCode())
            {

                var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
                if (principal != null)
                {
                    principal.FormShow(new CadastroProdutos());
                }
                this.Close();

            }



        }

        private void groupBoxCadastrandoProduto_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdionarMedida_Click(object sender, EventArgs e)
        {
            CadastroUnidadeMedida form = new CadastroUnidadeMedida();
            form.Show();
        }

        public void cadastrarProduto()
        {
            int condigo = int.Parse(textBoxCodigoProduto.Text);
            String descricao = textBoxNome.Text;
            String observacao = textBoxObservacao.Text;
            //  string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            double valorMinimoEstoque = double.Parse(textBoxEstoqueMinimo.Text);
            int idCategoria = int.Parse(comboBoxCategoriaProduto.Text.Split('-')[0].Trim());
            int idUnidadeMedida = int.Parse(comboBoxUnicadeMediaProduto.Text.Split('-')[0].Trim());

            if (!CheckProductCode())
            {

                if (con.OpenConnection())
                {
                    try
                    {
                        string query = "INSERT INTO produto (descricao, estoqueMinimo, observacao, codigoProduto, idCategoria, idUnidadeMedida)" +
                            " VALUES (@descricao, @estoqueMinimo, @observacao, @codigoProduto, @idCategoria, @idUnidadeMedida);";
                        MySqlCommand cmd = new MySqlCommand(query, con.connection);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@estoqueMinimo", valorMinimoEstoque);
                        cmd.Parameters.AddWithValue("@observacao", observacao);
                        cmd.Parameters.AddWithValue("@codigoProduto", condigo);
                        //  cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@idUnidadeMedida", idUnidadeMedida);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto cadastrada com sucesso");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                    }
                    finally
                    {
                        con.CloseConnection();

                    }
                }
            }
            else
            {
                MessageBox.Show("Código do produto já cadastrado");
                textBoxCodigoProduto.Clear();
            }
        }

        public bool CheckProductCode()
        {
            string codigoProduto = textBoxCodigoProduto.Text;
            bool codeExists = false;

            try
            {

                if (con.OpenConnection())
                {

                    string query = "SELECT codigoProduto FROM produto WHERE codigoProduto = @codigoProduto";

                    using (MySqlCommand cmd = new MySqlCommand(query, con.connection))
                    {
                        cmd.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                codeExists = true;
                            }
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.CloseConnection();

            }

            return codeExists;
        }


        private void textBoxEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número ");
            }
        }

        private bool ConferirTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxCodigoProduto.Text) ||
                string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(textBoxEstoqueMinimo.Text) ||
                comboBoxCategoriaProduto.SelectedItem == null ||
               comboBoxUnicadeMediaProduto.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return false;
            }

            return true;
        }

        private void textBoxEstoqueMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new formProdutos());
            }
            this.Close();
        }
    }
}
