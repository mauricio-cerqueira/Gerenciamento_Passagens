using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DESIGN.Data;
using DESIGN.Data.Sistema;

namespace DESIGN.Data
{
    public class FuncoesPassagem
    {
        public string Login(Passageiro passageiro)
        {
            MySqlConnection conexao = null;
            AbreBanco bdPassagem = new AbreBanco();
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("SELECT CPF FROM CLIENTES");
                sb.AppendLine("WHERE CPF='" + passageiro.CPF + "',");
                sb.AppendLine("AND SENHA='" + passageiro.Senha + "';");
                conexao = bdPassagem.abreBancoMySql(conexao);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sb.ToString(), conexao);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {

                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return "";
        }

        public string RegistraPassageiro(Passageiro passageiro)
        {
            MySqlConnection conexao = new MySqlConnection();
            AbreBanco bdPassagem = new AbreBanco();
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("INSERT INTO clientes(Nome,Sobrenome,CPF,Senha,Telefone)");
                sb.AppendLine("VALUES ('" + passageiro.Nome + "',");
                sb.AppendLine("'" + passageiro.Sobrenome + "',");
                sb.AppendLine("'" + passageiro.CPF + "',");
                sb.AppendLine("'" + passageiro.Senha + "',");
                sb.AppendLine("'" + passageiro.Telefone + "')");
                conexao = bdPassagem.abreBancoMySql(conexao);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sb.ToString(), conexao);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {

                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return "";
        }

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






        private bool validarCampos()
        {
            if ()
            {

            }
        }
    }
}
