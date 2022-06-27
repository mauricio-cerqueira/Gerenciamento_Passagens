using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN.Data
{
    public class AbreBanco
    {
        public MySqlConnection abreBancoMySql(MySqlConnection conexao)
        {
            Banco banco = new Banco();

            banco.HostSql = "localhost";
            banco.BdSql = "gerencia_passagem";
            banco.UsuarioSql = "root";
            banco.SenhaSql = "Amister@9958";

            string connectionQuery = "Server=" + banco.HostSql + ";Database=" + banco.BdSql + ";User=" + banco.UsuarioSql
                                     + ";Password=" + banco.SenhaSql + ";";

            conexao = new MySqlConnection(connectionQuery);
            return conexao;
        }
    }
}
