using controleEstoque.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{
    public class FornecedorService
    {
        Conexao con = new Conexao();
        public List<Fornecedor> buscarListaDeFornecedor()
        {
            List<Fornecedor> lista = new List<Fornecedor>();

            if (con.OpenConnection())
            {
                try
                {
                    string query = " select id, nome, cpf_cnpj, endereco, cidade, telefone, email,contato, bairro, dataCadastro from fornecedor p ";

                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        string? nome = Convert.ToString(dataReader[1]);
                        string? cpf_cnp = Convert.ToString(dataReader[2]);
                        string? endreco = Convert.ToString(dataReader[3]);
                        string? cidade = Convert.ToString(dataReader[4]);
                        string? telefone = Convert.ToString(dataReader[5]);
                        string? email = Convert.ToString(dataReader[6]);
                        string? contato = Convert.ToString(dataReader[7]);
                        string? bairro = Convert.ToString(dataReader[8]);
                        string? dataCadastro = Convert.ToString(dataReader[9]);


                        Fornecedor fornecedor = new Fornecedor();
                        {
                            fornecedor.id = id;
                            fornecedor.nome = nome;
                            fornecedor.cpf_cnpj = cpf_cnp;
                            fornecedor.endreco = endreco;
                            fornecedor.cidade = cidade;
                            fornecedor.telefone = telefone;
                            fornecedor.email = email;
                            fornecedor.contato = contato;
                            fornecedor.bairro = bairro;
                            fornecedor.dataCadastro = dataCadastro;



                        };
                        lista.Add(fornecedor);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar Lista de Fornecedores: " + ex.Message);
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

        public void cadastrarFornededor(String nome, String cpf_cnpj, String endereco, String telefone, String email, String contato,
            String bairro, String cidade)
        {

            if (con.OpenConnection())
            {
                try
                {
                    string query = "INSERT INTO fornecedor (nome, cpf_cnpj, endereco, cidade, telefone, email, contato, bairro)" +
                        " VALUES (@nome, @cpf_cnpj, @endereco, @cidade, @telefone, @email, @contato, @bairro);";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.Parameters.AddWithValue("@bairro", bairro);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor cadastrada com sucesso");

                    var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.FormShow(new CadastroFornecedor());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();

                }
            }

        }

        public void editarFornecedor(String id, String nome, String cpf_cnpj, String endereco, String telefone, String email, String contato,
            String bairro, String cidade)
        {

            if (con.OpenConnection())
            {
                try
                {
                    string query = "update fornecedor set nome = @nome, cpf_cnpj  = @cpf_cnpj , " +
                                   "cidade = @cidade, endereco = @endereco, cidade = @cidade," +
                                   "telefone = @telefone,  email = @email,  contato = @contato, bairro = @bairro  " +
                                   "where id = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor atualizado com sucesso");

                    var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.FormShow(new EditarFornecedor());
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao  atualizar fornecedor: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();

                }

            }


        }
    }
}

