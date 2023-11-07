using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Conexao
    {
        public MySqlConnection GetConnection()
        {
            string conexaoBanco = ConfigurationManager.ConnectionStrings["BD_loja"].ConnectionString;

            return new MySqlConnection(conexaoBanco);
        }
    }
}
