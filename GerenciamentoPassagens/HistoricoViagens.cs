using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GerenciamentoPassagens
{
    class HistoricoViagens
    {
        private static MySqlConnection conn;

        public static int CountPassagens()
        {
            string query = "SELECT Count(*) FROM Passagens WHERE nomePassageiro LIKE '%" + "%'";
            int Count = -1;

            if (ConexaoBanco.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                Count = int.Parse(cmd.ExecuteScalar() + "");

                ConexaoBanco.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static string[] ListaHistorico()
        {
            string query = "SELECT * FROM Passagens";
            string[] list = new string[CountPassagens()];
            
            if (ConexaoBanco.OpenConnection() == true)
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

                ConexaoBanco.CloseConnection();
                
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
