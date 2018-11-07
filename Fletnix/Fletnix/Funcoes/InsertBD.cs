using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class InsertBD
    {
        static public void Insert()
        {
            FilmeSerie tittle = new FilmeSerie();
            using (MySqlConnection connecta = Dados.DAO_conn.getSqlConnection())
                try
                {
                    string table = "";
                    connecta.Open();
                    if (tittle.Tipo == "serie")
                    {
                        table = "series";
                    }

                    else if (tittle.Tipo == "filme")
                    {
                        table = "filmes";
                    }

                    string InsComand = "INSERT INTO " + table + " (cod_titulo ,titulo, produtora, genero, sinopse, duracao, lancamento, direcao)" +
                        "VALUES('" + tittle.Cod + "','" + tittle.Nome + "','" + tittle.Produtora + "','" + tittle.Genero + "','" + tittle.Sinopse +
                        "', '" + tittle.Duracao + "', '" + tittle.Lancamento + "', '" + tittle.Direcao + "'";
                    MySqlCommand insertt = new MySqlCommand(InsComand, connecta);
                    insertt.ExecuteNonQuery();

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
