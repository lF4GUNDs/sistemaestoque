using MySql.Data.MySqlClient;
using System;

namespace controleEstoque.entity
{
    public class Conexao
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public Conexao()
        {
            server = "localhost";
            database = "sistemaestoque";
            uid = "root";
            password = "892312+Pr";

            string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password}";

            connection = new MySqlConnection(connectionString);

        }



        public bool OpenConnection()
        {
            try
            {
                connection.Open();
             //   MessageBox.Show("Conexão bem-sucedida");
                return true;


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool CloseConnection()
        {
            try
            {
                connection.Close();
              //  MessageBox.Show("Conecxão fechada com suscesso");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao fechar o Banco de dados", ex.Message);
                return false;
            }
        }


        public MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteReader();
        }
    }
}
