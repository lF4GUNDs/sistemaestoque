using controleEstoque.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{
    public class CategoriaService
    {
        Conexao con = new Conexao();

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
            if(lista.Count <= 0) 
            {
                MessageBox.Show("Nenhum dado encontrato");
            }
            return lista;

        }
    }
}
