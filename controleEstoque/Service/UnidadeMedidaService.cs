using controleEstoque.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{
    public class UnidadeMedidaService
    {
        Conexao con = new Conexao();

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
                    MessageBox.Show("Erro ao buscar Uidade de Medida: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }

            if (lista.Count <= 0)
            {
                MessageBox.Show("Nenhum dado encontrato");
            }

            return lista;
        }

    }
}
