using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class UpdateBD
    {
        static public void Update(string cod_tittle, string tipo)
        {
            FilmeSerie tittle = new FilmeSerie();
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

                    string InsComand = "UPDATE " + table + " SET cod_titulo = '" + tittle.Cod + "', titulo = '" + tittle.Nome + "'," +
                        "produtora = '" + tittle.Produtora + "', genero = '" + tittle.Genero + "', sinopse = '" + tittle.Sinopse + "'," +
                        "duracao =  '" + tittle.Duracao + "', lancamento = '" + tittle.Lancamento + "', direcao = '" + tittle.Direcao + " WHERE cod_titulo = '" + cod_tittle + "'";
                    MySqlCommand updatee = new MySqlCommand(InsComand, connecta);
                    updatee.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Erro:" + ex.Message);
                }

                finally
                {
                    connecta.Close();
                }
        }
    }
}
