using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Dados
{
    sealed class DAO_conn
    {
        static private MySqlConnection conn = null;

        private DAO_conn()
        { }

        static public MySqlConnection getSqlConnection()
        {
            if (conn == null)
            {
            string connet = "Server=localhost;Database=filmeseseries;Uid=pedro;Pwd=2a4d5M675U2CD!";
            conn = new MySqlConnection(connet);
            }

            return conn;
        }
    }
}
