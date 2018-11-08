using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix
{
    class Remover
    {
        static public void Delete(string cod_tittle, string tipo)
        {
            using (MySqlConnection connecta = Dados.DAO_conn.getSqlConnection())
                try
                {
                    string table = "";
                    connecta.Open();
                    if (tipo == "serie")
                    {
                        table = "series";
                    }

                    else if (tipo == "filme")
                    {
                        table = "filmes";
                    }

                    string InsComand = "DELETE FROM " + table + "WHERE cod_titulo = '" + cod_tittle + "'";
                    MySqlCommand insertt = new MySqlCommand(InsComand, connecta);
                    insertt.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }
    }
}
