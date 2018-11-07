using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class BuscaBD
    {
        static public void Buscar(string cod_tittle, string tipo)
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

                    string InsComand = "SELECT titulo, produtora, genero, sinopse, duracao, lancamento, direcao FROM " + table + " WHERE cod_titulo='" + cod_tittle + "'";
                    MySqlCommand buscaa = new MySqlCommand(InsComand, connecta);
                    MySqlDataReader tittlee = buscaa.ExecuteReader();

                    tittlee.Read();
                    tittle.Nome = tittlee["titulo"].ToString();
                    tittle.Produtora = tittlee["produtora"].ToString();
                    tittle.Genero = tittlee["genero"].ToString();
                    tittle.Sinopse = tittlee["sinopse"].ToString();
                    tittle.Duracao = tittlee["duracao"].ToString();
                    tittle.Lancamento = Convert.ToInt32(tittlee["lancamento"]);
                    tittle.Direcao = tittlee["direcao"].ToString();

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
