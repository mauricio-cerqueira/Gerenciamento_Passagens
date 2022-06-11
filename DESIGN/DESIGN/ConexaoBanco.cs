using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DESIGN
{
    class ConexaoBanco
    {
        private static MySqlConnection conn;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        public static void DBConnect()
        {
            Initialize();
        }

        public static void Initialize()
        {
            server = "10.200.116.221";
            database = "Gerencia_de_Passagem";
            uid = "admin";
            password = "senai";
            string myConnectionString;
            myConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void Insert_Usuario(string cpf, string nome, string sobrenome, string senha, string telefone)
        {
            string query = "INSERT INTO CLIENTES(CPF, nome, sobrenome, senha, telefone)" +
                "VALUES('" + cpf + "','" + nome + "','" + sobrenome + "','" + senha + "','" + telefone + "');";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public static string[] ListaCidades()
        {
            string query = "SELECT nome FROM CIDADES";
            string[] list = new string[CountCidades()];
            
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                for (int i = 0; i < list.Length; i++)
                {
                    if (dataReader.Read())
                    {
                        list[i] = dataReader[0] + "";
                    }
                }
                
                dataReader.Close();
                
                CloseConnection();
                
                return list;
            }
            else
            {
                return list;
            }
        }
        public static int CountCidades()
        {
            string query = "SELECT Count(*) FROM CIDADES";
            int Count = -1;
            
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                Count = int.Parse(cmd.ExecuteScalar() + "");
                
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
