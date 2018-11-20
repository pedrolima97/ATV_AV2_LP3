using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    sealed class ReaderDGV
    {
        static private MySqlDataReader tittlee = null;

        static public MySqlDataReader GetDataReader()
        {
            using (MySqlConnection connecta = Dados.DAO_conn.getSqlConnection())
                try
                {
                    connecta.Open();
                    string InsComand = "SELECT cod_titulo, titulo FROM filmes";
                    MySqlCommand buscaa = new MySqlCommand(InsComand, connecta);
                    tittlee = buscaa.ExecuteReader();
                }

                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                finally
                {
                    connecta.Close();
                }
            return tittlee;
        }
    }
}
