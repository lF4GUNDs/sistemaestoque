using controleEstoque.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{    
    public class MovimentaEstoqueService
    {
        Conexao con = new Conexao();
        public List<MovimentaEstoque> buscarListaMovimentaEstoqueSaida(Boolean abilita, String sql)
        {
            List<MovimentaEstoque> lista = new List<MovimentaEstoque>();

            if (con.OpenConnection())
            {
                try
                {
                    string query = "SELECT mv.id, mv.quantidade, mv.idFuncionario, fu.nome, mv.idProduto, p.descricao, mv.dataMovimentacao," +
                                  " mv.observacao, p.codigoProduto, c.descricao, un.descricao " +
                                  "FROM movimenta_estoque_venda mv " +
                                  "INNER JOIN funcionario fu ON mv.idFuncionario = fu.id " +
                                  "INNER JOIN produto p ON mv.idProduto = p.id " +
                                  "inner join categoria c on p.idCategoria = c.id " +
                                  "inner join unidademedida un on p.idUnidadeMedida = un.idUnidade ";                                  

                    if (abilita)
                    {
                        query = query + sql  ;
                    }

                    query = query + " order by mv.dataMovimentacao desc;";



                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        string? quantidade = Convert.ToString(dataReader[1]);
                        int idFuncionario = Convert.ToInt32(dataReader[2]);
                        string? nomeFuncionario = Convert.ToString(dataReader[3]);
                        int idProduto = Convert.ToInt32(dataReader[4]);
                        string? descricaoProduto = Convert.ToString(dataReader[5]);
                        string? dataMovimentacao = Convert.ToString(dataReader[6]);
                        string? observacao = Convert.ToString(dataReader[7]);
                        string? codigoProduto = Convert.ToString(dataReader[8]);
                        string? descricaoCategoria = Convert.ToString(dataReader[9]);
                        string? unidadeMedida = Convert.ToString(dataReader[10]);


                        MovimentaEstoque mvs = new MovimentaEstoque();
                        {
                            mvs.id = id;
                            mvs.quantidade = quantidade;
                            mvs.idFuncionario = idFuncionario;
                            mvs.nomeFuncionario = nomeFuncionario;
                            mvs.idProduto = idProduto;
                            mvs.descricaoProduto = descricaoProduto;
                            mvs.dataMovimentacao = dataMovimentacao;
                            mvs.observacao = observacao;
                            mvs.codigoProduto = codigoProduto;
                            mvs.descricaoCategoria = descricaoCategoria;
                            mvs.descricaoUnidadeMedida = unidadeMedida;

                        

                        };
                        lista.Add(mvs);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar Lista de Saída: " + ex.Message);
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
       
        public List<MovimentaEstoque> buscarListaMovimentaEstoqueEntrada(Boolean abilita, String sql)
        {
            List<MovimentaEstoque> lista = new List<MovimentaEstoque>();

            if (con.OpenConnection())
            {
                try
                {
                    string query = "SELECT mc.id, mc.quantidade, mc.idFornecedor, fo.nome as nomeFornecedor, " +
                        " mc.IdProduto, p.descricao, mc.dataMovimentacao, p.codigoProduto, c.descricao as descricaoCategoria, " +
                        " un.descricao as descricaoUnidadeMedida   " +
                        " FROM movimenta_estoque_compra mc " +
                        " inner join fornecedor fo on mc.idFornecedor = fo.id " +
                        " INNER JOIN produto p ON mc.IdProduto = p.id  " +
                        " inner join categoria c on p.idCategoria = c.id  " +
                        " inner join unidademedida un on p.idUnidadeMedida = un.idUnidade  ";
                       

                    if (abilita)
                    {
                        query = query + sql;
                    }

                    query = query + " order by mc.dataMovimentacao desc;";



                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        string? quantidade = Convert.ToString(dataReader[1]);
                        int idFornecedor = Convert.ToInt32(dataReader[2]);
                        string? nomeFornecedor = Convert.ToString(dataReader[3]);
                        int idProduto = Convert.ToInt32(dataReader[4]);
                        string? descricaoProduto = Convert.ToString(dataReader[5]);
                        string? dataMovimentacao = Convert.ToString(dataReader[6]);                       
                        string? codigoProduto = Convert.ToString(dataReader[7]);
                        string? descricaoCategoria = Convert.ToString(dataReader[8]);
                        string? unidadeMedida = Convert.ToString(dataReader[9]);


                        MovimentaEstoque mvs = new MovimentaEstoque();
                        {
                            mvs.id = id;
                            mvs.quantidade = quantidade;
                            mvs.idFornecedor = idFornecedor;
                            mvs.nomeFornecedor = nomeFornecedor;
                            mvs.idProduto = idProduto;
                            mvs.descricaoProduto = descricaoProduto;
                            mvs.dataMovimentacao = dataMovimentacao;                           
                            mvs.codigoProduto = codigoProduto;
                            mvs.descricaoCategoria = descricaoCategoria;
                            mvs.descricaoUnidadeMedida = unidadeMedida;


                        };
                        lista.Add(mvs);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar Lista de Entrada: " + ex.Message);
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
