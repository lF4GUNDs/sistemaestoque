using controleEstoque.entity;
using MySql.Data.MySqlClient;
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
    public partial class AdicionarCategoria : Form
    {
        Conexao con = new Conexao();
        public IList<Categoria>? listaCategoria;

        public AdicionarCategoria()
        {
            InitializeComponent();
            preecherDataGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cadastroCategoria()
        {
            String categoria = textBoxCategoria.Text;
            if (categoria != null && categoria.Length > 0)
            {
                if (con.OpenConnection())
                {
                    try
                    {
                        string query = "INSERT INTO categoria (descricao) VALUES (@categoria)";
                        MySqlCommand cmd = new MySqlCommand(query, con.connection);
                        cmd.Parameters.AddWithValue("@categoria", categoria);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoria cadastrada com sucesso");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar categorias: " + ex.Message);
                    }
                    finally
                    {
                        con.CloseConnection();
                        atualizarComboxProduto();
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo categoria invalido");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastroCategoria();

        }



        private void atualizarComboxProduto()
        {
            var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
            if (principal != null)
            {
                principal.FormShow(new CadastroProdutos());
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public List<Categoria> buscarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();

            if (con.OpenConnection())
            {
                try
                {
                    string query = "select id, descricao from categoria;";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader["id"]);
                        string? descricao = dataReader["descricao"].ToString();

                        Categoria categoria = new Categoria();
                        {
                            categoria.id = id;
                            if (descricao != null)
                            {
                                categoria.descricao = descricao;
                            }

                        };
                        lista.Add(categoria);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar categorias: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }

            return lista;
        }



        private void dataGridViewCategoriaCadastradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void preecherDataGrid()
        {
            listaCategoria = buscarCategoria();
            dataGridViewCategoriaCadastradas.ColumnCount = 2;
            dataGridViewCategoriaCadastradas.Columns[0].Name = "ID";
            dataGridViewCategoriaCadastradas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategoriaCadastradas.Columns[1].Name = "Descrição";
            dataGridViewCategoriaCadastradas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (Categoria categoria in listaCategoria)
            {
                dataGridViewCategoriaCadastradas.Rows.Add(categoria.id, categoria.descricao);
            }



        }

        private void textBoxCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
