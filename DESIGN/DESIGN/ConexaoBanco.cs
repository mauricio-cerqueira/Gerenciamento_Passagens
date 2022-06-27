using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DESIGN.Data;

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
            server = "localhost";
            database = "gerencia_passagem";
            uid = "root";
            password = "Amister@9958";
            string myConnectionString;
            myConnectionString = "Server=" + server + ";DATABASE=" +
            database + ";User Id=" + uid + ";PASSWORD=" + password + ";";

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

        ///* **********************************************
        // * LOGIN
        // * *********************************************/

        //public static bool Login(string cpf, string senha)
        //{
        //    string query = $"SELECT CPF FROM CLIENTES where CPF = '{cpf}' and senha = '{senha}'";

        //    if (ConexaoBanco.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        if (cmd.ExecuteScalar() != null)
        //        {
        //            ConexaoBanco.CloseConnection();
        //            return true;
        //        }
        //        else
        //        {
        //            ConexaoBanco.CloseConnection();
        //            return false;
        //        }
        //    }
        //    return false;
        //}

        /* **********************************************
         * LISTA DE CIDADES
         * *********************************************/

        public static string[] ListaCidades()
        {
            string query = "SELECT nome FROM CIDADES";
            string[] list = new string[ConexaoBanco.CountCidades()];
            
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
