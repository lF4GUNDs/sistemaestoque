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
    public partial class CadastroUnidadeMedida : Form
    {
        Conexao con = new Conexao();
        public IList<UnidadeMedida>? listaUnidade;
        public CadastroUnidadeMedida()
        {
            InitializeComponent();
            preecherDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            CadastroUnidade();
        }
        private void CadastroUnidade()
        {
            String unidade = textBoxUnidade.Text;
            if (unidade != null && unidade.Length > 0)
            {
                if (con.OpenConnection())
                {
                    try
                    {
                        string query = "INSERT INTO unidademedida (descricao) VALUES (@unidade)";
                        MySqlCommand cmd = new MySqlCommand(query, con.connection);
                        cmd.Parameters.AddWithValue("@unidade", unidade);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Unidade de medida cadastrada com sucesso");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar Unidade de medida: " + ex.Message);
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

        public List<UnidadeMedida> buscarUnidadeMedida()
        {
            List<UnidadeMedida> lista = new List<UnidadeMedida>();

            if (con.OpenConnection())
            {
                try
                {
                    string query = "select idunidade, descricao from unidademedida;";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader["idunidade"]);
                        string? descricao = dataReader["descricao"].ToString();

                        UnidadeMedida unidade = new UnidadeMedida();
                        {
                            unidade.id = id;
                            if (descricao != null)
                            {
                                unidade.descricao = descricao;
                            }

                        };
                        lista.Add(unidade);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar unidade de medida : " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }

            return lista;
        }


        private void preecherDataGrid()
        {
            listaUnidade = buscarUnidadeMedida();
            dataGridViewUnidade.ColumnCount = 2;
            dataGridViewUnidade.Columns[0].Name = "ID";
            dataGridViewUnidade.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewUnidade.Columns[1].Name = "Descrição";
            dataGridViewUnidade.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (UnidadeMedida unidade in listaUnidade)
            {
                dataGridViewUnidade.Rows.Add(unidade.id, unidade.descricao);
            }



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
    }
}
