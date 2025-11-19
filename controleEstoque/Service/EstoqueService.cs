using controleEstoque.entity;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{
    public class EstoqueService
    {
        Conexao con = new Conexao();       

        public List<Estoque> buscarEstoque()
        {
            List<Estoque> lista = new List<Estoque>(); 
            

            if (con.OpenConnection())
            {
                try
                {
                    string query = "select id, quantidade, dataMovimentacao, idProduto from estoque;";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        double quantidade  = Convert.ToDouble(dataReader[1]);
                        string dataMovimentacao = Convert.ToString(dataReader[2]);
                        int idProduto = Convert.ToInt32(dataReader[3]);
                        Estoque estoque = new Estoque();
                        {
                           estoque.id = id;
                            estoque.quantidade = quantidade;
                            estoque.dataMovimentacao = dataMovimentacao;
                            estoque.idProduto = idProduto;

                        };
                        lista.Add(estoque);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar relatório estoque: " + ex.Message);
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

        public void movimentaEstoqueCompras(double quantidade, int idProduto, string quantidadeUnitaria, string idFornecedor)
        {
            
            int rowsAffected = 0;

            if (con.OpenConnection())
            {
                try
                {

                    string updateQuery = "UPDATE estoque SET quantidade = @quantidade WHERE idProduto = @idProduto";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con.connection);

                    updateCmd.Parameters.AddWithValue("@quantidade", quantidade);
                    updateCmd.Parameters.AddWithValue("@idProduto", idProduto);
                    rowsAffected = updateCmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO movimenta_estoque_compra (quantidade, idProduto, idFornecedor) VALUES (@quantidadeUnitaria, @idProdutoMovimenta, @idFornecedor)";
                            MySqlCommand insertCmd = new MySqlCommand(insertQuery, con.connection);

                            insertCmd.Parameters.AddWithValue("@quantidadeUnitaria", quantidadeUnitaria);
                            insertCmd.Parameters.AddWithValue("@idProdutoMovimenta", idProduto);
                            insertCmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                            insertCmd.ExecuteNonQuery();

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Erro ao Movimentar Tabela Movimena Estoque Compra: " + ex.Message);
                        }
                    }

                   
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao Movimentar Estoque: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void movimentaEstoqueSaida(double quantidade, int idProduto, string quantidadeUnitaria, string idFuncionario, String observacao)
        {

            int rowsAffected = 0;

            if (con.OpenConnection())
            {
                try
                {

                    string updateQuery = "UPDATE estoque SET quantidade = @quantidade WHERE idProduto = @idProduto";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con.connection);

                    updateCmd.Parameters.AddWithValue("@quantidade", quantidade);
                    updateCmd.Parameters.AddWithValue("@idProduto", idProduto);
                    rowsAffected = updateCmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO movimenta_estoque_venda (quantidade, idProduto, idFuncionario, observacao) VALUES (@quantidadeUnitaria, @idProdutoMovimenta, @idFuncionario, @observacao)";
                            MySqlCommand insertCmd = new MySqlCommand(insertQuery, con.connection);

                            insertCmd.Parameters.AddWithValue("@quantidadeUnitaria", quantidadeUnitaria);
                            insertCmd.Parameters.AddWithValue("@idProdutoMovimenta", idProduto);
                            insertCmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                            insertCmd.Parameters.AddWithValue("@observacao", observacao);
                            insertCmd.ExecuteNonQuery();

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Erro ao Movimentar Tabela Movimena Estoque Saída: " + ex.Message);
                        }
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao Movimentar Estoque: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public List<Estoque> buscarEstoqueRelatorio()
        {
            List<Estoque> lista = new List<Estoque>();


            if (con.OpenConnection())
            {
                try
                {
                    string query = "select es.id as idEstoque, p.id as idProduto , p.descricao as descricaoProduto, un.descricao as descricaoUnidadeMedida, " +
                        " es.quantidade,c.descricao as descricaoCategoria, es.dataMovimentacao, p.codigoProduto as codigoProduto, c.id as idCategoria " +
                        " from estoque es  " +
                        " inner join produto p on es.idProduto = p.id " +
                        " inner join categoria c on p.idCategoria = c.id " +
                        " inner join unidademedida un on p.idUnidadeMedida = un.idunidade " +
                        " order by es.dataMovimentacao desc ; ";

                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        int idProduto = Convert.ToInt32(dataReader[1]);
                        string descricaoProduto = Convert.ToString(dataReader[2]);
                        string descricaoUnidadeMedida = Convert.ToString(dataReader[3]);
                        double quantidade = Convert.ToDouble(dataReader[4]);
                        string descricaoCategoria = Convert.ToString(dataReader[5]);
                        DateTime dataMovimentacao = Convert.ToDateTime(dataReader[6]);                      
                        string codigoProduto = Convert.ToString(dataReader[7]);
                        int idCategoria = Convert.ToInt32(dataReader[8]);
                        string dataFormatada = dataMovimentacao.ToString("dd/MM/yyyy HH:mm:ss");
                       



                        Estoque estoque = new Estoque();
                        {
                            estoque.id = id;
                            estoque.idProduto = idProduto;
                            estoque.descricaoProduto = descricaoProduto;
                            estoque.descricaoUnidadeMedida = descricaoUnidadeMedida;
                            estoque.quantidade = quantidade;
                            estoque.descricaoCategoria = descricaoCategoria;
                            estoque.dataMovimentacao = dataFormatada;
                            estoque.codigoProduto = codigoProduto;
                            estoque.idCategoria = idCategoria;

                        };
                        lista.Add(estoque);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar relatório estoque: " + ex.Message);
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

