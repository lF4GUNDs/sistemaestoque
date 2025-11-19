using controleEstoque.entity;
using DocumentFormat.OpenXml.Office2010.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Service
{
    public class ValidaCadastraUsuario
    {
        Conexao con = new Conexao();
        public bool validaUsuario(string usuario, string senha)
        {
            if (con.OpenConnection())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM usuario WHERE login = @usuario AND senha = @senha";
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao buscar usuário: " + ex.Message);
                    return false; // Retorna falso em caso de exceção
                }
                finally
                {
                    con.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Erro ao conectar com o banco de dados ");
                return false; // Retorna falso se não puder abrir a conexão com o banco de dados
            }
        }

    }
}
