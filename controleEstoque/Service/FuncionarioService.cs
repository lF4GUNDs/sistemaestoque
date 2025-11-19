using controleEstoque.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace controleEstoque.Service
{
   
    public class FuncionarioService
    {
        Conexao con = new Conexao();
        public List<Funcionario> buscarListaDeFuncionario()
        {
            List<Funcionario> lista = new List<Funcionario>();

            if (con.OpenConnection())
            {
                try
                {
                    
                    string query = " select id, nome, contato, cidade, cpf_cnpj, cargo, dataCadastro from funcionario ";

                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader[0]);
                        string? nome = Convert.ToString(dataReader[1]);
                        string? contato = Convert.ToString(dataReader[2]);
                        string? cidade = Convert.ToString(dataReader[3]);
                        string? cpf_cnpj = Convert.ToString(dataReader[4]);
                        string? cargo = Convert.ToString(dataReader[5]);
                        string? dataCadastro = Convert.ToString(dataReader[6]);


                        Funcionario funcionario = new Funcionario();
                        {
                            funcionario.id = id;
                            funcionario.nome = nome;
                            funcionario.contato = contato;
                            funcionario.cidade = cidade;
                            funcionario.cpf_cnpj = cpf_cnpj;
                            funcionario.cargo = cargo;
                            funcionario.dataCadastro = dataCadastro;

                        };
                        lista.Add(funcionario);
                    }

                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar Lista de Funcionarios: " + ex.Message);
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

        public void cadastrarFuncionario(String nome, String cargo, String contato, String cidade, String cpf_cnpj)
        {
                if (con.OpenConnection())
                {
                    try
                    {
                        string query = "INSERT INTO funcionario  (nome, contato, cidade, cpf_cnpj, cargo)" +
                            " VALUES (@nome, @contato, @cidade,@cpf_cnpj, @cargo );";
                        MySqlCommand cmd = new MySqlCommand(query, con.connection);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@contato", contato);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@cpf_cnpj", cpf_cnpj);
                        cmd.ExecuteNonQuery();

                      MessageBox.Show("Cadastrado com sucesso");
                   
                    var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.FormShow(new CadastroFuncionario());
                    }
                }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
                    }
                    finally
                    {
                        con.CloseConnection();

                    }
                }           
        }

        public void editarFuncionario(String id , String cpf_cnpj, String dataCadastro, String nome , String cargo, String cidade, String contato) 
        {

            if (con.OpenConnection())
            {
                try
                {
                    string query = "UPDATE funcionario SET nome = @nome, cargo = @cargo, cidade = @cidade, contato = @contato  WHERE id = @id;";

                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    cmd.Parameters.AddWithValue("@id", id);
                  //  cmd.Parameters.AddWithValue("@cpf_cnpj", cpf_cnpj);
                 //  cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário atualizado com sucesso");
                    var principal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.FormShow(new EditarFuncionario());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao  editar funcionário: " + ex.Message);
                }
                finally
                {
                    con.CloseConnection();

                }

            }


        }
    }
}
