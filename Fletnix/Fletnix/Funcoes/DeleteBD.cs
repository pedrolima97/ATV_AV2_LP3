using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class DeleteBD
    {
        static public bool sucess = false;
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

                    string InsComand = "DELETE FROM " + table + " WHERE cod_titulo = '" + cod_tittle + "'";
                    MySqlCommand delett = new MySqlCommand(InsComand, connecta);

                    int i = delett.ExecuteNonQuery();

                    if (i == 1)
                    {
                        sucess = true;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }

        public static bool Resposta()
        {
            return sucess;
        }
    }
}
