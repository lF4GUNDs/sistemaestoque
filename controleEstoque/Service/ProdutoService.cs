using controleEstoque.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{
    public class ProdutoService
    {
        Conexao con = new Conexao();

        public List<Produto> buscarListaDeProdutos()
        {
            List<Produto> lista = new List<Produto>();

            if (con.OpenConnection())
            {
                try
                {
                    string query = " select p.id, p.codigoProduto, p.descricao, c.descricao AS categoriaDescricao, " +
                        " un.descricao AS unidadeMedidaDescricao, p.observacao, c.id, p.estoqueMinimo, un.idunidade" +
                        " from produto p" +
                        " inner join categoria c on p.idCategoria = c.id " +
                        " inner join unidadeMedida un on p.idUnidadeMedida = un.idunidade " +
                        " order by descricao asc; ";

                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        int codigoProduto = Convert.ToInt32(dataReader[1]);
                        string? descricao = Convert.ToString(dataReader[2]);
                        string? categoriaDescricao = Convert.ToString(dataReader[3]);
                        string? unidadeMedidaDescricao = Convert.ToString(dataReader[4]);
                        string? observacao = Convert.ToString(dataReader[5]);
                        int idCategoria = Convert.ToInt32(dataReader[6]);
                        double estoqueMinimo = Convert.ToDouble(dataReader[7]);
                        int idUnidadeMedida = Convert.ToInt32(dataReader[8]);

                        Produto produto = new Produto();
                        {
                            produto.id = id;
                            produto.codigoProduto = codigoProduto;
                            produto.idCategoria = idCategoria;
                            if (descricao != null)
                            {
                                produto.descricao = descricao;
                            }
                            if (categoriaDescricao != null)
                            {
                                produto.categoriaDescricao = categoriaDescricao;
                            }
                            if (unidadeMedidaDescricao != null)
                            {
                                produto.unidadeMedidaDescricao = unidadeMedidaDescricao;
                            }

                            if (observacao != null)
                            {
                                produto.observacao = observacao;
                            }
                            
                                produto.estoqueMinimo = estoqueMinimo;
                                produto.idUnidadeMedida = idUnidadeMedida;
                            
                        };
                        lista.Add(produto);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar Lista de Produtos: " + ex.Message);
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

        public void editarProduto(string id, string codigoProduto, string descricao, string idCategoria,
            string idUnidadeMedida, string estoqueMinimo, string observacao)
        {

            if (con.OpenConnection())
            {
                try
                {
                    string query = "update produto set descricao = @descricao, estoqueMinimo = @estoqueMinimo, " +
                                   "observacao = @observacao, codigoProduto = @codigoProduto, idCategoria = @idCategoria," +
                                   "idUnidadeMedida = @idUnidadeMedida " +
                                   "where id = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("@idUnidadeMedida", idUnidadeMedida);
                    cmd.Parameters.AddWithValue("@estoqueMinimo", estoqueMinimo);
                    cmd.Parameters.AddWithValue("@observacao", observacao);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto atualizado com sucesso");
                    var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.FormShow(new EditarProdutoForm());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao  produto: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();

                }

            }


        }

        public bool CheckProductCode(String codigoProduto)
        {
           
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
    }
}

